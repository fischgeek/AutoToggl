namespace AutoToggl
{
    partial class Settings
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
            if (disposing && (components != null)) {
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
            this.cbxStartWithWindows = new System.Windows.Forms.CheckBox();
            this.cbxShowOnStart = new System.Windows.Forms.CheckBox();
            this.cbxCloseToTray = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTogglAPIKey = new System.Windows.Forms.TextBox();
            this.txtTogglWorkspaceId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTogglUsername = new System.Windows.Forms.TextBox();
            this.txtTogglPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lnkTestAuth = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxShowFancyTimer = new System.Windows.Forms.CheckBox();
            this.txtLogHistory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picRefreshButton = new System.Windows.Forms.PictureBox();
            this.lnkRegisterNew = new System.Windows.Forms.LinkLabel();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlTogglProjects = new System.Windows.Forms.ComboBox();
            this.togglProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lnkDeleteTrackedProject = new System.Windows.Forms.LinkLabel();
            this.btnDownProjectListItem = new System.Windows.Forms.Button();
            this.btnUpProjectListItem = new System.Windows.Forms.Button();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.trackedProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lnkSaveEdits = new System.Windows.Forms.LinkLabel();
            this.lnkCancelEdit = new System.Windows.Forms.LinkLabel();
            this.lnkEditKeywords = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeywordList = new System.Windows.Forms.TextBox();
            this.lblTogglProjects = new System.Windows.Forms.Label();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMessages = new System.Windows.Forms.Label();
            this.projectKeywordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxStopOnNeutral = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNeutralWindows = new System.Windows.Forms.TextBox();
            this.cbxDormammu = new System.Windows.Forms.CheckBox();
            this.cbxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togglProjectsBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackedProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectKeywordsBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxStartWithWindows
            // 
            this.cbxStartWithWindows.AutoSize = true;
            this.cbxStartWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStartWithWindows.ForeColor = System.Drawing.Color.White;
            this.cbxStartWithWindows.Location = new System.Drawing.Point(13, 34);
            this.cbxStartWithWindows.Name = "cbxStartWithWindows";
            this.cbxStartWithWindows.Size = new System.Drawing.Size(154, 22);
            this.cbxStartWithWindows.TabIndex = 5;
            this.cbxStartWithWindows.Text = "Start with Windows";
            this.cbxStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // cbxShowOnStart
            // 
            this.cbxShowOnStart.AutoSize = true;
            this.cbxShowOnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShowOnStart.ForeColor = System.Drawing.Color.White;
            this.cbxShowOnStart.Location = new System.Drawing.Point(13, 61);
            this.cbxShowOnStart.Name = "cbxShowOnStart";
            this.cbxShowOnStart.Size = new System.Drawing.Size(119, 22);
            this.cbxShowOnStart.TabIndex = 6;
            this.cbxShowOnStart.Text = "Show on start";
            this.cbxShowOnStart.UseVisualStyleBackColor = true;
            // 
            // cbxCloseToTray
            // 
            this.cbxCloseToTray.AutoSize = true;
            this.cbxCloseToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCloseToTray.ForeColor = System.Drawing.Color.White;
            this.cbxCloseToTray.Location = new System.Drawing.Point(13, 89);
            this.cbxCloseToTray.Name = "cbxCloseToTray";
            this.cbxCloseToTray.Size = new System.Drawing.Size(116, 22);
            this.cbxCloseToTray.TabIndex = 7;
            this.cbxCloseToTray.Text = "Close to Tray";
            this.cbxCloseToTray.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "API Key";
            // 
            // txtTogglAPIKey
            // 
            this.txtTogglAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTogglAPIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTogglAPIKey.Location = new System.Drawing.Point(13, 177);
            this.txtTogglAPIKey.Name = "txtTogglAPIKey";
            this.txtTogglAPIKey.Size = new System.Drawing.Size(284, 24);
            this.txtTogglAPIKey.TabIndex = 10;
            this.txtTogglAPIKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTogglAPIKey_KeyPress);
            // 
            // txtTogglWorkspaceId
            // 
            this.txtTogglWorkspaceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTogglWorkspaceId.Location = new System.Drawing.Point(7, 55);
            this.txtTogglWorkspaceId.Name = "txtTogglWorkspaceId";
            this.txtTogglWorkspaceId.Size = new System.Drawing.Size(103, 24);
            this.txtTogglWorkspaceId.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Workspace ID";
            // 
            // txtCheckInterval
            // 
            this.txtCheckInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInterval.Location = new System.Drawing.Point(210, 195);
            this.txtCheckInterval.Name = "txtCheckInterval";
            this.txtCheckInterval.Size = new System.Drawing.Size(87, 24);
            this.txtCheckInterval.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Window Check Interval (ms)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // txtTogglUsername
            // 
            this.txtTogglUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTogglUsername.BackColor = System.Drawing.Color.DarkGray;
            this.txtTogglUsername.Enabled = false;
            this.txtTogglUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTogglUsername.Location = new System.Drawing.Point(16, 55);
            this.txtTogglUsername.Name = "txtTogglUsername";
            this.txtTogglUsername.ReadOnly = true;
            this.txtTogglUsername.Size = new System.Drawing.Size(281, 24);
            this.txtTogglUsername.TabIndex = 16;
            // 
            // txtTogglPassword
            // 
            this.txtTogglPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTogglPassword.BackColor = System.Drawing.Color.DarkGray;
            this.txtTogglPassword.Enabled = false;
            this.txtTogglPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTogglPassword.Location = new System.Drawing.Point(16, 103);
            this.txtTogglPassword.Name = "txtTogglPassword";
            this.txtTogglPassword.ReadOnly = true;
            this.txtTogglPassword.Size = new System.Drawing.Size(281, 24);
            this.txtTogglPassword.TabIndex = 18;
            this.txtTogglPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(142, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "OR";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(880, 701);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(795, 701);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 30);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConnectionStatus);
            this.groupBox1.Controls.Add(this.lnkTestAuth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTogglAPIKey);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTogglUsername);
            this.groupBox1.Controls.Add(this.txtTogglPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 235);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toggl Auth";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.White;
            this.lblConnectionStatus.Location = new System.Drawing.Point(13, 204);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(284, 19);
            this.lblConnectionStatus.TabIndex = 38;
            this.lblConnectionStatus.Visible = false;
            // 
            // lnkTestAuth
            // 
            this.lnkTestAuth.AutoSize = true;
            this.lnkTestAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTestAuth.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkTestAuth.Location = new System.Drawing.Point(15, 206);
            this.lnkTestAuth.Name = "lnkTestAuth";
            this.lnkTestAuth.Size = new System.Drawing.Size(105, 16);
            this.lnkTestAuth.TabIndex = 37;
            this.lnkTestAuth.TabStop = true;
            this.lnkTestAuth.Text = "Test Connection";
            this.lnkTestAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTestAuth_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxMinimizeToTray);
            this.groupBox2.Controls.Add(this.cbxDormammu);
            this.groupBox2.Controls.Add(this.cbxShowFancyTimer);
            this.groupBox2.Controls.Add(this.txtLogHistory);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxStartWithWindows);
            this.groupBox2.Controls.Add(this.cbxShowOnStart);
            this.groupBox2.Controls.Add(this.cbxCloseToTray);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCheckInterval);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 266);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program Settings";
            // 
            // cbxShowFancyTimer
            // 
            this.cbxShowFancyTimer.AutoSize = true;
            this.cbxShowFancyTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShowFancyTimer.ForeColor = System.Drawing.Color.White;
            this.cbxShowFancyTimer.Location = new System.Drawing.Point(13, 145);
            this.cbxShowFancyTimer.Name = "cbxShowFancyTimer";
            this.cbxShowFancyTimer.Size = new System.Drawing.Size(173, 22);
            this.cbxShowFancyTimer.TabIndex = 17;
            this.cbxShowFancyTimer.Text = "Display Timer in h:m:s";
            this.cbxShowFancyTimer.UseVisualStyleBackColor = true;
            // 
            // txtLogHistory
            // 
            this.txtLogHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogHistory.Location = new System.Drawing.Point(210, 228);
            this.txtLogHistory.Name = "txtLogHistory";
            this.txtLogHistory.Size = new System.Drawing.Size(87, 24);
            this.txtLogHistory.TabIndex = 16;
            this.txtLogHistory.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Number of log lines to keep";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picRefreshButton);
            this.groupBox3.Controls.Add(this.lnkRegisterNew);
            this.groupBox3.Controls.Add(this.btnAddProject);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ddlTogglProjects);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTogglWorkspaceId);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(16, 525);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 167);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toggl Settings";
            // 
            // picRefreshButton
            // 
            this.picRefreshButton.AccessibleDescription = "";
            this.picRefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefreshButton.Image = global::AutoToggl.Properties.Resources.refresh;
            this.picRefreshButton.Location = new System.Drawing.Point(281, 100);
            this.picRefreshButton.Name = "picRefreshButton";
            this.picRefreshButton.Size = new System.Drawing.Size(25, 25);
            this.picRefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefreshButton.TabIndex = 42;
            this.picRefreshButton.TabStop = false;
            this.picRefreshButton.Click += new System.EventHandler(this.picRefreshButton_Click);
            this.picRefreshButton.MouseEnter += new System.EventHandler(this.picRefreshButton_MouseEnter);
            this.picRefreshButton.MouseLeave += new System.EventHandler(this.picRefreshButton_MouseLeave);
            // 
            // lnkRegisterNew
            // 
            this.lnkRegisterNew.AutoSize = true;
            this.lnkRegisterNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegisterNew.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkRegisterNew.Location = new System.Drawing.Point(6, 132);
            this.lnkRegisterNew.Name = "lnkRegisterNew";
            this.lnkRegisterNew.Size = new System.Drawing.Size(194, 16);
            this.lnkRegisterNew.TabIndex = 41;
            this.lnkRegisterNew.TabStop = true;
            this.lnkRegisterNew.Text = "Register a new Project in Toggl";
            this.lnkRegisterNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegisterNew_LinkClicked);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.Black;
            this.btnAddProject.Location = new System.Drawing.Point(244, 100);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(31, 29);
            this.btnAddProject.TabIndex = 15;
            this.btnAddProject.Text = "+";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Projects";
            // 
            // ddlTogglProjects
            // 
            this.ddlTogglProjects.DataSource = this.togglProjectsBindingSource;
            this.ddlTogglProjects.DisplayMember = "name";
            this.ddlTogglProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTogglProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTogglProjects.FormattingEnabled = true;
            this.ddlTogglProjects.IntegralHeight = false;
            this.ddlTogglProjects.ItemHeight = 18;
            this.ddlTogglProjects.Location = new System.Drawing.Point(7, 102);
            this.ddlTogglProjects.MaxDropDownItems = 88;
            this.ddlTogglProjects.Name = "ddlTogglProjects";
            this.ddlTogglProjects.Size = new System.Drawing.Size(231, 26);
            this.ddlTogglProjects.TabIndex = 13;
            this.ddlTogglProjects.ValueMember = "name";
            // 
            // togglProjectsBindingSource
            // 
            this.togglProjectsBindingSource.DataSource = typeof(TogglConnect.Project);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lnkDeleteTrackedProject);
            this.groupBox4.Controls.Add(this.btnDownProjectListItem);
            this.groupBox4.Controls.Add(this.btnUpProjectListItem);
            this.groupBox4.Controls.Add(this.lstProjects);
            this.groupBox4.Controls.Add(this.lnkSaveEdits);
            this.groupBox4.Controls.Add(this.lnkCancelEdit);
            this.groupBox4.Controls.Add(this.lnkEditKeywords);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtKeywordList);
            this.groupBox4.Controls.Add(this.lblTogglProjects);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Location = new System.Drawing.Point(349, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 428);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Keyword Settings";
            // 
            // lnkDeleteTrackedProject
            // 
            this.lnkDeleteTrackedProject.AutoSize = true;
            this.lnkDeleteTrackedProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDeleteTrackedProject.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkDeleteTrackedProject.Location = new System.Drawing.Point(211, 36);
            this.lnkDeleteTrackedProject.Name = "lnkDeleteTrackedProject";
            this.lnkDeleteTrackedProject.Size = new System.Drawing.Size(48, 16);
            this.lnkDeleteTrackedProject.TabIndex = 40;
            this.lnkDeleteTrackedProject.TabStop = true;
            this.lnkDeleteTrackedProject.Text = "Delete";
            this.lnkDeleteTrackedProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDeleteTrackedProject_LinkClicked);
            // 
            // btnDownProjectListItem
            // 
            this.btnDownProjectListItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownProjectListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownProjectListItem.ForeColor = System.Drawing.Color.White;
            this.btnDownProjectListItem.Location = new System.Drawing.Point(266, 234);
            this.btnDownProjectListItem.Name = "btnDownProjectListItem";
            this.btnDownProjectListItem.Size = new System.Drawing.Size(57, 41);
            this.btnDownProjectListItem.TabIndex = 39;
            this.btnDownProjectListItem.Text = "\\/";
            this.btnDownProjectListItem.UseVisualStyleBackColor = false;
            this.btnDownProjectListItem.Click += new System.EventHandler(this.btnDownProjectListItem_Click);
            // 
            // btnUpProjectListItem
            // 
            this.btnUpProjectListItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpProjectListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpProjectListItem.ForeColor = System.Drawing.Color.White;
            this.btnUpProjectListItem.Location = new System.Drawing.Point(266, 187);
            this.btnUpProjectListItem.Name = "btnUpProjectListItem";
            this.btnUpProjectListItem.Size = new System.Drawing.Size(56, 41);
            this.btnUpProjectListItem.TabIndex = 38;
            this.btnUpProjectListItem.Text = "/\\";
            this.btnUpProjectListItem.UseVisualStyleBackColor = false;
            this.btnUpProjectListItem.Click += new System.EventHandler(this.btnUpProjectListItem_Click);
            // 
            // lstProjects
            // 
            this.lstProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstProjects.DataSource = this.trackedProjectBindingSource;
            this.lstProjects.DisplayMember = "Name";
            this.lstProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProjects.ForeColor = System.Drawing.Color.White;
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.IntegralHeight = false;
            this.lstProjects.ItemHeight = 18;
            this.lstProjects.Location = new System.Drawing.Point(10, 56);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(249, 360);
            this.lstProjects.TabIndex = 37;
            this.lstProjects.ValueMember = "Name";
            this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstProjects_SelectedIndexChanged);
            // 
            // trackedProjectBindingSource
            // 
            this.trackedProjectBindingSource.DataSource = typeof(DesktopProjectDataHandler.TrackedProject);
            // 
            // lnkSaveEdits
            // 
            this.lnkSaveEdits.AutoSize = true;
            this.lnkSaveEdits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSaveEdits.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkSaveEdits.Location = new System.Drawing.Point(442, 36);
            this.lnkSaveEdits.Name = "lnkSaveEdits";
            this.lnkSaveEdits.Size = new System.Drawing.Size(40, 16);
            this.lnkSaveEdits.TabIndex = 36;
            this.lnkSaveEdits.TabStop = true;
            this.lnkSaveEdits.Text = "Save";
            this.lnkSaveEdits.Visible = false;
            this.lnkSaveEdits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSaveEdits_LinkClicked);
            // 
            // lnkCancelEdit
            // 
            this.lnkCancelEdit.AutoSize = true;
            this.lnkCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCancelEdit.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkCancelEdit.Location = new System.Drawing.Point(488, 36);
            this.lnkCancelEdit.Name = "lnkCancelEdit";
            this.lnkCancelEdit.Size = new System.Drawing.Size(50, 16);
            this.lnkCancelEdit.TabIndex = 34;
            this.lnkCancelEdit.TabStop = true;
            this.lnkCancelEdit.Text = "Cancel";
            this.lnkCancelEdit.Visible = false;
            this.lnkCancelEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCancelEdit_LinkClicked);
            // 
            // lnkEditKeywords
            // 
            this.lnkEditKeywords.AutoSize = true;
            this.lnkEditKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditKeywords.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkEditKeywords.Location = new System.Drawing.Point(405, 36);
            this.lnkEditKeywords.Name = "lnkEditKeywords";
            this.lnkEditKeywords.Size = new System.Drawing.Size(31, 16);
            this.lnkEditKeywords.TabIndex = 33;
            this.lnkEditKeywords.TabStop = true;
            this.lnkEditKeywords.Text = "Edit";
            this.lnkEditKeywords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditKeywords_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(325, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Keywords";
            // 
            // txtKeywordList
            // 
            this.txtKeywordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeywordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeywordList.ForeColor = System.Drawing.Color.White;
            this.txtKeywordList.Location = new System.Drawing.Point(328, 59);
            this.txtKeywordList.Multiline = true;
            this.txtKeywordList.Name = "txtKeywordList";
            this.txtKeywordList.Size = new System.Drawing.Size(268, 357);
            this.txtKeywordList.TabIndex = 31;
            // 
            // lblTogglProjects
            // 
            this.lblTogglProjects.AutoSize = true;
            this.lblTogglProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTogglProjects.ForeColor = System.Drawing.Color.White;
            this.lblTogglProjects.Location = new System.Drawing.Point(6, 34);
            this.lblTogglProjects.Name = "lblTogglProjects";
            this.lblTogglProjects.Size = new System.Drawing.Size(121, 18);
            this.lblTogglProjects.TabIndex = 30;
            this.lblTogglProjects.Text = "Tracked Projects";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(TogglConnect.Project);
            // 
            // lblMessages
            // 
            this.lblMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.ForeColor = System.Drawing.Color.White;
            this.lblMessages.Location = new System.Drawing.Point(13, 701);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(776, 30);
            this.lblMessages.TabIndex = 13;
            // 
            // projectKeywordsBindingSource
            // 
            this.projectKeywordsBindingSource.DataMember = "ProjectKeywords";
            this.projectKeywordsBindingSource.DataSource = this.trackedProjectBindingSource;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNeutralWindows);
            this.groupBox5.Controls.Add(this.cbxStopOnNeutral);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox5.Location = new System.Drawing.Point(349, 446);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(610, 246);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Neutral Window Settings";
            // 
            // cbxStopOnNeutral
            // 
            this.cbxStopOnNeutral.AutoSize = true;
            this.cbxStopOnNeutral.Enabled = false;
            this.cbxStopOnNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStopOnNeutral.ForeColor = System.Drawing.Color.DimGray;
            this.cbxStopOnNeutral.Location = new System.Drawing.Point(10, 37);
            this.cbxStopOnNeutral.Name = "cbxStopOnNeutral";
            this.cbxStopOnNeutral.Size = new System.Drawing.Size(305, 22);
            this.cbxStopOnNeutral.TabIndex = 17;
            this.cbxStopOnNeutral.Text = "Stop timer when a neutral window is active";
            this.cbxStopOnNeutral.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Neutral keywords";
            // 
            // txtNeutralWindows
            // 
            this.txtNeutralWindows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNeutralWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNeutralWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeutralWindows.ForeColor = System.Drawing.Color.White;
            this.txtNeutralWindows.Location = new System.Drawing.Point(9, 89);
            this.txtNeutralWindows.Multiline = true;
            this.txtNeutralWindows.Name = "txtNeutralWindows";
            this.txtNeutralWindows.Size = new System.Drawing.Size(592, 148);
            this.txtNeutralWindows.TabIndex = 42;
            // 
            // cbxDormammu
            // 
            this.cbxDormammu.AutoSize = true;
            this.cbxDormammu.Enabled = false;
            this.cbxDormammu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDormammu.ForeColor = System.Drawing.Color.DarkGray;
            this.cbxDormammu.Location = new System.Drawing.Point(13, 173);
            this.cbxDormammu.Name = "cbxDormammu";
            this.cbxDormammu.Size = new System.Drawing.Size(107, 22);
            this.cbxDormammu.TabIndex = 18;
            this.cbxDormammu.Text = "Dormammu";
            this.cbxDormammu.UseVisualStyleBackColor = true;
            // 
            // cbxMinimizeToTray
            // 
            this.cbxMinimizeToTray.AutoSize = true;
            this.cbxMinimizeToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMinimizeToTray.ForeColor = System.Drawing.Color.White;
            this.cbxMinimizeToTray.Location = new System.Drawing.Point(13, 117);
            this.cbxMinimizeToTray.Name = "cbxMinimizeToTray";
            this.cbxMinimizeToTray.Size = new System.Drawing.Size(136, 22);
            this.cbxMinimizeToTray.TabIndex = 19;
            this.cbxMinimizeToTray.Text = "Minimize to Tray";
            this.cbxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(970, 738);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Settings";
            this.Text = "AutoToggl Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togglProjectsBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackedProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectKeywordsBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxStartWithWindows;
        private System.Windows.Forms.CheckBox cbxShowOnStart;
        private System.Windows.Forms.CheckBox cbxCloseToTray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTogglAPIKey;
        private System.Windows.Forms.TextBox txtTogglWorkspaceId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTogglUsername;
        private System.Windows.Forms.TextBox txtTogglPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDownProjectListItem;
        private System.Windows.Forms.Button btnUpProjectListItem;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.LinkLabel lnkSaveEdits;
        private System.Windows.Forms.LinkLabel lnkCancelEdit;
        private System.Windows.Forms.LinkLabel lnkEditKeywords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeywordList;
        private System.Windows.Forms.Label lblTogglProjects;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlTogglProjects;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.BindingSource togglProjectsBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource trackedProjectBindingSource;
        private System.Windows.Forms.TextBox txtLogHistory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource projectKeywordsBindingSource;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbxStopOnNeutral;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNeutralWindows;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.LinkLabel lnkTestAuth;
        private System.Windows.Forms.LinkLabel lnkDeleteTrackedProject;
        private System.Windows.Forms.CheckBox cbxShowFancyTimer;
        private System.Windows.Forms.LinkLabel lnkRegisterNew;
        private System.Windows.Forms.PictureBox picRefreshButton;
        private System.Windows.Forms.CheckBox cbxDormammu;
        private System.Windows.Forms.CheckBox cbxMinimizeToTray;
    }
}