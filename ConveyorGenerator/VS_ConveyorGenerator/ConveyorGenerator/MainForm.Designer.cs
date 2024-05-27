namespace ConveyorGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_AddSafetyTelegram = new System.Windows.Forms.CheckBox();
            this.label_Conveyors = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_DrivePM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar_Conveyors = new System.Windows.Forms.TrackBar();
            this.comboBox_DriveCU = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_GenerateConveyors = new System.Windows.Forms.Button();
            this.button_StartTiaPortal = new System.Windows.Forms.Button();
            this.button_CreateProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_DisconnectTiaPortal = new System.Windows.Forms.Button();
            this.button_CloseProject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OpenProject = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TiaPortalProcessID = new System.Windows.Forms.TextBox();
            this.button_ConnectTiaPortal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Project = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ClearProject = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_SimulateBlocks = new System.Windows.Forms.CheckBox();
            this.comboBox_HMI = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_PLC = new System.Windows.Forms.ComboBox();
            this.button_GenerateHardware = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Offline = new System.Windows.Forms.Button();
            this.button_Online = new System.Windows.Forms.Button();
            this.button_Download = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Conveyors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_AddSafetyTelegram);
            this.groupBox2.Controls.Add(this.label_Conveyors);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox_DrivePM);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.trackBar_Conveyors);
            this.groupBox2.Controls.Add(this.comboBox_DriveCU);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_GenerateConveyors);
            this.groupBox2.Location = new System.Drawing.Point(10, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conveyors";
            // 
            // checkBox_AddSafetyTelegram
            // 
            this.checkBox_AddSafetyTelegram.AutoSize = true;
            this.checkBox_AddSafetyTelegram.Checked = true;
            this.checkBox_AddSafetyTelegram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AddSafetyTelegram.Location = new System.Drawing.Point(250, 37);
            this.checkBox_AddSafetyTelegram.Name = "checkBox_AddSafetyTelegram";
            this.checkBox_AddSafetyTelegram.Size = new System.Drawing.Size(103, 17);
            this.checkBox_AddSafetyTelegram.TabIndex = 11;
            this.checkBox_AddSafetyTelegram.Text = "Safety Telegram";
            this.checkBox_AddSafetyTelegram.UseVisualStyleBackColor = true;
            // 
            // label_Conveyors
            // 
            this.label_Conveyors.AutoSize = true;
            this.label_Conveyors.Location = new System.Drawing.Point(140, 145);
            this.label_Conveyors.Name = "label_Conveyors";
            this.label_Conveyors.Size = new System.Drawing.Size(13, 13);
            this.label_Conveyors.TabIndex = 10;
            this.label_Conveyors.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Power Module";
            // 
            // comboBox_DrivePM
            // 
            this.comboBox_DrivePM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DrivePM.FormattingEnabled = true;
            this.comboBox_DrivePM.Items.AddRange(new object[] {
            "6SL3517-1BE11-3AM0/-",
            "6SL3517-1BE21-0AM0/-",
            "6SL3224-0BE13-7UA0/-",
            "6SL3224-0BE21-5UA0/-"});
            this.comboBox_DrivePM.Location = new System.Drawing.Point(10, 85);
            this.comboBox_DrivePM.Name = "comboBox_DrivePM";
            this.comboBox_DrivePM.Size = new System.Drawing.Size(200, 21);
            this.comboBox_DrivePM.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Drive Control Unit";
            // 
            // trackBar_Conveyors
            // 
            this.trackBar_Conveyors.LargeChange = 10;
            this.trackBar_Conveyors.Location = new System.Drawing.Point(10, 160);
            this.trackBar_Conveyors.Maximum = 64;
            this.trackBar_Conveyors.Minimum = 1;
            this.trackBar_Conveyors.Name = "trackBar_Conveyors";
            this.trackBar_Conveyors.Size = new System.Drawing.Size(207, 45);
            this.trackBar_Conveyors.TabIndex = 6;
            this.trackBar_Conveyors.Value = 1;
            this.trackBar_Conveyors.Scroll += new System.EventHandler(this.trackBar_Conveyors_Scroll);
            // 
            // comboBox_DriveCU
            // 
            this.comboBox_DriveCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DriveCU.FormattingEnabled = true;
            this.comboBox_DriveCU.Items.AddRange(new object[] {
            "6SL3544-0xB02-1FA0/4.7.13",
            "6SL3246-0BA22-1FA0/4.7.13"});
            this.comboBox_DriveCU.Location = new System.Drawing.Point(10, 35);
            this.comboBox_DriveCU.Name = "comboBox_DriveCU";
            this.comboBox_DriveCU.Size = new System.Drawing.Size(200, 21);
            this.comboBox_DriveCU.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Conveyors";
            // 
            // button_GenerateConveyors
            // 
            this.button_GenerateConveyors.Location = new System.Drawing.Point(314, 187);
            this.button_GenerateConveyors.Name = "button_GenerateConveyors";
            this.button_GenerateConveyors.Size = new System.Drawing.Size(150, 23);
            this.button_GenerateConveyors.TabIndex = 1;
            this.button_GenerateConveyors.Text = "Generate Conveyors";
            this.button_GenerateConveyors.UseVisualStyleBackColor = true;
            this.button_GenerateConveyors.Click += new System.EventHandler(this.button_GenerateConveyors_Click);
            // 
            // button_StartTiaPortal
            // 
            this.button_StartTiaPortal.Location = new System.Drawing.Point(10, 35);
            this.button_StartTiaPortal.Name = "button_StartTiaPortal";
            this.button_StartTiaPortal.Size = new System.Drawing.Size(100, 25);
            this.button_StartTiaPortal.TabIndex = 0;
            this.button_StartTiaPortal.Text = "Start";
            this.button_StartTiaPortal.UseVisualStyleBackColor = true;
            this.button_StartTiaPortal.Click += new System.EventHandler(this.button_StartTiaPortal_Click);
            // 
            // button_CreateProject
            // 
            this.button_CreateProject.Location = new System.Drawing.Point(10, 85);
            this.button_CreateProject.Name = "button_CreateProject";
            this.button_CreateProject.Size = new System.Drawing.Size(100, 25);
            this.button_CreateProject.TabIndex = 2;
            this.button_CreateProject.Text = "Create";
            this.button_CreateProject.UseVisualStyleBackColor = true;
            this.button_CreateProject.Click += new System.EventHandler(this.button_CreateProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIA Portal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project";
            // 
            // button_DisconnectTiaPortal
            // 
            this.button_DisconnectTiaPortal.Location = new System.Drawing.Point(220, 35);
            this.button_DisconnectTiaPortal.Name = "button_DisconnectTiaPortal";
            this.button_DisconnectTiaPortal.Size = new System.Drawing.Size(100, 25);
            this.button_DisconnectTiaPortal.TabIndex = 4;
            this.button_DisconnectTiaPortal.Text = "Disconnect";
            this.button_DisconnectTiaPortal.UseVisualStyleBackColor = true;
            this.button_DisconnectTiaPortal.Click += new System.EventHandler(this.button_DisconnectTiaPortal_Click);
            // 
            // button_CloseProject
            // 
            this.button_CloseProject.Location = new System.Drawing.Point(220, 85);
            this.button_CloseProject.Name = "button_CloseProject";
            this.button_CloseProject.Size = new System.Drawing.Size(100, 25);
            this.button_CloseProject.TabIndex = 5;
            this.button_CloseProject.Text = "Close";
            this.button_CloseProject.UseVisualStyleBackColor = true;
            this.button_CloseProject.Click += new System.EventHandler(this.button_CloseProject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OpenProject);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_ProjectName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_TiaPortalProcessID);
            this.groupBox1.Controls.Add(this.button_ConnectTiaPortal);
            this.groupBox1.Controls.Add(this.button_CloseProject);
            this.groupBox1.Controls.Add(this.button_DisconnectTiaPortal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_CreateProject);
            this.groupBox1.Controls.Add(this.button_StartTiaPortal);
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Functions";
            // 
            // button_OpenProject
            // 
            this.button_OpenProject.Location = new System.Drawing.Point(115, 85);
            this.button_OpenProject.Name = "button_OpenProject";
            this.button_OpenProject.Size = new System.Drawing.Size(100, 25);
            this.button_OpenProject.TabIndex = 11;
            this.button_OpenProject.Text = "Open";
            this.button_OpenProject.UseVisualStyleBackColor = true;
            this.button_OpenProject.Click += new System.EventHandler(this.button_OpenProject_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Connected Project";
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Location = new System.Drawing.Point(328, 87);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.ReadOnly = true;
            this.textBox_ProjectName.Size = new System.Drawing.Size(136, 20);
            this.textBox_ProjectName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Connected TIA Portal";
            // 
            // textBox_TiaPortalProcessID
            // 
            this.textBox_TiaPortalProcessID.Location = new System.Drawing.Point(328, 37);
            this.textBox_TiaPortalProcessID.Name = "textBox_TiaPortalProcessID";
            this.textBox_TiaPortalProcessID.ReadOnly = true;
            this.textBox_TiaPortalProcessID.Size = new System.Drawing.Size(136, 20);
            this.textBox_TiaPortalProcessID.TabIndex = 7;
            // 
            // button_ConnectTiaPortal
            // 
            this.button_ConnectTiaPortal.Location = new System.Drawing.Point(115, 35);
            this.button_ConnectTiaPortal.Name = "button_ConnectTiaPortal";
            this.button_ConnectTiaPortal.Size = new System.Drawing.Size(100, 25);
            this.button_ConnectTiaPortal.TabIndex = 6;
            this.button_ConnectTiaPortal.Text = "Connect";
            this.button_ConnectTiaPortal.UseVisualStyleBackColor = true;
            this.button_ConnectTiaPortal.Click += new System.EventHandler(this.button_ConnectTiaPortal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Project});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Restart,
            this.menu_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(37, 20);
            this.menu_File.Text = "File";
            // 
            // menu_Restart
            // 
            this.menu_Restart.Name = "menu_Restart";
            this.menu_Restart.Size = new System.Drawing.Size(110, 22);
            this.menu_Restart.Text = "Restart";
            this.menu_Restart.Click += new System.EventHandler(this.menu_Restart_Click);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(110, 22);
            this.menu_Exit.Text = "Exit";
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // menu_Project
            // 
            this.menu_Project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ClearProject});
            this.menu_Project.Name = "menu_Project";
            this.menu_Project.Size = new System.Drawing.Size(56, 20);
            this.menu_Project.Text = "Project";
            // 
            // menu_ClearProject
            // 
            this.menu_ClearProject.Name = "menu_ClearProject";
            this.menu_ClearProject.Size = new System.Drawing.Size(141, 22);
            this.menu_ClearProject.Text = "Clear Project";
            this.menu_ClearProject.Click += new System.EventHandler(this.menu_ClearProject_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_SimulateBlocks);
            this.groupBox3.Controls.Add(this.comboBox_HMI);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox_PLC);
            this.groupBox3.Controls.Add(this.button_GenerateHardware);
            this.groupBox3.Location = new System.Drawing.Point(10, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 150);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ET200 CPU + HMI";
            // 
            // checkBox_SimulateBlocks
            // 
            this.checkBox_SimulateBlocks.AutoSize = true;
            this.checkBox_SimulateBlocks.Checked = true;
            this.checkBox_SimulateBlocks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SimulateBlocks.Location = new System.Drawing.Point(250, 37);
            this.checkBox_SimulateBlocks.Name = "checkBox_SimulateBlocks";
            this.checkBox_SimulateBlocks.Size = new System.Drawing.Size(100, 17);
            this.checkBox_SimulateBlocks.TabIndex = 12;
            this.checkBox_SimulateBlocks.Text = "Simulate blocks";
            this.checkBox_SimulateBlocks.UseVisualStyleBackColor = true;
            // 
            // comboBox_HMI
            // 
            this.comboBox_HMI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HMI.FormattingEnabled = true;
            this.comboBox_HMI.Items.AddRange(new object[] {
            "6AV2 128-3GB06-0AXx/19.0.0.0",
            "6AV2 128-3KB06-0AXx/19.0.0.0",
            "6AV2 128-3MB06-0AXx/19.0.0.0",
            "6AV2 128-3QB06-0AXx/19.0.0.0",
            "6AV2 128-3UB06-0AXx/19.0.0.0",
            "6AV2 128-3XB06-0AXx/19.0.0.0"});
            this.comboBox_HMI.Location = new System.Drawing.Point(10, 85);
            this.comboBox_HMI.Name = "comboBox_HMI";
            this.comboBox_HMI.Size = new System.Drawing.Size(200, 21);
            this.comboBox_HMI.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "HMI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CPU";
            // 
            // comboBox_PLC
            // 
            this.comboBox_PLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PLC.FormattingEnabled = true;
            this.comboBox_PLC.Items.AddRange(new object[] {
            "6ES7 514-2WN03-0AB0/V3.0",
            "6ES7 510-1DK03-0AB0/V3.0",
            "6ES7 512-1DM03-0AB0/V3.0",
            "6ES7 514-2DN03-0AB0/V3.0",
            "6ES7 510-1SK03-0AB0/V3.0",
            "6ES7 512-1SM03-0AB0/V3.0",
            "6ES7 514-2SN03-0AB0/V3.0",
            "6ES7 514-2VN03-0AB0/V3.0"});
            this.comboBox_PLC.Location = new System.Drawing.Point(10, 35);
            this.comboBox_PLC.Name = "comboBox_PLC";
            this.comboBox_PLC.Size = new System.Drawing.Size(200, 21);
            this.comboBox_PLC.TabIndex = 2;
            // 
            // button_GenerateHardware
            // 
            this.button_GenerateHardware.Location = new System.Drawing.Point(314, 121);
            this.button_GenerateHardware.Name = "button_GenerateHardware";
            this.button_GenerateHardware.Size = new System.Drawing.Size(150, 23);
            this.button_GenerateHardware.TabIndex = 1;
            this.button_GenerateHardware.Text = "Generate Hardware";
            this.button_GenerateHardware.UseVisualStyleBackColor = true;
            this.button_GenerateHardware.Click += new System.EventHandler(this.button_GenerateHardware_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Offline);
            this.groupBox4.Controls.Add(this.button_Online);
            this.groupBox4.Controls.Add(this.button_Download);
            this.groupBox4.Location = new System.Drawing.Point(12, 542);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 92);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PLC";
            // 
            // button_Offline
            // 
            this.button_Offline.Location = new System.Drawing.Point(112, 61);
            this.button_Offline.Name = "button_Offline";
            this.button_Offline.Size = new System.Drawing.Size(100, 25);
            this.button_Offline.TabIndex = 2;
            this.button_Offline.Text = "Offline";
            this.button_Offline.UseVisualStyleBackColor = true;
            this.button_Offline.Click += new System.EventHandler(this.button_Offline_Click);
            // 
            // button_Online
            // 
            this.button_Online.Location = new System.Drawing.Point(6, 61);
            this.button_Online.Name = "button_Online";
            this.button_Online.Size = new System.Drawing.Size(100, 25);
            this.button_Online.TabIndex = 1;
            this.button_Online.Text = "Online";
            this.button_Online.UseVisualStyleBackColor = true;
            this.button_Online.Click += new System.EventHandler(this.button_Online_Click);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(6, 19);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(100, 25);
            this.button_Download.TabIndex = 0;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 646);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conveyor Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Conveyors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_GenerateConveyors;
        private System.Windows.Forms.Button button_StartTiaPortal;
        private System.Windows.Forms.Button button_CreateProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_DisconnectTiaPortal;
        private System.Windows.Forms.Button button_CloseProject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ConnectTiaPortal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TiaPortalProcessID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_GenerateHardware;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_PLC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_Conveyors;
        private System.Windows.Forms.Button button_OpenProject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_DrivePM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_DriveCU;
        private System.Windows.Forms.Label label_Conveyors;
        private System.Windows.Forms.ToolStripMenuItem menu_Project;
        private System.Windows.Forms.ToolStripMenuItem menu_ClearProject;
        private System.Windows.Forms.ToolStripMenuItem menu_Restart;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Offline;
        private System.Windows.Forms.Button button_Online;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.ComboBox comboBox_HMI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_AddSafetyTelegram;
        private System.Windows.Forms.CheckBox checkBox_SimulateBlocks;
    }
}

