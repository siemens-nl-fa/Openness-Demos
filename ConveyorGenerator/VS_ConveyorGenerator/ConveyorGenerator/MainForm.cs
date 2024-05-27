using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using Siemens.Engineering;
using Siemens.Engineering.Compiler;
using Siemens.Engineering.Connection;
using Siemens.Engineering.Download;
using Siemens.Engineering.Download.Configurations;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Extensions;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.MC.Drives;
using Siemens.Engineering.MC.Drives.Enums;
using Siemens.Engineering.Online;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Blocks;
using Siemens.Engineering.SW.Tags;
using Siemens.Engineering.SW.TechnologicalObjects;
using Siemens.Engineering.SW.TechnologicalObjects.Motion;

namespace ConveyorGenerator
{
    public partial class MainForm : Form
    {
        #region Fields
        private TiaPortal _tiaPortal = null;
        private TiaPortalProcess _tiaPortalProcess = null;
        private Project _project = null;
        #endregion

        #region Properties
        public TiaPortal TiaPortal
        {
            get { return _tiaPortal; }
            set { _tiaPortal = value; }
        }

        public TiaPortalProcess TiaPortalProcess
        {
            get { return _tiaPortalProcess; }
            set { _tiaPortalProcess = value; }
        }

        public Project Project
        {
            get { return _project; }
            set { _project = value; }
        }

        public ProjectComposition Projects
        {
            get { return TiaPortal.Projects; }
        }

        public SubnetComposition Subnets
        {
            get { return Project.Subnets; }
        }

        public DeviceComposition Devices
        {
            get { return Project.Devices; }
        }
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_PLC.SelectedIndex = 0;
            comboBox_HMI.SelectedIndex = 0;
            comboBox_DriveCU.SelectedIndex = 0;
            comboBox_DrivePM.SelectedIndex = 0;
        }

