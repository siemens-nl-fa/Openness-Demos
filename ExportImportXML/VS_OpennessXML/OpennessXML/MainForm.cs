using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Own Library
using OpennessLibrary;

// Siemens Library
using Siemens.Engineering;
using Siemens.Engineering.Cax;
using Siemens.Engineering.Compiler;
using Siemens.Engineering.Compare;
using Siemens.Engineering.Connection;
using Siemens.Engineering.Download;
using Siemens.Engineering.Download.Configurations;
using Siemens.Engineering.Hmi;
using Siemens.Engineering.Hmi.Cycle;
using Siemens.Engineering.Hmi.Communication;
using Siemens.Engineering.Hmi.Globalization;
using Siemens.Engineering.Hmi.RuntimeScripting;
using Siemens.Engineering.Hmi.Screen;
using Siemens.Engineering.Hmi.Tag;
using Siemens.Engineering.Hmi.TextGraphicList;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Extensions;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.HW.Utilities;
using Siemens.Engineering.Library;
using Siemens.Engineering.Library.MasterCopies;
using Siemens.Engineering.Library.Types;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Blocks;
using Siemens.Engineering.SW.ExternalSources;
using Siemens.Engineering.SW.Tags;
using Siemens.Engineering.SW.TechnologicalObjects;
using Siemens.Engineering.SW.TechnologicalObjects.Motion;
using Siemens.Engineering.SW.Types;
using Siemens.Engineering.Upload;

namespace OpennessXML
{
    public partial class MainForm : Form
    {
        // Openness class (class with standard openness functionalities).
        Openness opns = new Openness();

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #region Menu
        /// <summary>
        /// Restarts the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Start PLCSIM Advanced 3.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_StartPLCSIMAdvanced_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files (x86)\Siemens\Automation\PLCSIMADV\bin\Siemens.Simatic.PlcSim.Advanced.UserInterface.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }
        #endregion

        #region TIA Portal + Project
        /// <summary>
        /// Starts an instance of TIA Portal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_StartTIA_Click(object sender, EventArgs e)
        {
            opns.TiaPortal_Start(TiaPortalMode.WithUserInterface);
        }

        /// <summary>
        /// Connect to an instance of TIA Portal .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ConnectTIA_Click(object sender, EventArgs e)
        {
            ConnectDialog connectDialog = new ConnectDialog();
            if (connectDialog.ShowDialog() == DialogResult.OK)
            {
                opns.TiaPortal_Connect(connectDialog.SelectedProcess);
            }
            UpdatePLCList();
        }

