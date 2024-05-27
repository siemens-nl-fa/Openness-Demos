namespace OpennessXML
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_RestartApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_StartPLCSIMAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel_TIAConnectie = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_ProjectConnectie = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_SideBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_CloseTIA = new System.Windows.Forms.Button();
            this.button_DisconnectTIA = new System.Windows.Forms.Button();
            this.button_CloseProject = new System.Windows.Forms.Button();
            this.button_SaveProject = new System.Windows.Forms.Button();
            this.button_OpenProject = new System.Windows.Forms.Button();
            this.button_ConnectTIA = new System.Windows.Forms.Button();
            this.button_StartTIA = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Body = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SelectTargetFolder = new System.Windows.Forms.TextBox();
            this.button_SelectTargetFolder = new System.Windows.Forms.Button();
            this.button_OpenTargetFolder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_SelectedTechnologyObject = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_SelectedTagTable = new System.Windows.Forms.TextBox();
            this.textBox_SelectedProgramBlock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_SelectedUDT = new System.Windows.Forms.TextBox();
            this.button_ImportBlocks = new System.Windows.Forms.Button();
            this.button_ImportTagTables = new System.Windows.Forms.Button();
            this.button_ImportTOs = new System.Windows.Forms.Button();
            this.button_ImportUDTs = new System.Windows.Forms.Button();
            this.button_ExportBlock = new System.Windows.Forms.Button();
            this.button_ExportAllBlocks = new System.Windows.Forms.Button();
            this.button_DeleteBlock = new System.Windows.Forms.Button();
            this.button_ExportTagTable = new System.Windows.Forms.Button();
            this.button_ExportAllTagTables = new System.Windows.Forms.Button();
            this.button_DeleteTagTable = new System.Windows.Forms.Button();
            this.button_ExportTO = new System.Windows.Forms.Button();
            this.button_ExportAllTOs = new System.Windows.Forms.Button();
            this.button_DeleteTO = new System.Windows.Forms.Button();
            this.button_ExportUDT = new System.Windows.Forms.Button();
            this.button_ExportAllUDTs = new System.Windows.Forms.Button();
            this.button_DeleteUDT = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_SelectedProgramBlock1 = new System.Windows.Forms.TextBox();
            this.button_CompileBlock = new System.Windows.Forms.Button();
            this.button_CompilePLC = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            this.State = new System.Windows.Forms.DataGridViewImageColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Errors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ClearResults = new System.Windows.Forms.Button();
            this.comboBox_PcInterface = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_TargetInterface = new System.Windows.Forms.ComboBox();
            this.button_DownloadPLC = new System.Windows.Forms.Button();
            this.textBox_SelectedPLC = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.treeView_PlcDataTypes = new System.Windows.Forms.TreeView();
            this.treeView_TechnologyObjects = new System.Windows.Forms.TreeView();
            this.treeView_TagTables = new System.Windows.Forms.TreeView();
            this.comboBox_SelectPLC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RefreshPLC = new System.Windows.Forms.Button();
            this.treeView_ProgramBlocks = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_SideBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Body.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menu_StartPLCSIMAdvanced});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_RestartApplication,
            this.menu_ExitApplication});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_RestartApplication
            // 
            this.menu_RestartApplication.Name = "menu_RestartApplication";
            this.menu_RestartApplication.Size = new System.Drawing.Size(110, 22);
            this.menu_RestartApplication.Text = "Restart";
            this.menu_RestartApplication.Click += new System.EventHandler(this.menu_Restart_Click);
            // 
            // menu_ExitApplication
            // 
            this.menu_ExitApplication.Name = "menu_ExitApplication";
            this.menu_ExitApplication.Size = new System.Drawing.Size(110, 22);
            this.menu_ExitApplication.Text = "Exit";
            this.menu_ExitApplication.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // menu_StartPLCSIMAdvanced
            // 
            this.menu_StartPLCSIMAdvanced.Name = "menu_StartPLCSIMAdvanced";
            this.menu_StartPLCSIMAdvanced.Size = new System.Drawing.Size(143, 20);
            this.menu_StartPLCSIMAdvanced.Text = "Start PLCSIM Advanced";
            this.menu_StartPLCSIMAdvanced.Click += new System.EventHandler(this.menu_StartPLCSIMAdvanced_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_TIAConnectie,
            this.statusLabel_ProjectConnectie});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel_TIAConnectie
            // 
            this.statusLabel_TIAConnectie.Name = "statusLabel_TIAConnectie";
            this.statusLabel_TIAConnectie.Size = new System.Drawing.Size(141, 17);
            this.statusLabel_TIAConnectie.Text = "TIA Portal - Disconnected";
            // 
            // statusLabel_ProjectConnectie
            // 
            this.statusLabel_ProjectConnectie.Name = "statusLabel_ProjectConnectie";
            this.statusLabel_ProjectConnectie.Size = new System.Drawing.Size(127, 17);
            this.statusLabel_ProjectConnectie.Text = "Project - Disconnected";
            // 
            // panel_SideBar
            // 
            this.panel_SideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_SideBar.Controls.Add(this.tableLayoutPanel1);
            this.panel_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SideBar.Location = new System.Drawing.Point(0, 24);
            this.panel_SideBar.Name = "panel_SideBar";
            this.panel_SideBar.Size = new System.Drawing.Size(100, 543);
            this.panel_SideBar.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_CloseTIA, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_DisconnectTIA, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_CloseProject, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_SaveProject, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_OpenProject, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_ConnectTIA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_StartTIA, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(98, 541);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button_CloseTIA
            // 
            this.button_CloseTIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CloseTIA.Location = new System.Drawing.Point(3, 183);
            this.button_CloseTIA.Name = "button_CloseTIA";
            this.button_CloseTIA.Size = new System.Drawing.Size(92, 24);
            this.button_CloseTIA.TabIndex = 6;
            this.button_CloseTIA.Text = "Close TIA";
            this.button_CloseTIA.UseVisualStyleBackColor = true;
            this.button_CloseTIA.Click += new System.EventHandler(this.button_CloseTIA_Click);
            // 
            // button_DisconnectTIA
            // 
            this.button_DisconnectTIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DisconnectTIA.Location = new System.Drawing.Point(3, 153);
            this.button_DisconnectTIA.Name = "button_DisconnectTIA";
            this.button_DisconnectTIA.Size = new System.Drawing.Size(92, 24);
            this.button_DisconnectTIA.TabIndex = 5;
            this.button_DisconnectTIA.Text = "Disconnect TIA";
            this.button_DisconnectTIA.UseVisualStyleBackColor = true;
            this.button_DisconnectTIA.Click += new System.EventHandler(this.button_DisconnectTIA_Click);
            // 
            // button_CloseProject
            // 
            this.button_CloseProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CloseProject.Location = new System.Drawing.Point(3, 123);
            this.button_CloseProject.Name = "button_CloseProject";
            this.button_CloseProject.Size = new System.Drawing.Size(92, 24);
            this.button_CloseProject.TabIndex = 4;
            this.button_CloseProject.Text = "Close Project";
            this.button_CloseProject.UseVisualStyleBackColor = true;
            this.button_CloseProject.Click += new System.EventHandler(this.button_CloseProject_Click);
            // 
            // button_SaveProject
            // 
            this.button_SaveProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveProject.Location = new System.Drawing.Point(3, 93);
            this.button_SaveProject.Name = "button_SaveProject";
            this.button_SaveProject.Size = new System.Drawing.Size(92, 24);
            this.button_SaveProject.TabIndex = 3;
            this.button_SaveProject.Text = "Save Project";
            this.button_SaveProject.UseVisualStyleBackColor = true;
            this.button_SaveProject.Click += new System.EventHandler(this.button_SaveProject_Click);
            // 
            // button_OpenProject
            // 
            this.button_OpenProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OpenProject.Location = new System.Drawing.Point(3, 63);
            this.button_OpenProject.Name = "button_OpenProject";
            this.button_OpenProject.Size = new System.Drawing.Size(92, 24);
            this.button_OpenProject.TabIndex = 2;
            this.button_OpenProject.Text = "Open Project";
            this.button_OpenProject.UseVisualStyleBackColor = true;
            this.button_OpenProject.Click += new System.EventHandler(this.button_OpenProject_Click);
            // 
            // button_ConnectTIA
            // 
            this.button_ConnectTIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ConnectTIA.Location = new System.Drawing.Point(3, 33);
            this.button_ConnectTIA.Name = "button_ConnectTIA";
            this.button_ConnectTIA.Size = new System.Drawing.Size(92, 24);
            this.button_ConnectTIA.TabIndex = 1;
            this.button_ConnectTIA.Text = "Connect TIA";
            this.button_ConnectTIA.UseVisualStyleBackColor = true;
            this.button_ConnectTIA.Click += new System.EventHandler(this.button_ConnectTIA_Click);
            // 
            // button_StartTIA
            // 
            this.button_StartTIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_StartTIA.Location = new System.Drawing.Point(3, 3);
            this.button_StartTIA.Name = "button_StartTIA";
            this.button_StartTIA.Size = new System.Drawing.Size(92, 24);
            this.button_StartTIA.TabIndex = 0;
            this.button_StartTIA.Text = "Start TIA ";
            this.button_StartTIA.UseVisualStyleBackColor = true;
            this.button_StartTIA.Click += new System.EventHandler(this.button_StartTIA_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(100, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 543);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel_Body
            // 
            this.panel_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Body.Controls.Add(this.tabControl1);
            this.panel_Body.Controls.Add(this.splitter2);
            this.panel_Body.Controls.Add(this.panel1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(105, 24);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(913, 543);
            this.panel_Body.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(282, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 541);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(621, 515);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "XML Import/Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_SelectTargetFolder, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_SelectTargetFolder, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_OpenTargetFolder, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.textBox_SelectedTechnologyObject, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.textBox_SelectedTagTable, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox_SelectedProgramBlock, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.textBox_SelectedUDT, 2, 12);
            this.tableLayoutPanel2.Controls.Add(this.button_ImportBlocks, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.button_ImportTagTables, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.button_ImportTOs, 1, 15);
            this.tableLayoutPanel2.Controls.Add(this.button_ImportUDTs, 3, 15);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportBlock, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportAllBlocks, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.button_DeleteBlock, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportTagTable, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportAllTagTables, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.button_DeleteTagTable, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportTO, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportAllTOs, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.button_DeleteTO, 1, 14);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportUDT, 3, 12);
            this.tableLayoutPanel2.Controls.Add(this.button_ExportAllUDTs, 3, 13);
            this.tableLayoutPanel2.Controls.Add(this.button_DeleteUDT, 3, 14);
            this.tableLayoutPanel2.Controls.Add(this.label17, 2, 11);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 17;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(621, 515);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 30);
            this.label7.TabIndex = 34;
            this.label7.Text = "Select Export Path";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox_SelectTargetFolder
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox_SelectTargetFolder, 2);
            this.textBox_SelectTargetFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SelectTargetFolder.Location = new System.Drawing.Point(3, 33);
            this.textBox_SelectTargetFolder.Name = "textBox_SelectTargetFolder";
            this.textBox_SelectTargetFolder.Size = new System.Drawing.Size(294, 20);
            this.textBox_SelectTargetFolder.TabIndex = 31;
            // 
            // button_SelectTargetFolder
            // 
            this.button_SelectTargetFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SelectTargetFolder.Location = new System.Drawing.Point(303, 33);
            this.button_SelectTargetFolder.Name = "button_SelectTargetFolder";
            this.button_SelectTargetFolder.Size = new System.Drawing.Size(144, 24);
            this.button_SelectTargetFolder.TabIndex = 32;
            this.button_SelectTargetFolder.Text = "Select Target Folder";
            this.button_SelectTargetFolder.UseVisualStyleBackColor = true;
            this.button_SelectTargetFolder.Click += new System.EventHandler(this.button_SelectTargetFolder_Click);
            // 
            // button_OpenTargetFolder
            // 
            this.button_OpenTargetFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OpenTargetFolder.Location = new System.Drawing.Point(453, 33);
            this.button_OpenTargetFolder.Name = "button_OpenTargetFolder";
            this.button_OpenTargetFolder.Size = new System.Drawing.Size(144, 24);
            this.button_OpenTargetFolder.TabIndex = 33;
            this.button_OpenTargetFolder.Text = "Open Folder";
            this.button_OpenTargetFolder.UseVisualStyleBackColor = true;
            this.button_OpenTargetFolder.Click += new System.EventHandler(this.button_OpenTargetFolder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 30;
            this.label6.Text = "Program Blocks";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(303, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 30);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tag Tables";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 30);
            this.label9.TabIndex = 38;
            this.label9.Text = "Technology Objects";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox_SelectedTechnologyObject
            // 
            this.textBox_SelectedTechnologyObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SelectedTechnologyObject.Location = new System.Drawing.Point(3, 363);
            this.textBox_SelectedTechnologyObject.Name = "textBox_SelectedTechnologyObject";
            this.textBox_SelectedTechnologyObject.ReadOnly = true;
            this.textBox_SelectedTechnologyObject.Size = new System.Drawing.Size(144, 20);
            this.textBox_SelectedTechnologyObject.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 30);
            this.label13.TabIndex = 45;
            this.label13.Text = "Selected Technology Object";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox_SelectedTagTable
            // 
            this.textBox_SelectedTagTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SelectedTagTable.Location = new System.Drawing.Point(303, 153);
            this.textBox_SelectedTagTable.Name = "textBox_SelectedTagTable";
            this.textBox_SelectedTagTable.ReadOnly = true;
            this.textBox_SelectedTagTable.Size = new System.Drawing.Size(144, 20);
            this.textBox_SelectedTagTable.TabIndex = 26;
            // 
            // textBox_SelectedProgramBlock
            // 
            this.textBox_SelectedProgramBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SelectedProgramBlock.Location = new System.Drawing.Point(3, 153);
            this.textBox_SelectedProgramBlock.Name = "textBox_SelectedProgramBlock";
            this.textBox_SelectedProgramBlock.ReadOnly = true;
            this.textBox_SelectedProgramBlock.Size = new System.Drawing.Size(144, 20);
            this.textBox_SelectedProgramBlock.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 30);
            this.label14.TabIndex = 46;
            this.label14.Text = "Selected Program Block";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(303, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 30);
            this.label15.TabIndex = 47;
            this.label15.Text = "Selected Tag Table";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(303, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 30);
            this.label16.TabIndex = 48;
            this.label16.Text = "PLC Data Types";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox_SelectedUDT
            // 
            this.textBox_SelectedUDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SelectedUDT.Location = new System.Drawing.Point(303, 363);
            this.textBox_SelectedUDT.Name = "textBox_SelectedUDT";
            this.textBox_SelectedUDT.ReadOnly = true;
            this.textBox_SelectedUDT.Size = new System.Drawing.Size(144, 20);
            this.textBox_SelectedUDT.TabIndex = 49;
            // 
            // button_ImportBlocks
            // 
            this.button_ImportBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ImportBlocks.Location = new System.Drawing.Point(153, 243);
            this.button_ImportBlocks.Name = "button_ImportBlocks";
            this.button_ImportBlocks.Size = new System.Drawing.Size(144, 24);
            this.button_ImportBlocks.TabIndex = 36;
            this.button_ImportBlocks.Text = "Import Program Blocks";
            this.button_ImportBlocks.UseVisualStyleBackColor = true;
            this.button_ImportBlocks.Click += new System.EventHandler(this.button_ImportBlocks_Click);
            // 
            // button_ImportTagTables
            // 
            this.button_ImportTagTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ImportTagTables.Location = new System.Drawing.Point(453, 243);
            this.button_ImportTagTables.Name = "button_ImportTagTables";
            this.button_ImportTagTables.Size = new System.Drawing.Size(144, 24);
            this.button_ImportTagTables.TabIndex = 37;
            this.button_ImportTagTables.Text = "Import Tag Tables";
            this.button_ImportTagTables.UseVisualStyleBackColor = true;
            this.button_ImportTagTables.Click += new System.EventHandler(this.button_ImportTagTables_Click);
            // 
            // button_ImportTOs
            // 
            this.button_ImportTOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ImportTOs.Location = new System.Drawing.Point(153, 453);
            this.button_ImportTOs.Name = "button_ImportTOs";
            this.button_ImportTOs.Size = new System.Drawing.Size(144, 24);
            this.button_ImportTOs.TabIndex = 44;
            this.button_ImportTOs.Text = "Import TO\'s";
            this.button_ImportTOs.UseVisualStyleBackColor = true;
            this.button_ImportTOs.Click += new System.EventHandler(this.button_ImportTOs_Click);
            // 
            // button_ImportUDTs
            // 
            this.button_ImportUDTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ImportUDTs.Location = new System.Drawing.Point(453, 453);
            this.button_ImportUDTs.Name = "button_ImportUDTs";
            this.button_ImportUDTs.Size = new System.Drawing.Size(144, 24);
            this.button_ImportUDTs.TabIndex = 53;
            this.button_ImportUDTs.Text = "Import UDT\'s";
            this.button_ImportUDTs.UseVisualStyleBackColor = true;
            this.button_ImportUDTs.Click += new System.EventHandler(this.button_ImportUDTs_Click);
            // 
            // button_ExportBlock
            // 
            this.button_ExportBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportBlock.Location = new System.Drawing.Point(153, 153);
            this.button_ExportBlock.Name = "button_ExportBlock";
            this.button_ExportBlock.Size = new System.Drawing.Size(144, 24);
            this.button_ExportBlock.TabIndex = 23;
            this.button_ExportBlock.Text = "Export Block";
            this.button_ExportBlock.UseVisualStyleBackColor = true;
            this.button_ExportBlock.Click += new System.EventHandler(this.button_ExportBlock_Click);
            // 
            // button_ExportAllBlocks
            // 
            this.button_ExportAllBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportAllBlocks.Location = new System.Drawing.Point(153, 183);
            this.button_ExportAllBlocks.Name = "button_ExportAllBlocks";
            this.button_ExportAllBlocks.Size = new System.Drawing.Size(144, 24);
            this.button_ExportAllBlocks.TabIndex = 24;
            this.button_ExportAllBlocks.Text = "Export All Blocks";
            this.button_ExportAllBlocks.UseVisualStyleBackColor = true;
            this.button_ExportAllBlocks.Click += new System.EventHandler(this.button_ExportAllBlocks_Click);
            // 
            // button_DeleteBlock
            // 
            this.button_DeleteBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteBlock.Location = new System.Drawing.Point(153, 213);
            this.button_DeleteBlock.Name = "button_DeleteBlock";
            this.button_DeleteBlock.Size = new System.Drawing.Size(144, 24);
            this.button_DeleteBlock.TabIndex = 0;
            this.button_DeleteBlock.Text = "Delete Block";
            this.button_DeleteBlock.UseVisualStyleBackColor = true;
            this.button_DeleteBlock.Click += new System.EventHandler(this.button_DeleteBlock_Click);
            // 
            // button_ExportTagTable
            // 
            this.button_ExportTagTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportTagTable.Location = new System.Drawing.Point(453, 153);
            this.button_ExportTagTable.Name = "button_ExportTagTable";
            this.button_ExportTagTable.Size = new System.Drawing.Size(144, 24);
            this.button_ExportTagTable.TabIndex = 28;
            this.button_ExportTagTable.Text = "Export Tag Table";
            this.button_ExportTagTable.UseVisualStyleBackColor = true;
            this.button_ExportTagTable.Click += new System.EventHandler(this.button_ExportTagTable_Click);
            // 
            // button_ExportAllTagTables
            // 
            this.button_ExportAllTagTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportAllTagTables.Location = new System.Drawing.Point(453, 183);
            this.button_ExportAllTagTables.Name = "button_ExportAllTagTables";
            this.button_ExportAllTagTables.Size = new System.Drawing.Size(144, 24);
            this.button_ExportAllTagTables.TabIndex = 29;
            this.button_ExportAllTagTables.Text = "Export All Tag Tables";
            this.button_ExportAllTagTables.UseVisualStyleBackColor = true;
            this.button_ExportAllTagTables.Click += new System.EventHandler(this.button_ExportAllTagTables_Click);
            // 
            // button_DeleteTagTable
            // 
            this.button_DeleteTagTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteTagTable.Location = new System.Drawing.Point(453, 213);
            this.button_DeleteTagTable.Name = "button_DeleteTagTable";
            this.button_DeleteTagTable.Size = new System.Drawing.Size(144, 24);
            this.button_DeleteTagTable.TabIndex = 25;
            this.button_DeleteTagTable.Text = "Delete Tag Table";
            this.button_DeleteTagTable.UseVisualStyleBackColor = true;
            this.button_DeleteTagTable.Click += new System.EventHandler(this.button_DeleteTagTable_Click);
            // 
            // button_ExportTO
            // 
            this.button_ExportTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportTO.Location = new System.Drawing.Point(153, 363);
            this.button_ExportTO.Name = "button_ExportTO";
            this.button_ExportTO.Size = new System.Drawing.Size(144, 24);
            this.button_ExportTO.TabIndex = 42;
            this.button_ExportTO.Text = "Export TO";
            this.button_ExportTO.UseVisualStyleBackColor = true;
            this.button_ExportTO.Click += new System.EventHandler(this.button_ExportTO_Click);
            // 
            // button_ExportAllTOs
            // 
            this.button_ExportAllTOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportAllTOs.Location = new System.Drawing.Point(153, 393);
            this.button_ExportAllTOs.Name = "button_ExportAllTOs";
            this.button_ExportAllTOs.Size = new System.Drawing.Size(144, 24);
            this.button_ExportAllTOs.TabIndex = 43;
            this.button_ExportAllTOs.Text = "Export All TO\'s";
            this.button_ExportAllTOs.UseVisualStyleBackColor = true;
            this.button_ExportAllTOs.Click += new System.EventHandler(this.button_ExportAllTOs_Click);
            // 
            // button_DeleteTO
            // 
            this.button_DeleteTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteTO.Location = new System.Drawing.Point(153, 423);
            this.button_DeleteTO.Name = "button_DeleteTO";
            this.button_DeleteTO.Size = new System.Drawing.Size(144, 24);
            this.button_DeleteTO.TabIndex = 41;
            this.button_DeleteTO.Text = "Delete TO";
            this.button_DeleteTO.UseVisualStyleBackColor = true;
            this.button_DeleteTO.Click += new System.EventHandler(this.button_DeleteTO_Click);
            // 
            // button_ExportUDT
            // 
            this.button_ExportUDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportUDT.Location = new System.Drawing.Point(453, 363);
            this.button_ExportUDT.Name = "button_ExportUDT";
            this.button_ExportUDT.Size = new System.Drawing.Size(144, 24);
            this.button_ExportUDT.TabIndex = 51;
            this.button_ExportUDT.Text = "Export UDT";
            this.button_ExportUDT.UseVisualStyleBackColor = true;
            this.button_ExportUDT.Click += new System.EventHandler(this.button_ExportUDT_Click);
            // 
            // button_ExportAllUDTs
            // 
            this.button_ExportAllUDTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ExportAllUDTs.Location = new System.Drawing.Point(453, 393);
            this.button_ExportAllUDTs.Name = "button_ExportAllUDTs";
            this.button_ExportAllUDTs.Size = new System.Drawing.Size(144, 24);
            this.button_ExportAllUDTs.TabIndex = 52;
            this.button_ExportAllUDTs.Text = "Export All UDT\'s";
            this.button_ExportAllUDTs.UseVisualStyleBackColor = true;
            this.button_ExportAllUDTs.Click += new System.EventHandler(this.button_ExportAllUDTs_Click);
            // 
            // button_DeleteUDT
            // 
            this.button_DeleteUDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteUDT.Location = new System.Drawing.Point(453, 423);
            this.button_DeleteUDT.Name = "button_DeleteUDT";
            this.button_DeleteUDT.Size = new System.Drawing.Size(144, 24);
            this.button_DeleteUDT.TabIndex = 50;
            this.button_DeleteUDT.Text = "Delete UDT";
            this.button_DeleteUDT.UseVisualStyleBackColor = true;
            this.button_DeleteUDT.Click += new System.EventHandler(this.button_DeleteUDT_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(303, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 30);
            this.label17.TabIndex = 54;
            this.label17.Text = "Selected PLC Data Type";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compile & Download";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_SelectedProgramBlock1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_CompileBlock, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_CompilePLC, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_Results, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.button_ClearResults, 3, 7);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_PcInterface, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label12, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_TargetInterface, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.button_DownloadPLC, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.textBox_SelectedPLC, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 17;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(615, 509);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox_SelectedProgramBlock1
            // 
            this.textBox_SelectedProgramBlock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SelectedProgramBlock1.Location = new System.Drawing.Point(3, 33);
            this.textBox_SelectedProgramBlock1.Name = "textBox_SelectedProgramBlock1";
            this.textBox_SelectedProgramBlock1.ReadOnly = true;
            this.textBox_SelectedProgramBlock1.Size = new System.Drawing.Size(144, 20);
            this.textBox_SelectedProgramBlock1.TabIndex = 21;
            // 
            // button_CompileBlock
            // 
            this.button_CompileBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CompileBlock.Location = new System.Drawing.Point(153, 33);
            this.button_CompileBlock.Name = "button_CompileBlock";
            this.button_CompileBlock.Size = new System.Drawing.Size(144, 24);
            this.button_CompileBlock.TabIndex = 22;
            this.button_CompileBlock.Text = "Compile Block";
            this.button_CompileBlock.UseVisualStyleBackColor = true;
            this.button_CompileBlock.Click += new System.EventHandler(this.button_CompileBlock_Click);
            // 
            // button_CompilePLC
            // 
            this.button_CompilePLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CompilePLC.Location = new System.Drawing.Point(153, 63);
            this.button_CompilePLC.Name = "button_CompilePLC";
            this.button_CompilePLC.Size = new System.Drawing.Size(144, 24);
            this.button_CompilePLC.TabIndex = 23;
            this.button_CompilePLC.Text = "Compile PLC";
            this.button_CompilePLC.UseVisualStyleBackColor = true;
            this.button_CompilePLC.Click += new System.EventHandler(this.button_CompilePLC_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label10, 2);
            this.label10.Location = new System.Drawing.Point(303, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Compile selected program block";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Compile PLC";
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.AllowUserToAddRows = false;
            this.dataGridView_Results.AllowUserToDeleteRows = false;
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.State,
            this.Path,
            this.Description,
            this.Errors,
            this.Warnings,
            this.Time});
            this.tableLayoutPanel3.SetColumnSpan(this.dataGridView_Results, 6);
            this.dataGridView_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Results.Location = new System.Drawing.Point(3, 243);
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.ReadOnly = true;
            this.dataGridView_Results.RowHeadersVisible = false;
            this.tableLayoutPanel3.SetRowSpan(this.dataGridView_Results, 8);
            this.dataGridView_Results.Size = new System.Drawing.Size(609, 234);
            this.dataGridView_Results.TabIndex = 30;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.State.HeaderText = "!";
            this.State.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.State.Width = 35;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 54;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Errors
            // 
            this.Errors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Errors.HeaderText = "Errors";
            this.Errors.Name = "Errors";
            this.Errors.ReadOnly = true;
            this.Errors.Width = 59;
            // 
            // Warnings
            // 
            this.Warnings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Warnings.HeaderText = "Warnings";
            this.Warnings.Name = "Warnings";
            this.Warnings.ReadOnly = true;
            this.Warnings.Width = 77;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 55;
            // 
            // button_ClearResults
            // 
            this.button_ClearResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ClearResults.Location = new System.Drawing.Point(453, 213);
            this.button_ClearResults.Name = "button_ClearResults";
            this.button_ClearResults.Size = new System.Drawing.Size(144, 24);
            this.button_ClearResults.TabIndex = 29;
            this.button_ClearResults.Text = "Clear Messages";
            this.button_ClearResults.UseVisualStyleBackColor = true;
            this.button_ClearResults.Click += new System.EventHandler(this.button_ClearMessages_Click);
            // 
            // comboBox_PcInterface
            // 
            this.comboBox_PcInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_PcInterface.FormattingEnabled = true;
            this.comboBox_PcInterface.Location = new System.Drawing.Point(153, 123);
            this.comboBox_PcInterface.Name = "comboBox_PcInterface";
            this.comboBox_PcInterface.Size = new System.Drawing.Size(144, 21);
            this.comboBox_PcInterface.TabIndex = 24;
            this.comboBox_PcInterface.DropDown += new System.EventHandler(this.comboBox_PcInterface_DropDown);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(453, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Download to PLC";
            // 
            // comboBox_TargetInterface
            // 
            this.comboBox_TargetInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_TargetInterface.FormattingEnabled = true;
            this.comboBox_TargetInterface.Location = new System.Drawing.Point(153, 153);
            this.comboBox_TargetInterface.Name = "comboBox_TargetInterface";
            this.comboBox_TargetInterface.Size = new System.Drawing.Size(144, 21);
            this.comboBox_TargetInterface.TabIndex = 31;
            this.comboBox_TargetInterface.DropDown += new System.EventHandler(this.comboBox_TargetInterface_DropDown);
            // 
            // button_DownloadPLC
            // 
            this.button_DownloadPLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DownloadPLC.Location = new System.Drawing.Point(303, 153);
            this.button_DownloadPLC.Name = "button_DownloadPLC";
            this.button_DownloadPLC.Size = new System.Drawing.Size(144, 24);
            this.button_DownloadPLC.TabIndex = 25;
            this.button_DownloadPLC.Text = "Download";
            this.button_DownloadPLC.UseVisualStyleBackColor = true;
            this.button_DownloadPLC.Click += new System.EventHandler(this.button_DownloadPLC_Click);
            // 
            // textBox_SelectedPLC
            // 
            this.textBox_SelectedPLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SelectedPLC.Location = new System.Drawing.Point(3, 123);
            this.textBox_SelectedPLC.Name = "textBox_SelectedPLC";
            this.textBox_SelectedPLC.ReadOnly = true;
            this.textBox_SelectedPLC.Size = new System.Drawing.Size(144, 20);
            this.textBox_SelectedPLC.TabIndex = 32;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(279, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 541);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 541);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.treeView_PlcDataTypes, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.treeView_TechnologyObjects, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.treeView_TagTables, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_SelectPLC, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_RefreshPLC, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.treeView_ProgramBlocks, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(279, 541);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(142, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "PLC Data Types";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // treeView_PlcDataTypes
            // 
            this.treeView_PlcDataTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_PlcDataTypes.Location = new System.Drawing.Point(142, 333);
            this.treeView_PlcDataTypes.Name = "treeView_PlcDataTypes";
            this.treeView_PlcDataTypes.Size = new System.Drawing.Size(134, 205);
            this.treeView_PlcDataTypes.TabIndex = 21;
            this.treeView_PlcDataTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_PlcDataTypes_AfterSelect);
            // 
            // treeView_TechnologyObjects
            // 
            this.treeView_TechnologyObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TechnologyObjects.Location = new System.Drawing.Point(3, 333);
            this.treeView_TechnologyObjects.Name = "treeView_TechnologyObjects";
            this.treeView_TechnologyObjects.Size = new System.Drawing.Size(133, 205);
            this.treeView_TechnologyObjects.TabIndex = 20;
            this.treeView_TechnologyObjects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_TechnologyObjects_AfterSelect);
            // 
            // treeView_TagTables
            // 
            this.treeView_TagTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TagTables.Location = new System.Drawing.Point(142, 93);
            this.treeView_TagTables.Name = "treeView_TagTables";
            this.treeView_TagTables.Size = new System.Drawing.Size(134, 204);
            this.treeView_TagTables.TabIndex = 17;
            this.treeView_TagTables.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_TagTables_AfterSelect);
            // 
            // comboBox_SelectPLC
            // 
            this.comboBox_SelectPLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_SelectPLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectPLC.FormattingEnabled = true;
            this.comboBox_SelectPLC.Location = new System.Drawing.Point(3, 33);
            this.comboBox_SelectPLC.Name = "comboBox_SelectPLC";
            this.comboBox_SelectPLC.Size = new System.Drawing.Size(133, 21);
            this.comboBox_SelectPLC.TabIndex = 0;
            this.comboBox_SelectPLC.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectPLC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Program Blocks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select PLC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button_RefreshPLC
            // 
            this.button_RefreshPLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RefreshPLC.Location = new System.Drawing.Point(142, 33);
            this.button_RefreshPLC.Name = "button_RefreshPLC";
            this.button_RefreshPLC.Size = new System.Drawing.Size(134, 24);
            this.button_RefreshPLC.TabIndex = 13;
            this.button_RefreshPLC.Text = "Refresh";
            this.button_RefreshPLC.UseVisualStyleBackColor = true;
            this.button_RefreshPLC.Click += new System.EventHandler(this.button_RefreshPLC_Click);
            // 
            // treeView_ProgramBlocks
            // 
            this.treeView_ProgramBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_ProgramBlocks.Location = new System.Drawing.Point(3, 93);
            this.treeView_ProgramBlocks.Name = "treeView_ProgramBlocks";
            this.treeView_ProgramBlocks.Size = new System.Drawing.Size(133, 204);
            this.treeView_ProgramBlocks.TabIndex = 14;
            this.treeView_ProgramBlocks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_ProgramBlocks_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(142, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tag Tables";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Technology Objects";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 589);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel_SideBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1034, 628);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_SideBar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_Body.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel_SideBar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem menu_ExitApplication;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_CloseTIA;
        private System.Windows.Forms.Button button_DisconnectTIA;
        private System.Windows.Forms.Button button_CloseProject;
        private System.Windows.Forms.Button button_SaveProject;
        private System.Windows.Forms.Button button_OpenProject;
        private System.Windows.Forms.Button button_ConnectTIA;
        private System.Windows.Forms.Button button_StartTIA;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_TIAConnectie;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_ProjectConnectie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menu_RestartApplication;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBox_SelectPLC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RefreshPLC;
        private System.Windows.Forms.TreeView treeView_ProgramBlocks;
        private System.Windows.Forms.ToolStripMenuItem menu_StartPLCSIMAdvanced;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_DeleteBlock;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox_SelectedProgramBlock1;
        private System.Windows.Forms.Button button_CompileBlock;
        private System.Windows.Forms.Button button_CompilePLC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_Results;
        private System.Windows.Forms.DataGridViewImageColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Errors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warnings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button button_ClearResults;
        private System.Windows.Forms.ComboBox comboBox_PcInterface;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_TargetInterface;
        private System.Windows.Forms.Button button_DownloadPLC;
        private System.Windows.Forms.TextBox textBox_SelectedPLC;
        private System.Windows.Forms.TreeView treeView_PlcDataTypes;
        private System.Windows.Forms.TreeView treeView_TechnologyObjects;
        private System.Windows.Forms.TreeView treeView_TagTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SelectTargetFolder;
        private System.Windows.Forms.Button button_SelectTargetFolder;
        private System.Windows.Forms.Button button_OpenTargetFolder;
        private System.Windows.Forms.Button button_ExportAllBlocks;
        private System.Windows.Forms.Button button_ExportBlock;
        private System.Windows.Forms.TextBox textBox_SelectedProgramBlock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ExportAllTagTables;
        private System.Windows.Forms.Button button_ExportTagTable;
        private System.Windows.Forms.TextBox textBox_SelectedTagTable;
        private System.Windows.Forms.Button button_DeleteTagTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_ImportBlocks;
        private System.Windows.Forms.Button button_ImportTagTables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_SelectedTechnologyObject;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_ExportTO;
        private System.Windows.Forms.Button button_DeleteTO;
        private System.Windows.Forms.Button button_ExportAllTOs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_SelectedUDT;
        private System.Windows.Forms.Button button_DeleteUDT;
        private System.Windows.Forms.Button button_ExportUDT;
        private System.Windows.Forms.Button button_ExportAllUDTs;
        private System.Windows.Forms.Button button_ImportTOs;
        private System.Windows.Forms.Button button_ImportUDTs;
          private System.Windows.Forms.Label label17;
     }
}