        #region Button Events
        #region General Functions - TIA Portal
        /// <summary>
        /// Start a new instance of TIA Portal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_StartTiaPortal_Click(object sender, EventArgs e)
        {
            try
            {
                if (TiaPortal == null && TiaPortalProcess == null)
                {
                    TiaPortal = new TiaPortal(TiaPortalMode.WithUserInterface);
                    TiaPortalProcess = TiaPortal.GetCurrentProcess();
                    textBox_TiaPortalProcessID.Text = TiaPortalProcess.Id.ToString();
                }
                else
                {
                    MessageBox.Show("Already connected to a TIA Portal instance.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error starting TIA Portal.");
            }
        }

        /// <summary>
        /// Connects to a opened instance of TIA Portal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ConnectTiaPortal_Click(object sender, EventArgs e)
        {
            try
            {
                if (TiaPortal == null && TiaPortalProcess == null)
                {
                    ConnectDialog connectDialog = new ConnectDialog();
                    if (connectDialog.ShowDialog() == DialogResult.OK)
                    {
                        TiaPortalProcess = connectDialog.SelectedTiaPortalProcess;
                        TiaPortal = TiaPortalProcess.Attach();
                        textBox_TiaPortalProcessID.Text = TiaPortalProcess.Id.ToString();
                        if (Projects.Count > 0)
                        {
                            Project = Projects[0];
                            textBox_ProjectName.Text = Project.Name;
                            AddActiveLanguages();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Already connected to a TIA Portal instance.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting TIA Portal.");
            }
        }

        /// <summary>
        /// Disconnect with TIA Portal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DisconnectTiaPortal_Click(object sender, EventArgs e)
        {
            try
            {
                if (TiaPortal != null && TiaPortalProcess != null)
                {
                    TiaPortal.Dispose();
                    TiaPortal = null;
                    TiaPortalProcess = null;

                    textBox_TiaPortalProcessID.Text = "";
                    textBox_ProjectName.Text = "";
                }
                else
                {
                    MessageBox.Show("Not connect to a TIA Portal instance.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error disconnecting TIA Portal.");
            }
        }

        /// <summary>
        /// Check if TIA Portal is connected
        /// </summary>
        /// <returns></returns>
        private bool TiaPortalIsConnected()
        {
            if (TiaPortal == null)
            {
                MessageBox.Show("Not connect to a TIA Portal instance.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Download button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Download_Click(object sender, EventArgs e)
        {
            if (TiaPortalIsConnected())
            {
                if (ProjectIsOpened())
                {
                    Device plc = Devices.Find("PLC_1");
                    Download(plc);
                }
            }
        }

        /// <summary>
        /// Go online with plc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Online_Click(object sender, EventArgs e)
        {
            if (TiaPortalIsConnected())
            {
                if (ProjectIsOpened())
                {
                    Device plc = Devices.Find("PLC_1");
                    Online(plc);
                }
            }
        }

        /// <summary>
        /// Go offline with plc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Offline_Click(object sender, EventArgs e)
        {
            if (TiaPortalIsConnected())
            {
                if (ProjectIsOpened())
                {
                    Device plc = Devices.Find("PLC_1");
                    Offline(plc);
                }
            }
        }
        #endregion

        #region General Functions - Project
        /// <summary>
        /// Create a new project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CreateProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (TiaPortalIsConnected())
                {
                    if (Project == null)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog()
                        {
                            Filter = "TIA Portal projects (*ap18)|*.*"
                        };
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            DirectoryInfo targetDirectory = fileInfo.Directory;
                            Project = Projects.Create(targetDirectory, fileInfo.Name);
                            textBox_ProjectName.Text = Project.Name;
                            AddActiveLanguages();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A project is already opened");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error creating TIA Portal project.");
            }

        }

        /// <summary>
        /// Open a project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (TiaPortalIsConnected())
                {
                    if (Project == null)
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog()
                        {
                            Filter = "TIA Portal project (*ap18)|*.ap18*"
                        };
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo path = new FileInfo(openFileDialog.FileName);
                            Project = Projects.Open(path);
                            textBox_ProjectName.Text = Project.Name;
                            AddActiveLanguages();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening project.");
            }
        }

        /// <summary>
        /// Close the project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CloseProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (TiaPortalIsConnected())
                {
                    if (ProjectIsOpened())
                    {
                        Project.Close();
                        Project = null;
                        textBox_ProjectName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error closing TIA Portal project.");
            }
        }

        /// <summary>
        /// Check if Project is opened
        /// </summary>
        /// <returns></returns>
        private bool ProjectIsOpened()
        {
            if (Project == null)
            {
                MessageBox.Show("No project opened in TIA Portal.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddActiveLanguages()
        {
            // en-US
            // fr-FR
            // de-DE
            // it-IT
            // es-ES

            LanguageSettings languageSettings = Project.LanguageSettings;
            LanguageAssociation activeLanguages = languageSettings.ActiveLanguages;
            LanguageComposition languages = Project.LanguageSettings.Languages;

            if (activeLanguages.Find(CultureInfo.GetCultureInfo("en-US")) == null)
            {
                activeLanguages.Add(languages.Find(CultureInfo.GetCultureInfo("en-US")));
            }
            if (activeLanguages.Find(CultureInfo.GetCultureInfo("de-DE")) == null)
            {
                activeLanguages.Add(languages.Find(CultureInfo.GetCultureInfo("de-DE")));
            }
            if (activeLanguages.Find(CultureInfo.GetCultureInfo("it-IT")) == null)
            {
                activeLanguages.Add(languages.Find(CultureInfo.GetCultureInfo("it-IT")));
            }
            if (activeLanguages.Find(CultureInfo.GetCultureInfo("fr-FR")) == null)
            {
                activeLanguages.Add(languages.Find(CultureInfo.GetCultureInfo("fr-FR")));
            }
            if (activeLanguages.Find(CultureInfo.GetCultureInfo("es-ES")) == null)
            {
                activeLanguages.Add(languages.Find(CultureInfo.GetCultureInfo("es-ES")));
            }
        }
        #endregion

        #region Generate Buttons
        /// <summary>
        /// Generate controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_GenerateHardware_Click(object sender, EventArgs e)
        {
            if (TiaPortalIsConnected())
            {
                if (ProjectIsOpened())
                {
                    if (checkBox_SimulateBlocks.Checked == true)
                    {
                        Project.IsSimulationDuringBlockCompilationEnabled = true;
                    }
                    if (Devices.Find("PLC_1") == null && Devices.Find("HMI_1") == null)
                    {
                        // Show Network Editor
                        Project.ShowHwEditor(Siemens.Engineering.HW.View.Network);

                        // Create Subnet
                        Subnet subnet = CreateSubnet("PN/IE_1");
                        IoSystem ioSystem = null;

                        // Create PLC
                        string plcArticleNumber = comboBox_PLC.SelectedItem.ToString();
                        Device plc = CreateDevice(plcArticleNumber, "PLC_1");

                        DeviceItem cpu = plc.DeviceItems.First(p => p.Classification == DeviceItemClassifications.CPU);
                        if (cpu != null)
                        {
                            char[] chars = { 'S', 'i', 'e', 'm', 'e', 'n', 's', '1', '!' };
                            SecureString secureString = new SecureString();
                            foreach (char ch in chars)
                                secureString.AppendChar(ch);

                            PlcAccessLevelProvider accessLevelProvider = cpu.GetService<PlcAccessLevelProvider>();
                            accessLevelProvider.SetPassword(PlcProtectionAccessLevel.FullAccessIncludingFailsafe, secureString);
                            accessLevelProvider.PlcProtectionAccessLevel = PlcProtectionAccessLevel.FullAccessIncludingFailsafe;
                        
                            PlcMasterSecretConfigurator plcMasterSecretConfigurator = cpu.GetService<PlcMasterSecretConfigurator>();
                            plcMasterSecretConfigurator.Protect(secureString);

                            secureString.Dispose();
                        }

                        if (plc != null)
                        {
                            plc.ShowInEditor(Siemens.Engineering.HW.View.Network);

                            // Add device to subnet
                            AddDeviceToSubnet(subnet, plc);

                            // Create PROFINET IO-System
                            ioSystem = CreateIoSystem(plc);
                        }

                        // Create HMI
                        string hmiArticleNumber = comboBox_HMI.SelectedItem.ToString();
                        Device hmi = CreateDevice(hmiArticleNumber, "");
                        if (hmi != null)
                        {
                            hmi.ShowInEditor(Siemens.Engineering.HW.View.Network);

                            // Add device to subnet
                            AddDeviceToSubnet(subnet, hmi);

                            // Create PROFINET IO-System
                            ioSystem = CreateIoSystem(hmi);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Devices already exists in the project.");
                    }
                }
            }
        }

        /// <summary>
        /// Add drives to the project and software to the controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_GenerateConveyors_Click(object sender, EventArgs e)
        {
            if (TiaPortalIsConnected())
            {
                if (ProjectIsOpened())
                {
                    DeviceComposition devices = Project.Devices;

                    if (devices.Find("PLC_1") != null)
                    {
                        if (devices.Find("Drive_1") == null)
                        {
                            // Show Network Editor
                            Project.ShowHwEditor(Siemens.Engineering.HW.View.Network);

                            // Get devices objects
                            Device plc = devices.Find("PLC_1");

                            // Get article numbers
                            string cuArticleNumber = comboBox_DriveCU.Text;
                            string pmArticleNumber = comboBox_DrivePM.Text;

                            int conveyorQuantity = trackBar_Conveyors.Value;

                            // Loop until conveyorQuantity is reached
                            for (int i = 1; i <= conveyorQuantity; i++)
                            {
                                // Create drive
                                Device drive = CreateDrive(cuArticleNumber, pmArticleNumber, i);

                                // Add Safety Telegram
                                if (checkBox_AddSafetyTelegram.Checked)
                                {
                                    AddSafetyTelegram(drive);
                                }

                                // Add DI Module
                                AddIoModule(plc);

                                // Add drive to Subnet
                                Subnet subnet = Subnets.Find("PN/IE_1");
                                AddDeviceToSubnet(subnet, drive);

                                // Add drive to IO-System
                                IoSystem ioSystem = GetIoSystem(plc);
                                AddDeviceToIoSystem(ioSystem, drive);
                            }

                            // Add IO Tags
                            AddIoTags(plc, conveyorQuantity);

                            // Generate Software
                            GenerateSoftware(plc, conveyorQuantity);

                            // Show Network Editor
                            Project.ShowHwEditor(Siemens.Engineering.HW.View.Network);

                            MessageBox.Show($"Done generating hardware and software for {conveyorQuantity} conveyor(s).", "Generation Complete");

                        }
                        else
                        {
                            MessageBox.Show("One of more drives already exist in the project.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can not generate conveyor hardware and software.\nGenerate PLC_1 before generating drives and software.", "PLC_1 not found.");
                    }
                }
            }
        }

        /// <summary>
        /// Display the selected amount of conveyors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_Conveyors_Scroll(object sender, EventArgs e)
        {
            label_Conveyors.Text = trackBar_Conveyors.Value.ToString();
        }
        #endregion

        #region Menu
        /// <summary>
        /// Delete all the devices and subnets that are in the project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_ClearProject_Click(object sender, EventArgs e)
        {

            if (TiaPortalIsConnected())
            {
                if (ProjectIsOpened())
                {
                    if (MessageBox.Show("Are you sure you want to delete all devices and subnets?", "Delete devices and subnets", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeviceComposition devices = Project.Devices;
                        List<Device> devs = new List<Device>();
                        foreach (Device device in devices)
                        {
                            devs.Add(device);
                        }
                        foreach (Device device in devs)
                        {
                            device.Delete();
                        }

                        SubnetComposition subnets = Project.Subnets;
                        List<Subnet> subs = new List<Subnet>();
                        foreach (Subnet subnet in subnets)
                        {
                            subs.Add(subnet);
                        }
                        foreach (Subnet subnet in subs)
                        {
                            subnet.Delete();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Restart the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #endregion

        #region Methods
        #region Device
        /// <summary>
        /// Create a device with an article no.
        /// </summary>
        /// <param name="articleNumber"></param>
        /// <param name="deviceName"></param>
        /// <returns></returns>
        private Device CreateDevice(string articleNumber, string deviceName)
        {
            Device device = null;
            DeviceComposition devices = Project.Devices;

            try
            {
                if (devices.Find(deviceName) == null)
                {
                    device = devices.CreateWithItem($"OrderNumber:{articleNumber}", deviceName, deviceName);
                }
                else
                {
                    MessageBox.Show("Devices already exists in the project.");
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

            return device;
        }

        /// <summary>
        /// Adds IO Module to the ET200
        /// </summary>
        /// <param name="plc"></param>
        private void AddIoModule(Device plc)
        {
            try
            {
                foreach (DeviceItem item in plc.DeviceItems)
                {
                    if (item.GetAttribute("TypeName").ToString() == "Rack")
                    {
                        IList<PlugLocation> plugLocations = item.GetPlugLocations();
                        foreach (PlugLocation location in plugLocations)
                        {
                            if (item.CanPlugNew($"OrderNumber:6ES7 131-6BF00-0CA0/V2.0", "", location.PositionNumber))
                            {
                                item.PlugNew($"OrderNumber:6ES7 131-6BF00-0CA0/V2.0", "", location.PositionNumber);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }
        #endregion

        #region Drive
        /// <summary>
        /// Create a drive
        /// </summary>
        /// <param name="cuArticleNumber"></param>
        /// <param name="pmArticleNumber"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private Device CreateDrive(string cuArticleNumber, string pmArticleNumber, int i)
        {
            Device drive = null;

            try
            {
                // Create drive
                drive = CreateDevice(cuArticleNumber, $"Drive_{i}");

                // Add PM
                foreach (DeviceItem item in drive.DeviceItems)
                {
                    if (item.Classification == DeviceItemClassifications.HM)
                    {
                        IList<PlugLocation> plugLocations = item.GetPlugLocations();
                        item.PlugNew($"OrderNumber:{pmArticleNumber}", "", plugLocations[0].PositionNumber);
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

            return drive;
        }

        /// <summary>
        /// Add safety telegram
        /// </summary>
        /// <param name="drive"></param>
        private void AddSafetyTelegram(Device drive)
        {
            try
            {
                DeviceItem deviceItem = drive.Items[0].Items[0];
                DriveObject driveObject = deviceItem.GetService<DriveObjectContainer>().DriveObjects[0];

                TelegramComposition telegrams = driveObject.Telegrams;

                telegrams.InsertSafetyTelegram(30);
                Telegram telegram = telegrams.Find(TelegramType.SafetyTelegram);
                telegram.SetAttribute("Failsafe_FDestinationAddress", 2);
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }
        #endregion

        #region Networks
        /// <summary>
        /// Creates a subnet
        /// </summary>
        /// <param name="subnetName">Name for the subnet</param>
        /// <returns></returns>
        private Subnet CreateSubnet(string subnetName)
        {
            Subnet subnet = null;

            try
            {
                if (Subnets.Find(subnetName) == null)
                {
                    subnet = Subnets.Create("System:Subnet.Ethernet", subnetName);
                }
                else
                {
                    MessageBox.Show("This subnet already exsists in the project.");
                    subnet = Subnets.Find(subnetName);
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

            return subnet;
        }

        /// <summary>
        /// Add a device to a subnet
        /// </summary>
        /// <param name="subnet"></param>
        /// <param name="device"></param>
        private void AddDeviceToSubnet(Subnet subnet, Device device)
        {
            try
            {
                foreach (DeviceItem item in device.DeviceItems)
                {
                    if (item.Classification == DeviceItemClassifications.CPU)
                    {
                        foreach (DeviceItem itemItem in item.DeviceItems)
                        {
                            if (itemItem.Name.Contains("PROFINET interface"))
                            {
                                NetworkInterface networkInterface = itemItem.GetService<NetworkInterface>();
                                NodeComposition nodes = networkInterface.Nodes;
                                nodes.First().ConnectToSubnet(subnet);

                                return;
                            }
                        }
                    }
                    else if (item.Classification == DeviceItemClassifications.HM)
                    {
                        foreach (DeviceItem itemItem in item.DeviceItems)
                        {
                            if (itemItem.Name.Contains("PROFINET interface"))
                            {
                                NetworkInterface networkInterface = itemItem.GetService<NetworkInterface>();
                                NodeComposition nodes = networkInterface.Nodes;
                                nodes.First().ConnectToSubnet(subnet);

                                return;
                            }
                        }
                    }
                    else if (item.Name.Contains("IE_CP"))
                    {
                        foreach (DeviceItem itemItem in item.DeviceItems)
                        {
                            if (itemItem.Name.Contains("PROFINET Interface"))
                            {
                                NetworkInterface networkInterface = itemItem.GetService<NetworkInterface>();
                                NodeComposition nodes = networkInterface.Nodes;
                                nodes.First().ConnectToSubnet(subnet);

                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }

        /// <summary>
        /// Create an IO-System
        /// </summary>
        /// <param name="plc"></param>
        /// <returns></returns>
        private IoSystem CreateIoSystem(Device plc)
        {
            IoSystem ioSystem = null;

            try
            {
                foreach (DeviceItem deviceItem in plc.DeviceItems)
                {
                    if (deviceItem.Classification == DeviceItemClassifications.CPU)
                    {
                        foreach (DeviceItem deviceItemItem in deviceItem.DeviceItems)
                        {
                            if (deviceItemItem.Name.Contains("PROFINET interface"))
                            {
                                NetworkInterface networkInterface = deviceItemItem.GetService<NetworkInterface>();
                                IoControllerComposition ioControllers = networkInterface.IoControllers;
                                IoController ioController = ioControllers.First();
                                ioSystem = ioController.CreateIoSystem("PROFINET IO-System");

                                return ioSystem;
                            }
                        }
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

            return ioSystem;
        }

        /// <summary>
        /// Get the IO System of a device
        /// </summary>
        /// <param name="plc"></param>
        /// <returns></returns>
        private IoSystem GetIoSystem(Device plc)
        {
            IoSystem ioSystem = null;

            try
            {
                foreach (DeviceItem deviceItem in plc.DeviceItems)
                {
                    if (deviceItem.Classification == DeviceItemClassifications.CPU)
                    {
                        foreach (DeviceItem deviceItemItem in deviceItem.DeviceItems)
                        {
                            if (deviceItemItem.Name.Contains("PROFINET interface"))
                            {
                                NetworkInterface networkInterface = deviceItemItem.GetService<NetworkInterface>();
                                IoControllerComposition ioControllers = networkInterface.IoControllers;
                                IoController ioController = ioControllers.First();
                                ioSystem = ioController.IoSystem;

                                return ioSystem;
                            }
                        }
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }

            return ioSystem;
        }

        /// <summary>
        /// Add a device to an IO-System 
        /// </summary>
        /// <param name="ioSystem"></param>
        /// <param name="device"></param>
        private void AddDeviceToIoSystem(IoSystem ioSystem, Device device)
        {
            try
            {
                foreach (DeviceItem deviceItem in device.DeviceItems)
                {
                    if (deviceItem.Classification == DeviceItemClassifications.HM)
                    {
                        foreach (DeviceItem deviceItemItem in deviceItem.DeviceItems)
                        {
                            if (deviceItemItem.Name.Contains("PROFINET interface"))
                            {
                                NetworkInterface networkInterface = deviceItemItem.GetService<NetworkInterface>();
                                IoConnectorComposition ioConnectors = networkInterface.IoConnectors;
                                ioConnectors.First().ConnectToIoSystem(ioSystem);
                            }
                        }
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }
        #endregion

        #region Software
        /// <summary>
        /// Import the program blocks into TIA Portal project.
        /// </summary>
        /// <param name="plc"></param>
        /// <param name="conveyorQuanitity"></param>
        private void GenerateSoftware(Device plc, int conveyorQuantity)
        {
            foreach (DeviceItem item in plc.DeviceItems)
            {
                if (item.Classification == DeviceItemClassifications.CPU)
                {
                    SoftwareContainer container = item.GetService<SoftwareContainer>();
                    PlcSoftware software = container.Software as PlcSoftware;
                    PlcBlockSystemGroup programBlocks = software.BlockGroup;
                    PlcBlockComposition plcBlocks = programBlocks.Blocks;

                    DirectoryInfo directory = new DirectoryInfo($"{Path.GetDirectoryName(Application.ExecutablePath)}");

                    // Import SINA_SPEED
                    FileInfo pathBase = new FileInfo($"{directory}\\BaseCode\\SINA_SPEED.xml");
                    FileInfo pathImport = new FileInfo($"{directory}\\GeneratedCode\\SINA_SPEED.xml");
                    File.Copy(pathBase.FullName, pathImport.FullName, true);
                    plcBlocks.Import(pathImport, ImportOptions.Override);

                    // Import DriveLogic
                    pathBase = new FileInfo($"{directory}\\BaseCode\\DriveLogic.xml");
                    pathImport = new FileInfo($"{directory}\\GeneratedCode\\DriveLogic.xml");
                    File.Copy(pathBase.FullName, pathImport.FullName, true);
                    ModifyDriveLogicXMl(conveyorQuantity, pathImport);
                    plcBlocks.Import(pathImport, ImportOptions.Override);

                    // Import Logic
                    pathBase = new FileInfo($"{directory}\\BaseCode\\Logic.xml");
                    pathImport = new FileInfo($"{directory}\\GeneratedCode\\Logic.xml");
                    File.Copy(pathBase.FullName, pathImport.FullName, true);
                    plcBlocks.Import(pathImport, ImportOptions.Override);

                    // Import Control_DB
                    pathBase = new FileInfo($"{directory}\\BaseCode\\Control_DB.xml");
                    pathImport = new FileInfo($"{directory}\\GeneratedCode\\Control_DB.xml");
                    File.Copy(pathBase.FullName, pathImport.FullName, true);
                    plcBlocks.Import(pathImport, ImportOptions.Override);

                    // Import Logic_DB
                    pathBase = new FileInfo($"{directory}\\BaseCode\\Logic_DB.xml");
                    pathImport = new FileInfo($"{directory}\\GeneratedCode\\Logic_DB.xml");
                    File.Copy(pathBase.FullName, pathImport.FullName, true);
                    plcBlocks.Import(pathImport, ImportOptions.Override);

                    // Import DriveLogic_DB
                    pathBase = new FileInfo($"{directory}\\BaseCode\\DriveLogic_DB.xml");
                    pathImport = new FileInfo($"{directory}\\GeneratedCode\\DriveLogic_DB.xml");
                    File.Copy(pathBase.FullName, pathImport.FullName, true);
                    plcBlocks.Import(pathImport, ImportOptions.Override);

                    // Import Main
                    pathBase = new FileInfo($"{directory}\\BaseCode\\Main.xml");
                    pathImport = new FileInfo($"{directory}\\GeneratedCode\\Main.xml");
                    File.Copy(pathBase.FullName, pathImport.FullName, true);
                    plcBlocks.Import(pathImport, ImportOptions.Override);

                    // Compile program blocks
                    Compile(software);
                    /*
                    Compile(plcBlocks.Find("SINA_SPEED"));
                    Compile(plcBlocks.Find("DriveLogic"));
                    Compile(plcBlocks.Find("Logic"));
                    Compile(plcBlocks.Find("Control_DB"));
                    Compile(plcBlocks.Find("Logic_DB"));
                    Compile(plcBlocks.Find("DriveLogic_DB"));
                    Compile(plcBlocks.Find("Main"));
                    */
                }
            }
        }

        /// <summary>
        /// Add objects to the XML file. 
        /// </summary>
        /// <param name="conveyorQuantity"></param>
        /// <param name="path"></param>
        private void ModifyDriveLogicXMl(int conveyorQuantity, FileInfo path)
        {
            // Open
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path.FullName);
            XmlElement xmlElement = xmlDocument.DocumentElement;

            // Add Namespaces
            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
            namespaceManager.AddNamespace("ns1", "http://www.siemens.com/automation/Openness/SW/Interface/v5");
            namespaceManager.AddNamespace("ns2", "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v5");

            // Get SINA_SPEED_Instance node.
            XmlNode sectionsNode = xmlElement.SelectSingleNode("SW.Blocks.FB/AttributeList/Interface/ns1:Sections", namespaceManager);
            XmlNode staticVariablesNode = sectionsNode.SelectSingleNode("ns1:Section[@Name='Static']", namespaceManager);
            XmlNode sinaSpeedNode = staticVariablesNode.FirstChild;

            // Get parts & wires nodes.
            XmlNode flgNetNode = xmlElement.SelectSingleNode("SW.Blocks.FB/ObjectList/SW.Blocks.CompileUnit/AttributeList/NetworkSource/ns2:FlgNet", namespaceManager);
            XmlNode partsNode = flgNetNode.SelectSingleNode("ns2:Parts", namespaceManager);
            XmlNode wiresNode = flgNetNode.SelectSingleNode("ns2:Wires", namespaceManager);

            // Put all part nodes in a list
            List<XmlNode> partNodes = new List<XmlNode>();
            foreach (XmlNode node in partsNode.ChildNodes)
            {
                partNodes.Add(node);
            }

            // Put all wire nodes in a list
            List<XmlNode> wireNodes = new List<XmlNode>();
            foreach (XmlNode node in wiresNode.ChildNodes)
            {
                wireNodes.Add(node);
            }

            // Generate nodes
            for (int i = 1; i < conveyorQuantity; i++)
            {
                // Generate SINA_SPEED_Instance line
                if (staticVariablesNode.ChildNodes.Count < conveyorQuantity)
                {
                    XmlNode copiedNode = sinaSpeedNode.CloneNode(true);
                    string instanceString = copiedNode.Attributes[0].Value;
                    instanceString = instanceString.Replace("1", $"{i + 1}");
                    copiedNode.Attributes[0].Value = instanceString;
                    XmlNode addedNode = staticVariablesNode.AppendChild(copiedNode);
                }

                // Generate part nodes
                foreach (XmlNode node in partNodes)
                {
                    XmlNode copiedNode = node.CloneNode(true);
                    XmlNode uidNode = copiedNode.Attributes.GetNamedItem("UId");
                    uidNode.Value += i;

                    if (node.Name == "Access")
                    {
                        if (node.Attributes.GetNamedItem("Scope").Value == "GlobalConstant")
                        {
                            XmlNode telegramNode = copiedNode.FirstChild;
                            string telegramString = telegramNode.Attributes[0].Value;
                            telegramString = telegramString.Replace("Drive_1", $"Drive_{i + 1}");
                            telegramNode.Attributes[0].Value = telegramString;
                        }
                    }
                    if (node.Name == "Call")
                    {
                        XmlNode instanceNode = copiedNode.FirstChild.FirstChild;
                        XmlNode uidNode1 = instanceNode.Attributes.GetNamedItem("UId");
                        uidNode1.Value += i;

                        XmlNode componentNode = instanceNode.FirstChild;
                        string componentString = componentNode.Attributes[0].Value;
                        componentString = componentString.Replace("1", $"{i + 1}");
                        componentNode.Attributes[0].Value = componentString;

                        XmlNode enNode = xmlDocument.CreateElement("NameCon", "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v5");
                        XmlAttribute inUId = xmlDocument.CreateAttribute("UId");
                        inUId.Value = uidNode.Value;
                        enNode.Attributes.SetNamedItem(inUId);
                        XmlAttribute enName = xmlDocument.CreateAttribute("Name");
                        enName.Value = "en";
                        enNode.Attributes.SetNamedItem(enName);
                        wiresNode.ChildNodes[0].AppendChild(enNode);
                    }
                    XmlNode addedNode = partsNode.AppendChild(copiedNode);
                }

                // Generate wire nodes
                foreach (XmlNode node in wireNodes)
                {
                    if (node.FirstChild.Name != "Powerrail")
                    {
                        XmlNode copiedNode = node.CloneNode(true);
                        XmlNode uidNode = copiedNode.Attributes.GetNamedItem("UId");
                        uidNode.Value += i;
                        foreach (XmlNode childNode in copiedNode.ChildNodes)
                        {
                            XmlNode uidNode1 = childNode.Attributes.GetNamedItem("UId");
                            uidNode1.Value += i;
                        }

                        XmlNode addedNode = wiresNode.AppendChild(copiedNode);
                    }
                }
            }

            // Save XML File
            xmlDocument.Save(path.FullName);
        }

        /// <summary>
        /// Compiles a program blocks
        /// </summary>
        private void Compile(PlcBlock plcBlock)
        {
            try
            {
                ICompilable compilable = plcBlock.GetService<ICompilable>();
                compilable.Compile();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }

        /// <summary>
        /// Compiles all software
        /// </summary>
        /// <param name="software"></param>
        private void Compile(PlcSoftware software)
        {
            try
            {
                ICompilable compilable = software.GetService<ICompilable>();
                compilable.Compile();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }

        /// <summary>
        /// Add IO Tags to the PLC Tag Table
        /// </summary>
        /// <param name="plc"></param>
        /// <param name="conveyorQuanitity"></param>
        private void AddIoTags(Device plc, int conveyorQuantity)
        {
            try
            {
                foreach (DeviceItem item in plc.DeviceItems)
                {
                    if (item.Classification == DeviceItemClassifications.CPU)
                    {
                        SoftwareContainer container = item.GetService<SoftwareContainer>();
                        PlcSoftware software = container.Software as PlcSoftware;

                        // Add Lightbeam tags
                        PlcTagTable plcTagTable_IO = software.TagTableGroup.TagTables.Create("Conveyor_IO");
                        plcTagTable_IO.ShowInEditor();
                        int startByte_Lightbeam = 0;

                        for (int i = 1; i <= conveyorQuantity; i++)
                        {
                            plcTagTable_IO.Tags.Create($"Conveyor{i}_Lightbeam1", "Bool", $"%I{startByte_Lightbeam}.0");
                            plcTagTable_IO.Tags.Create($"Conveyor{i}_Lightbeam2", "Bool", $"%I{startByte_Lightbeam}.1");
                            startByte_Lightbeam += 7;
                        }

                        // Add Telegram tags
                        PlcTagTable plcTagTable_Tele = software.TagTableGroup.TagTables.Create("Drive_Telegram");
                        plcTagTable_Tele.ShowInEditor();
                        int startByte_Telegram = 256;

                        for (int i = 1; i <= conveyorQuantity; i++)
                        {
                            plcTagTable_Tele.Tags.Create($"Drive{i}_In", "PD_TEL1_IN", $" %I{startByte_Telegram}.0");
                            plcTagTable_Tele.Tags.Create($"Drive{i}_Out", "PD_TEL1_OUT", $"%Q{startByte_Telegram}.0");
                            startByte_Telegram += 4;
                        }


                        // Add DataType PD_TEL1_IN & PD_TEL1_OUT by inserting a TO and removing it.
                        TechnologicalInstanceDBGroup technIDBGroup = software.TechnologicalObjectGroup;
                        TechnologicalInstanceDB technologyObject = technIDBGroup.TechnologicalObjects.Create("TO_SpeedAxis_1", "TO_SpeedAxis", new Version("7.0"));
                        AxisHardwareConnectionProvider connectionProvider = technologyObject.GetService<AxisHardwareConnectionProvider>();

                        Device drive = Devices.Find("Drive_1");
                        DeviceItem deviceItem = drive.Items[0].Items[0];
                        DriveObject driveObject = deviceItem.GetService<DriveObjectContainer>().DriveObjects[0];
                        TelegramComposition telegrams = driveObject.Telegrams;
                        connectionProvider.ActorInterface.Connect(2048, 2048, Siemens.Engineering.SW.TechnologicalObjects.Motion.ConnectOption.Default);
                        technologyObject.Delete();
                    }
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }
        #endregion

        #region Online & Download
        /// <summary>
        /// Download device
        /// </summary>
        /// <param name="plc"></param>
        void Download(Device plc)
        {
            try
            {
                if (plc != null)
                {
                    foreach (DeviceItem item in plc.DeviceItems)
                    {
                        if (item.Classification == DeviceItemClassifications.CPU)
                        {
                            DownloadProvider downloadProvider = item.GetService<DownloadProvider>();
                            if (downloadProvider != null)
                            {
                                ConnectionConfiguration configuration = downloadProvider.Configuration;

                                ConfigurationMode configurationMode = configuration.Modes.Find("PN/IE");
                                ConfigurationPcInterface pcInterface = configurationMode.PcInterfaces.Find("PLCSIM", 1);
                                ConfigurationSubnet subnet = pcInterface.Subnets.Find("PN/IE_1");
                                IConfiguration targetConfiguration = subnet.Addresses.Find("192.168.0.1");

                                DownloadConfigurationDelegate pre = PreConfigureDownload;
                                DownloadConfigurationDelegate post = PostConfigureDownload;

                                DownloadResult result = downloadProvider.Download(targetConfiguration, PreConfigureDownload, PostConfigureDownload, DownloadOptions.Software);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can not download to PLC.\nPLC_1 not found.\nGenerate hardware.", "PLC_1 not found.");
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }

        /// <summary>
        /// Function before download
        /// </summary>
        /// <param name="downloadConfiguration"></param>
        private static void PreConfigureDownload(DownloadConfiguration downloadConfiguration)
        {

        }

        /// <summary>
        /// Function after download
        /// </summary>
        /// <param name="downloadConfiguration"></param>
        private static void PostConfigureDownload(DownloadConfiguration downloadConfiguration)
        {
            MessageBox.Show("Download succesful.", "Downloading Complete");
        }

        /// <summary>
        /// Function to go online
        /// </summary>
        /// <param name="plc"></param>
        void Online(Device plc)
        {
            try
            {
                if (plc != null)
                {
                    foreach (DeviceItem item in plc.DeviceItems)
                    {
                        if (item.Classification == DeviceItemClassifications.CPU)
                        {
                            OnlineProvider onlineProvider = item.GetService<OnlineProvider>();
                            if (onlineProvider != null)
                            {
                                onlineProvider.GoOnline();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can not go online with PLC.\nPLC_1 not found.\nGenerate hardware.", "PLC_1 not found.");
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }

        /// <summary>
        /// Function to go offlien
        /// </summary>
        /// <param name="plc"></param>
        void Offline(Device plc)
        {
            try
            {
                if (plc != null)
                {
                    foreach (DeviceItem item in plc.DeviceItems)
                    {
                        if (item.Classification == DeviceItemClassifications.CPU)
                        {
                            OnlineProvider onlineProvider = item.GetService<OnlineProvider>();
                            if (onlineProvider != null)
                            {
                                onlineProvider.GoOffline();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can not go offline with PLC.\nPLC_1 not found.\nGenerate hardware.", "PLC_1 not found.");
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message);
            }
        }
        #endregion

        #endregion

    }
}