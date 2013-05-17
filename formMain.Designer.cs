namespace AutoPuTTY
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.lbList = new System.Windows.Forms.ListBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.liShow = new System.Windows.Forms.LinkLabel();
            this.pConfig = new System.Windows.Forms.Panel();
            this.lTunnel = new System.Windows.Forms.Label();
            this.lSepTunnel = new System.Windows.Forms.Label();
            this.lSep4 = new System.Windows.Forms.Label();
            this.lSep3 = new System.Windows.Forms.Label();
            this.lSep2 = new System.Windows.Forms.Label();
            this.lSep1 = new System.Windows.Forms.Label();
            this.bOptions = new System.Windows.Forms.Button();
            this.lHost = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lType = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bModify = new System.Windows.Forms.Button();
            this.lPass = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.liOptions = new System.Windows.Forms.LinkLabel();
            this.lName = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmSystray = new System.Windows.Forms.ContextMenu();
            this.miRestore = new System.Windows.Forms.MenuItem();
            this.miClose = new System.Windows.Forms.MenuItem();
            this.cmList = new System.Windows.Forms.ContextMenu();
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pFind = new System.Windows.Forms.Panel();
            this.cbCase = new System.Windows.Forms.CheckBox();
            this.bClose = new System.Windows.Forms.PictureBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.tbTunnel = new System.Windows.Forms.TextBox();
            this.pConfig.SuspendLayout();
            this.tlMain.SuspendLayout();
            this.tlLeft.SuspendLayout();
            this.pFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbList.IntegralHeight = false;
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Margin = new System.Windows.Forms.Padding(0);
            this.lbList.Name = "lbList";
            this.lbList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbList.Size = new System.Drawing.Size(131, 245);
            this.lbList.Sorted = true;
            this.lbList.TabIndex = 0;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_IndexChanged);
            this.lbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbList_KeyDown);
            this.lbList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbList_KeyPress);
            this.lbList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbList_DoubleClick);
            this.lbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbList_MouseClick);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(2, 137);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(126, 20);
            this.tbPass.TabIndex = 12;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // liShow
            // 
            this.liShow.ActiveLinkColor = System.Drawing.Color.Black;
            this.liShow.AutoSize = true;
            this.liShow.ForeColor = System.Drawing.Color.White;
            this.liShow.Location = new System.Drawing.Point(93, 120);
            this.liShow.Name = "liShow";
            this.liShow.Size = new System.Drawing.Size(34, 13);
            this.liShow.TabIndex = 13;
            this.liShow.TabStop = true;
            this.liShow.Text = "Show";
            this.liShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liShow_LinkClicked);
            // 
            // pConfig
            // 
            this.pConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pConfig.Controls.Add(this.tbTunnel);
            this.pConfig.Controls.Add(this.lTunnel);
            this.pConfig.Controls.Add(this.lSepTunnel);
            this.pConfig.Controls.Add(this.lSep4);
            this.pConfig.Controls.Add(this.lSep3);
            this.pConfig.Controls.Add(this.lSep2);
            this.pConfig.Controls.Add(this.lSep1);
            this.pConfig.Controls.Add(this.bOptions);
            this.pConfig.Controls.Add(this.liShow);
            this.pConfig.Controls.Add(this.lHost);
            this.pConfig.Controls.Add(this.cbType);
            this.pConfig.Controls.Add(this.tbPass);
            this.pConfig.Controls.Add(this.tbUser);
            this.pConfig.Controls.Add(this.tbHost);
            this.pConfig.Controls.Add(this.tbName);
            this.pConfig.Controls.Add(this.lType);
            this.pConfig.Controls.Add(this.bDelete);
            this.pConfig.Controls.Add(this.bAdd);
            this.pConfig.Controls.Add(this.bModify);
            this.pConfig.Controls.Add(this.lPass);
            this.pConfig.Controls.Add(this.lUser);
            this.pConfig.Controls.Add(this.liOptions);
            this.pConfig.Controls.Add(this.lName);
            this.pConfig.Location = new System.Drawing.Point(131, 0);
            this.pConfig.Margin = new System.Windows.Forms.Padding(0);
            this.pConfig.Name = "pConfig";
            this.pConfig.Size = new System.Drawing.Size(130, 265);
            this.pConfig.TabIndex = 1;
            // 
            // lTunnel
            // 
            this.lTunnel.AutoSize = true;
            this.lTunnel.Location = new System.Drawing.Point(3, 158);
            this.lTunnel.Name = "lTunnel";
            this.lTunnel.Size = new System.Drawing.Size(40, 13);
            this.lTunnel.TabIndex = 22;
            this.lTunnel.Text = "Tunnel";
            // 
            // lSepTunnel
            // 
            this.lSepTunnel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lSepTunnel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSepTunnel.Location = new System.Drawing.Point(0, 171);
            this.lSepTunnel.Name = "lSepTunnel";
            this.lSepTunnel.Size = new System.Drawing.Size(126, 2);
            this.lSepTunnel.TabIndex = 21;
            this.lSepTunnel.Text = "2";
            // 
            // lSep4
            // 
            this.lSep4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lSep4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSep4.Location = new System.Drawing.Point(2, 134);
            this.lSep4.Name = "lSep4";
            this.lSep4.Size = new System.Drawing.Size(126, 2);
            this.lSep4.TabIndex = 11;
            this.lSep4.Text = "2";
            // 
            // lSep3
            // 
            this.lSep3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lSep3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSep3.Location = new System.Drawing.Point(2, 95);
            this.lSep3.Name = "lSep3";
            this.lSep3.Size = new System.Drawing.Size(126, 2);
            this.lSep3.TabIndex = 8;
            this.lSep3.Text = "2";
            // 
            // lSep2
            // 
            this.lSep2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lSep2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSep2.Location = new System.Drawing.Point(2, 56);
            this.lSep2.Name = "lSep2";
            this.lSep2.Size = new System.Drawing.Size(126, 2);
            this.lSep2.TabIndex = 5;
            this.lSep2.Text = "2";
            // 
            // lSep1
            // 
            this.lSep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lSep1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSep1.Location = new System.Drawing.Point(2, 17);
            this.lSep1.Name = "lSep1";
            this.lSep1.Size = new System.Drawing.Size(126, 2);
            this.lSep1.TabIndex = 2;
            this.lSep1.Text = "2";
            // 
            // bOptions
            // 
            this.bOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOptions.Image = global::AutoPuTTY.Properties.Resources.iconoptions;
            this.bOptions.Location = new System.Drawing.Point(97, 235);
            this.bOptions.Margin = new System.Windows.Forms.Padding(0);
            this.bOptions.Name = "bOptions";
            this.bOptions.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.bOptions.Size = new System.Drawing.Size(32, 30);
            this.bOptions.TabIndex = 21;
            this.bOptions.UseCompatibleTextRendering = true;
            this.bOptions.UseVisualStyleBackColor = true;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // lHost
            // 
            this.lHost.AutoSize = true;
            this.lHost.Location = new System.Drawing.Point(3, 42);
            this.lHost.Name = "lHost";
            this.lHost.Size = new System.Drawing.Size(82, 13);
            this.lHost.TabIndex = 4;
            this.lHost.Text = "Hostname[:port]";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "PuTTY",
            "Remote Desktop",
            "VNC",
            "WinSCP (SCP)",
            "WinSCP (SFTP)"});
            this.cbType.Location = new System.Drawing.Point(2, 213);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(126, 21);
            this.cbType.TabIndex = 17;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(2, 98);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(126, 20);
            this.tbUser.TabIndex = 9;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(2, 59);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(126, 20);
            this.tbHost.TabIndex = 6;
            this.tbHost.TextChanged += new System.EventHandler(this.tbHost_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(2, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(126, 20);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(3, 196);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(31, 13);
            this.lType.TabIndex = 0;
            this.lType.Text = "Type";
            // 
            // bDelete
            // 
            this.bDelete.Enabled = false;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Image = global::AutoPuTTY.Properties.Resources.icondelete;
            this.bDelete.Location = new System.Drawing.Point(65, 235);
            this.bDelete.Margin = new System.Windows.Forms.Padding(0);
            this.bDelete.Name = "bDelete";
            this.bDelete.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bDelete.Size = new System.Drawing.Size(32, 30);
            this.bDelete.TabIndex = 20;
            this.bDelete.UseCompatibleTextRendering = true;
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.Enabled = false;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Image = global::AutoPuTTY.Properties.Resources.iconadd;
            this.bAdd.Location = new System.Drawing.Point(33, 235);
            this.bAdd.Margin = new System.Windows.Forms.Padding(0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bAdd.Size = new System.Drawing.Size(32, 30);
            this.bAdd.TabIndex = 19;
            this.bAdd.UseCompatibleTextRendering = true;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bModify
            // 
            this.bModify.Enabled = false;
            this.bModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.Image = global::AutoPuTTY.Properties.Resources.iconmodify;
            this.bModify.Location = new System.Drawing.Point(1, 235);
            this.bModify.Margin = new System.Windows.Forms.Padding(0);
            this.bModify.Name = "bModify";
            this.bModify.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bModify.Size = new System.Drawing.Size(32, 30);
            this.bModify.TabIndex = 18;
            this.bModify.UseCompatibleTextRendering = true;
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(3, 120);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(53, 13);
            this.lPass.TabIndex = 10;
            this.lPass.Text = "Password";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(3, 81);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(55, 13);
            this.lUser.TabIndex = 7;
            this.lUser.Text = "Username";
            // 
            // liOptions
            // 
            this.liOptions.ActiveLinkColor = System.Drawing.Color.Black;
            this.liOptions.AutoSize = true;
            this.liOptions.ForeColor = System.Drawing.Color.White;
            this.liOptions.LinkColor = System.Drawing.Color.Blue;
            this.liOptions.Location = new System.Drawing.Point(84, 3);
            this.liOptions.Name = "liOptions";
            this.liOptions.Size = new System.Drawing.Size(43, 13);
            this.liOptions.TabIndex = 1;
            this.liOptions.TabStop = true;
            this.liOptions.Text = "Options";
            this.liOptions.Visible = false;
            this.liOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liOptions_LinkClicked);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(3, 3);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AutoPuTTY";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cmSystray
            // 
            this.cmSystray.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miRestore,
            this.miClose});
            // 
            // miRestore
            // 
            this.miRestore.Enabled = false;
            this.miRestore.Index = 0;
            this.miRestore.Text = "Restore";
            this.miRestore.Click += new System.EventHandler(this.miRestore_Click);
            // 
            // miClose
            // 
            this.miClose.Index = 1;
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // tlMain
            // 
            this.tlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlMain.ColumnCount = 2;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlMain.Controls.Add(this.tlLeft, 0, 0);
            this.tlMain.Controls.Add(this.pConfig, 1, 0);
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 1;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Size = new System.Drawing.Size(261, 269);
            this.tlMain.TabIndex = 0;
            // 
            // tlLeft
            // 
            this.tlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlLeft.ColumnCount = 1;
            this.tlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlLeft.Controls.Add(this.pFind, 0, 1);
            this.tlLeft.Controls.Add(this.lbList, 0, 0);
            this.tlLeft.Location = new System.Drawing.Point(0, 0);
            this.tlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tlLeft.Name = "tlLeft";
            this.tlLeft.RowCount = 2;
            this.tlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlLeft.Size = new System.Drawing.Size(131, 269);
            this.tlLeft.TabIndex = 0;
            // 
            // pFind
            // 
            this.pFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pFind.Controls.Add(this.cbCase);
            this.pFind.Controls.Add(this.bClose);
            this.pFind.Controls.Add(this.tbFilter);
            this.pFind.Location = new System.Drawing.Point(0, 245);
            this.pFind.Margin = new System.Windows.Forms.Padding(0);
            this.pFind.Name = "pFind";
            this.pFind.Size = new System.Drawing.Size(131, 24);
            this.pFind.TabIndex = 1;
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.Location = new System.Drawing.Point(174, 4);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(82, 17);
            this.cbCase.TabIndex = 7;
            this.cbCase.Text = "Match case";
            this.cbCase.UseVisualStyleBackColor = true;
            this.cbCase.CheckedChanged += new System.EventHandler(this.cbCase_CheckedChanged);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Transparent;
            this.bClose.Image = global::AutoPuTTY.Properties.Resources.close;
            this.bClose.Location = new System.Drawing.Point(4, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(16, 16);
            this.bClose.TabIndex = 6;
            this.bClose.TabStop = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            this.bClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bClose_MouseDown);
            this.bClose.MouseLeave += new System.EventHandler(this.bClose_MouseLeave);
            this.bClose.MouseHover += new System.EventHandler(this.bClose_MouseHover);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(24, 2);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(107, 20);
            this.tbFilter.TabIndex = 4;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_Changed);
            // 
            // tbTunnel
            // 
            this.tbTunnel.Location = new System.Drawing.Point(3, 174);
            this.tbTunnel.Name = "tbTunnel";
            this.tbTunnel.Size = new System.Drawing.Size(123, 20);
            this.tbTunnel.TabIndex = 16;
            this.tbTunnel.TextChanged += new System.EventHandler(this.tbTunnel_TextChanged);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(261, 269);
            this.Controls.Add(this.tlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoPuTTY";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.pConfig.ResumeLayout(false);
            this.pConfig.PerformLayout();
            this.tlMain.ResumeLayout(false);
            this.tlLeft.ResumeLayout(false);
            this.pFind.ResumeLayout(false);
            this.pFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel pConfig;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.LinkLabel liShow;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.LinkLabel liOptions;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenu cmSystray;
        private System.Windows.Forms.MenuItem miRestore;
        private System.Windows.Forms.MenuItem miClose;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ContextMenu cmList;
        private System.Windows.Forms.Label lHost;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Label lSep4;
        private System.Windows.Forms.Label lSep3;
        private System.Windows.Forms.Label lSep2;
        private System.Windows.Forms.Label lSep1;
        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.TableLayoutPanel tlLeft;
        private System.Windows.Forms.Panel pFind;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.PictureBox bClose;
        private System.Windows.Forms.CheckBox cbCase;
        private System.Windows.Forms.Label lTunnel;
        private System.Windows.Forms.Label lSepTunnel;
        private System.Windows.Forms.TextBox tbTunnel;
    }
}