        /// <summary>
        /// Open a project in TIA Portal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                opns.Project_Open(new FileInfo(openFileDialog.FileName));
            }
            UpdatePLCList();
        }

        /// <summary>
        /// Save a TIA Portal project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveProject_Click(object sender, EventArgs e)
        {
            opns.Project_Save();
        }

        /// <summary>
        /// Close a TIA Portal project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CloseProject_Click(object sender, EventArgs e)
        {
            opns.Project_Close();
        }

        /// <summary>
        /// Disconnect TIA Portal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DisconnectTIA_Click(object sender, EventArgs e)
        {
            opns.TiaPortal_Disconnect();
        }

        /// <summary>
        /// Close TIA Portal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CloseTIA_Click(object sender, EventArgs e)
        {
            opns.TiaPortal_Close();
        }

        /// <summary>
        /// Timer event that fires every second to update the TIA Portal connection status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (opns.TiaPortal != null)
            {
                statusLabel_TIAConnectie.Text = $"TIA Portal - Connected ({opns.TiaPortalProcess.Id})";
            }
            else
            {
                statusLabel_TIAConnectie.Text = "TIA Portal - Disconnected";
            }

            if (opns.Project != null)
            {
                statusLabel_ProjectConnectie.Text = $"Project - Connected ({opns.Project.Name})";
            }
            else
            {
                statusLabel_ProjectConnectie.Text = "Project - Disconnected";
            }
        }
        #endregion

        #region Update Display
        /// <summary>
        /// Button to refresh the devices.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_RefreshPLC_Click(object sender, EventArgs e)
        {
            UpdatePLCList();
            UpdateSoftware();
        }

        /// <summary>
        /// List the devices in the combobox.
        /// </summary>
        private void UpdatePLCList()
        {
            comboBox_SelectPLC.Items.Clear();

            List<Device> devices = opns.Project_GetDevices();
            if (devices != null)
            {
                foreach (Device device in devices)
                {
                    if (device.TypeIdentifier != null)
                    {
                        if (device.TypeIdentifier.Contains("S71500") || device.TypeIdentifier.Contains("S71200") || device.TypeIdentifier.Contains("ET200"))
                        {
                            comboBox_SelectPLC.Items.Add(device.Name);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// List the programblocks and external sources in the treeview.
        /// </summary>
        private void UpdateSoftware()
        {
            treeView_ProgramBlocks.Nodes.Clear();
            treeView_TechnologyObjects.Nodes.Clear();
            treeView_TagTables.Nodes.Clear();
            treeView_PlcDataTypes.Nodes.Clear();

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            if (plcSoftware != null)
            {
                if (plcSoftware != null)
                {
                    PlcBlockSystemGroup plcBlockSystemGroup = plcSoftware.BlockGroup;
                    foreach (PlcBlock block in plcBlockSystemGroup.Blocks)
                    {
                        TreeNode node = treeView_ProgramBlocks.Nodes.Add(block.Name);
                        node.Tag = block;
                    }

                    TechnologicalInstanceDBGroup technologicalInstanceDBSystemGroup = plcSoftware.TechnologicalObjectGroup;
                    foreach (TechnologicalInstanceDB to in technologicalInstanceDBSystemGroup.TechnologicalObjects)
                    {
                        TreeNode node = treeView_TechnologyObjects.Nodes.Add(to.Name);
                        node.Tag = to;
                    }

                    PlcTagTableSystemGroup plcTagTableSystemGroup = plcSoftware.TagTableGroup;
                    foreach (PlcTagTable tagTable in plcTagTableSystemGroup.TagTables)
                    {
                        TreeNode node = treeView_TagTables.Nodes.Add(tagTable.Name);
                        node.Tag = tagTable;
                    }

                    PlcTypeSystemGroup plcTypeSystemGroup = plcSoftware.TypeGroup;
                    foreach (PlcStruct udt in plcTypeSystemGroup.Types)
                    {
                        TreeNode node = treeView_PlcDataTypes.Nodes.Add(udt.Name);
                        node.Tag = udt;
                    }
                }
            }
        }

        /// <summary>
        /// Update the software list after a plc is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectPLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSoftware();
            textBox_SelectedPLC.Text = comboBox_SelectPLC.Text;
        }

        /// <summary>
        /// Show the name of the selected programblock in a textbox and set the tag property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_ProgramBlocks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_ProgramBlocks.SelectedNode != null)
            {
                PlcBlock block = (PlcBlock)treeView_ProgramBlocks.SelectedNode.Tag;
                textBox_SelectedProgramBlock.Text = $"{block.Name}.{block.ProgrammingLanguage}";
                textBox_SelectedProgramBlock1.Text = $"{block.Name}.{block.ProgrammingLanguage}";
            }
        }

        /// <summary>
        /// Show the name of the selected external source file in a textbox and set the tag property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_TagTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_TagTables.SelectedNode != null)
            {
                PlcTagTable tagTable = (PlcTagTable)treeView_TagTables.SelectedNode.Tag;
                textBox_SelectedTagTable.Text = $"{tagTable.Name}";
            }
        }

        private void treeView_TechnologyObjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_TechnologyObjects.SelectedNode != null)
            {
                TechnologicalInstanceDB to = (TechnologicalInstanceDB)treeView_TechnologyObjects.SelectedNode.Tag;
                textBox_SelectedTechnologyObject.Text = $"{to.Name}";
            }
        }

        private void treeView_PlcDataTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_PlcDataTypes.SelectedNode != null)
            {
                PlcStruct udt = (PlcStruct)treeView_PlcDataTypes.SelectedNode.Tag;
                textBox_SelectedUDT.Text = $"{udt.Name}";
            }
        }
        #endregion

        #region Compile
        /// <summary>
        /// Compile the selected programblock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CompileBlock_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || treeView_ProgramBlocks.SelectedNode.Tag == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
                PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);

                PlcBlock block = (PlcBlock)treeView_ProgramBlocks.SelectedNode.Tag;
                ICompilable compilable = block.GetService<ICompilable>();
                CompilerResult compilerResult = compilable.Compile();

                int index = dataGridView_Results.Rows.Add();
                switch (compilerResult.State)
                {
                    case CompilerResultState.Success:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.success;
                        break;
                    case CompilerResultState.Information:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                    case CompilerResultState.Warning:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.warning;
                        break;
                    case CompilerResultState.Error:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.error;
                        break;
                    default:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                }
                dataGridView_Results.Rows[index].Cells["Path"].Value = "";
                dataGridView_Results.Rows[index].Cells["Description"].Value = $"Compiling {block.Name} ({block.ProgrammingLanguage})";
                dataGridView_Results.Rows[index].Cells["Warnings"].Value = compilerResult.WarningCount;
                dataGridView_Results.Rows[index].Cells["Errors"].Value = compilerResult.ErrorCount;
                dataGridView_Results.Rows[index].Cells["Time"].Value = "";

                GetCompilerMessages(compilerResult.Messages);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        /// <summary>
        /// Compile all program blocks from the selected plc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CompilePLC_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
                ICompilable compilable = device.GetService<ICompilable>();
                CompilerResult compilerResult = compilable.Compile();

                int index = dataGridView_Results.Rows.Add();
                switch (compilerResult.State)
                {
                    case CompilerResultState.Success:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.success;
                        break;
                    case CompilerResultState.Information:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                    case CompilerResultState.Warning:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.warning;
                        break;
                    case CompilerResultState.Error:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.error;
                        break;
                    default:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                }
                dataGridView_Results.Rows[index].Cells["Path"].Value = "";
                dataGridView_Results.Rows[index].Cells["Description"].Value = $"Compiling {device.Name}";
                dataGridView_Results.Rows[index].Cells["Warnings"].Value = compilerResult.WarningCount;
                dataGridView_Results.Rows[index].Cells["Errors"].Value = compilerResult.ErrorCount;
                dataGridView_Results.Rows[index].Cells["Time"].Value = "";

                GetCompilerMessages(compilerResult.Messages);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        /// <summary>
        /// Get the compiler messages.
        /// </summary>
        /// <param name="compilerResultMessages"></param>
        private void GetCompilerMessages(CompilerResultMessageComposition compilerResultMessages)
        {
            foreach (CompilerResultMessage compilerResultMessage in compilerResultMessages)
            {
                int index = dataGridView_Results.Rows.Add();

                switch (compilerResultMessage.State)
                {
                    case CompilerResultState.Success:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.success;
                        break;
                    case CompilerResultState.Information:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                    case CompilerResultState.Warning:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.warning;
                        break;
                    case CompilerResultState.Error:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.error;
                        break;
                    default:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                }
                dataGridView_Results.Rows[index].Cells["Path"].Value = compilerResultMessage.Path;
                dataGridView_Results.Rows[index].Cells["Description"].Value = compilerResultMessage.Description;
                dataGridView_Results.Rows[index].Cells["Warnings"].Value = compilerResultMessage.WarningCount;
                dataGridView_Results.Rows[index].Cells["Errors"].Value = compilerResultMessage.ErrorCount;
                dataGridView_Results.Rows[index].Cells["Time"].Value = compilerResultMessage.DateTime.ToLocalTime().ToShortTimeString();

                GetCompilerMessages(compilerResultMessage.Messages);
            }
        }
        #endregion

        #region Download
        /// <summary>
        /// Download to plc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DownloadPLC_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
                DeviceItem cpu = opns.Device_GetCPU(device);
                DownloadProvider downloadProvider = cpu.GetService<DownloadProvider>();

                ConnectionConfiguration connConfig = downloadProvider.Configuration;
                ConfigurationMode configurationMode = connConfig.Modes.Find("PN/IE");
                
                ConfigurationPcInterface pcInterface = configurationMode.PcInterfaces.Find(comboBox_PcInterface.Text, comboBox_PcInterface.SelectedIndex + 1);
                ConfigurationTargetInterface targetInterface = pcInterface.TargetInterfaces.Find(comboBox_TargetInterface.Text);

                //Intel(R) 82574L Gigabit Network Connection
                //PLCSIM

                //ConfigurationSubnet subnet = pcInterface.Subnets.Find("PN/IE_1");
                //IConfiguration targetConfiguration = subnet.Addresses.Find("192.168.0.1");

                IConfiguration targetConfiguration = targetInterface;
                bool isConfigured = connConfig.ApplyConfiguration(targetInterface);

                DownloadConfigurationDelegate preDownloadDelegate = PreConfigureDownload;
                DownloadConfigurationDelegate postDownloadDelegate = PostConfigureDownload;

                DownloadResult downloadResult = downloadProvider.Download(targetConfiguration, preDownloadDelegate, postDownloadDelegate, DownloadOptions.Software);

                int index = dataGridView_Results.Rows.Add();

                switch (downloadResult.State)
                {
                    case DownloadResultState.Success:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.success;
                        break;
                    case DownloadResultState.Information:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                    case DownloadResultState.Warning:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.warning;
                        break;
                    case DownloadResultState.Error:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.error;
                        break;
                    default:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                }
                dataGridView_Results.Rows[index].Cells["Path"].Value = "";
                dataGridView_Results.Rows[index].Cells["Description"].Value = $"Downloading {device.Name}";
                dataGridView_Results.Rows[index].Cells["Warnings"].Value = downloadResult.WarningCount;
                dataGridView_Results.Rows[index].Cells["Errors"].Value = downloadResult.ErrorCount;
                dataGridView_Results.Rows[index].Cells["Time"].Value = "";

                GetDownloadMessages(downloadResult.Messages);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        /// <summary>
        /// Get the download messages.
        /// </summary>
        /// <param name="downloadResultMessages"></param>
        private void GetDownloadMessages(DownloadResultMessageComposition downloadResultMessages)
        {
            foreach (DownloadResultMessage downloadResultMessage in downloadResultMessages)
            {
                int index = dataGridView_Results.Rows.Add();

                switch (downloadResultMessage.State)
                {
                    case DownloadResultState.Success:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.success;
                        break;
                    case DownloadResultState.Information:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                    case DownloadResultState.Warning:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.warning;
                        break;
                    case DownloadResultState.Error:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.error;
                        break;
                    default:
                        dataGridView_Results.Rows[index].Cells["State"].Value = Properties.Resources.information;
                        break;
                }
                dataGridView_Results.Rows[index].Cells["Path"].Value = "";
                dataGridView_Results.Rows[index].Cells["Description"].Value = downloadResultMessage.Message;
                dataGridView_Results.Rows[index].Cells["Warnings"].Value = downloadResultMessage.WarningCount;
                dataGridView_Results.Rows[index].Cells["Errors"].Value = downloadResultMessage.ErrorCount;
                dataGridView_Results.Rows[index].Cells["Time"].Value = downloadResultMessage.DateTime.ToLocalTime().ToShortTimeString();

                GetDownloadMessages(downloadResultMessage.Messages);
            }
        }

        /// <summary>
        /// Function executed before downloading.
        /// </summary>
        /// <param name="downloadConfiguration"></param>
        private static void PreConfigureDownload(DownloadConfiguration downloadConfiguration)
        {
            StopModules stopModules = downloadConfiguration as StopModules;
            if (stopModules != null)
            {
                // Puts PLC in "Stop" mode
                stopModules.CurrentSelection = StopModulesSelections.StopAll;
            }
        }

        /// <summary>
        /// Function executed after downloading.
        /// </summary>
        /// <param name="downloadConfiguration"></param>
        private static void PostConfigureDownload(DownloadConfiguration downloadConfiguration)
        {
            StartModules startModules = downloadConfiguration as StartModules;
            if (startModules != null)
            {
                // Puts PLC in "Start" mode
                startModules.CurrentSelection = StartModulesSelections.StartModule;
            }
        }

        /// <summary>
        /// Update PC Interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_PcInterface_DropDown(object sender, EventArgs e)
        {
            comboBox_PcInterface.Items.Clear();

            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
                DeviceItem cpu = opns.Device_GetCPU(device);
                DownloadProvider downloadProvider = cpu.GetService<DownloadProvider>();
                ConnectionConfiguration connConfig = downloadProvider.Configuration;
                ConfigurationMode configurationMode = connConfig.Modes.Find("PN/IE");

                foreach (ConfigurationPcInterface pcInterface in configurationMode.PcInterfaces)
                {
                    comboBox_PcInterface.Items.Add(pcInterface.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        /// <summary>
        /// Update Target Interfaces.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_TargetInterface_DropDown(object sender, EventArgs e)
        {
            comboBox_TargetInterface.Items.Clear();

            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
                DeviceItem cpu = opns.Device_GetCPU(device);
                DownloadProvider downloadProvider = cpu.GetService<DownloadProvider>();
                ConnectionConfiguration connConfig = downloadProvider.Configuration;
                ConfigurationMode configurationMode = connConfig.Modes.Find("PN/IE");
                ConfigurationPcInterface pcInterface = configurationMode.PcInterfaces.Find(comboBox_PcInterface.Text, comboBox_PcInterface.SelectedIndex + 1);

                foreach (ConfigurationTargetInterface targetInterface in pcInterface.TargetInterfaces)
                {
                    comboBox_TargetInterface.Items.Add(targetInterface.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }
        #endregion

        /// <summary>
        /// Clear the datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ClearMessages_Click(object sender, EventArgs e)
        {
            dataGridView_Results.Rows.Clear();
        }

        private void button_SelectTargetFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = true;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBox_SelectTargetFolder.Text = folderBrowser.SelectedPath;
            }
        }

        private void button_OpenTargetFolder_Click(object sender, EventArgs e)
        {
            string path = textBox_SelectTargetFolder.Text;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                Process.Start(directoryInfo.FullName);
            }
        }

        #region Program Blocks
        private void button_DeleteBlock_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                PlcBlock block = (PlcBlock)treeView_ProgramBlocks.SelectedNode.Tag;
                block.Delete();
                UpdateSoftware();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportBlock_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                PlcBlock block = (PlcBlock)treeView_ProgramBlocks.SelectedNode.Tag;
                string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");
                FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{block.Name}.xml");
                block.Export(fileInfo, ExportOptions.WithDefaults);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportAllBlocks_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;
            string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            PlcBlockSystemGroup plcBlockSystemGroup = plcSoftware.BlockGroup;
            PlcBlockComposition plcBlocks = plcBlockSystemGroup.Blocks;

            foreach (PlcBlock block in plcBlocks)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{block.Name}.xml");
                    block.Export(fileInfo, ExportOptions.WithDefaults);
                    resultMessages += $"{block.Name} \t - Success! {Environment.NewLine}";
                }
                catch (Exception ex)
                {
                    resultMessages += $"{block.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                    error = true;
                }
            }
            if (!error)
            {
                MessageBox.Show($"All selected objects are successfully exported!{Environment.NewLine}{resultMessages}", "Export Results");
            }
            else
            {
                MessageBox.Show($"An error occured during the export of the selected objects!{Environment.NewLine}{resultMessages}", "Export Results");
            }
        }

        private void button_ImportBlocks_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            PlcBlockSystemGroup plcBlockSystemGroup = plcSoftware.BlockGroup;
            PlcBlockComposition plcBlocks = plcBlockSystemGroup.Blocks;

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = textBox_SelectTargetFolder.Text,
                Filter = ".xml Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    FileInfo path = new FileInfo(file);

                    try
                    {
                        plcBlocks.Import(path, ImportOptions.Override);
                        UpdateSoftware();
                        resultMessages += $"{path.Name} \t - Success! {Environment.NewLine}";
                    }
                    catch (Exception ex)
                    {
                        resultMessages += $"{path.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                        error = true;
                    }
                }
                if (!error)
                {
                    MessageBox.Show($"All selected files are successfully imported!{Environment.NewLine}{resultMessages}", "Import Results");
                }
                else
                {
                    MessageBox.Show($"An error occured during the import of the selected files!{Environment.NewLine}{resultMessages}", "Import Results");
                }
            }
        }
        #endregion

        #region Technology Objects
        private void button_DeleteTO_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                TechnologicalInstanceDB to = (TechnologicalInstanceDB)treeView_TechnologyObjects.SelectedNode.Tag;
                to.Delete();
                UpdateSoftware();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportTO_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                TechnologicalInstanceDB to = (TechnologicalInstanceDB)treeView_TechnologyObjects.SelectedNode.Tag;
                string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");
                FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{to.Name}.xml");
                to.Export(fileInfo, ExportOptions.WithDefaults);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportAllTOs_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;
            string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            TechnologicalInstanceDBGroup technologicalInstanceDBGroup = plcSoftware.TechnologicalObjectGroup;
            TechnologicalInstanceDBComposition technologicalInstanceDBs = technologicalInstanceDBGroup.TechnologicalObjects;

            foreach (TechnologicalInstanceDB to in technologicalInstanceDBs)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{to.Name}.xml");
                    to.Export(fileInfo, ExportOptions.WithDefaults);
                    resultMessages += $"{to.Name} \t - Success! {Environment.NewLine}";
                }
                catch (Exception ex)
                {
                    resultMessages += $"{to.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                    error = true;
                }
            }
            if (!error)
            {
                MessageBox.Show($"All selected objects are successfully exported!{Environment.NewLine}{resultMessages}", "Export Results");
            }
            else
            {
                MessageBox.Show($"An error occured during the export of the selected objects!{Environment.NewLine}{resultMessages}", "Export Results");
            }
        }

        private void button_ImportTOs_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            TechnologicalInstanceDBGroup technologicalInstanceDBGroup = plcSoftware.TechnologicalObjectGroup;
            TechnologicalInstanceDBComposition technologicalInstanceDBs = technologicalInstanceDBGroup.TechnologicalObjects;

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = textBox_SelectTargetFolder.Text,
                Filter = ".xml Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    FileInfo path = new FileInfo(file);

                    try
                    {
                        technologicalInstanceDBs.Import(path, ImportOptions.Override);
                        UpdateSoftware();
                        resultMessages += $"{path.Name} \t - Success! {Environment.NewLine}";
                    }
                    catch (Exception ex)
                    {
                        resultMessages += $"{path.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                        error = true;
                    }
                }
                if (!error)
                {
                    MessageBox.Show($"All selected files are successfully imported!{Environment.NewLine}{resultMessages}", "Import Results");
                }
                else
                {
                    MessageBox.Show($"An error occured during the import of the selected files!{Environment.NewLine}{resultMessages}", "Import Results");
                }
            }
        }
        #endregion

        #region Tag Tables
        private void button_DeleteTagTable_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                PlcTagTable tagTable = (PlcTagTable)treeView_TagTables.SelectedNode.Tag;
                tagTable.Delete();
                UpdateSoftware();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportTagTable_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                PlcTagTable tagTable = (PlcTagTable)treeView_TagTables.SelectedNode.Tag;
                string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");
                FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{tagTable.Name}.xml");
                tagTable.Export(fileInfo, ExportOptions.WithDefaults);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportAllTagTables_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;
            string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            PlcTagTableSystemGroup plcTagTableSystemGroup = plcSoftware.TagTableGroup;
            PlcTagTableComposition plcTagTables = plcTagTableSystemGroup.TagTables;

            foreach (PlcTagTable tagTable in plcTagTables)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{tagTable.Name}.xml");
                    tagTable.Export(fileInfo, ExportOptions.WithDefaults);
                    resultMessages += $"{tagTable.Name} \t - Success! {Environment.NewLine}";
                }            
                catch (Exception ex)
                {
                    resultMessages += $"{tagTable.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                    error = true;
                }
            }
            if (!error)
            {
                MessageBox.Show($"All selected objects are successfully exported!{Environment.NewLine}{resultMessages}", "Export Results");
            }
            else
            {
                MessageBox.Show($"An error occured during the export of the selected objects!{Environment.NewLine}{resultMessages}", "Export Results");
            }
        }

        private void button_ImportTagTables_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            PlcTagTableSystemGroup plcTagTableSystemGroup = plcSoftware.TagTableGroup;
            PlcTagTableComposition plcTagTables = plcTagTableSystemGroup.TagTables;

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = textBox_SelectTargetFolder.Text,
                Filter = ".xml Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    FileInfo path = new FileInfo(file);

                    try
                    {
                        plcTagTables.Import(path, ImportOptions.Override);
                        UpdateSoftware();
                        resultMessages += $"{path.Name} \t - Success! {Environment.NewLine}";
                    }
                    catch (Exception ex)
                    {
                        resultMessages += $"{path.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                        error = true;
                    }
                }
                if (!error)
                {
                    MessageBox.Show($"All selected files are successfully imported!{Environment.NewLine}{resultMessages}", "Import Results");
                }
                else
                {
                    MessageBox.Show($"An error occured during the import of the selected files!{Environment.NewLine}{resultMessages}", "Import Results");
                }
            }
        }
        #endregion

        #region UDT
        private void button_DeleteUDT_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                PlcStruct udt = (PlcStruct)treeView_PlcDataTypes.SelectedNode.Tag;
                udt.Delete();
                UpdateSoftware();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportUDT_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            try
            {
                PlcStruct udt = (PlcStruct)treeView_PlcDataTypes.SelectedNode.Tag;
                string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");
                FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{udt.Name}.xml");
                udt.Export(fileInfo, ExportOptions.WithDefaults);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void button_ExportAllUDTs_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || String.IsNullOrEmpty(textBox_SelectTargetFolder.Text) || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;
            string timeStamp = (DateTime.Now).ToString("yyyyMMdd_HHmmss");

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            PlcTypeSystemGroup plcTypeSystemGroup = plcSoftware.TypeGroup;
            PlcTypeComposition plcTypes = plcTypeSystemGroup.Types;

            foreach (PlcStruct udt in plcTypes)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo($"{textBox_SelectTargetFolder.Text}\\{timeStamp}_{udt.Name}.xml");
                    udt.Export(fileInfo, ExportOptions.WithDefaults);
                    resultMessages += $"{udt.Name} \t - Success! {Environment.NewLine}";
                }            
                catch (Exception ex)
                {
                    resultMessages += $"{udt.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                    error = true;
                }
            }
            if (!error)
            {
                MessageBox.Show($"All selected objects are successfully exported!{Environment.NewLine}{resultMessages}", "Export Results");
            }
            else
            {
                MessageBox.Show($"An error occured during the export of the selected objects!{Environment.NewLine}{resultMessages}", "Export Results");
            }
        }

        private void button_ImportUDTs_Click(object sender, EventArgs e)
        {
            if (opns.Project == null || opns.Device_GetDevice(comboBox_SelectPLC.Text) == null)
            {
                return;
            }

            string resultMessages = string.Empty;
            bool error = false;

            Device device = opns.Device_GetDevice(comboBox_SelectPLC.Text);
            PlcSoftware plcSoftware = opns.Plc_GetSoftware(device);
            PlcTypeSystemGroup plcTypeSystemGroup = plcSoftware.TypeGroup;
            PlcTypeComposition plcTypes = plcTypeSystemGroup.Types;

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = textBox_SelectTargetFolder.Text,
                Filter = ".xml Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    FileInfo path = new FileInfo(file);

                    try
                    {
                        plcTypes.Import(path, ImportOptions.Override);
                        UpdateSoftware();
                        resultMessages += $"{path.Name} \t - Success! {Environment.NewLine}";
                    }
                    catch (Exception ex)
                    {
                        resultMessages += $"{path.Name} \t - Error! {Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
                        error = true;
                    }
                }
                if (!error)
                {
                    MessageBox.Show($"All selected files are successfully imported!{Environment.NewLine}{resultMessages}", "Import Results");
                }
                else
                {
                    MessageBox.Show($"An error occured during the import of the selected files!{Environment.NewLine}{resultMessages}", "Import Results");
                }
            }
        }
        #endregion
    }
}