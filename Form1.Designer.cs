namespace SPSiteAdmin2010
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMove = new System.Windows.Forms.TabPage();
            this.buttonMoveAll = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxSPSiteDest = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxSPSiteSource = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxContentDBDest = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxContentDBSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWebAppMove = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.buttonBrowseBackup = new System.Windows.Forms.Button();
            this.textBoxFolderBackup = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxBackupSPSite = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxBackupWebApp = new System.Windows.Forms.ComboBox();
            this.tabPageRestore = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxFilesRestore = new System.Windows.Forms.ComboBox();
            this.dataGridViewRestoreSPSite = new System.Windows.Forms.DataGridView();
            this.buttonBrowseRestore = new System.Windows.Forms.Button();
            this.textBoxFolderRestore = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxRestoreWebApp = new System.Windows.Forms.ComboBox();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.comboBoxTemplateCreate = new System.Windows.Forms.ComboBox();
            this.textBoxCreateDescription = new System.Windows.Forms.TextBox();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.textBoxCreatePath = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCreateRefresh = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.listBoxSPSiteCreate = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxContentDBCreate = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxWebAppCreate = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonClearPSScript = new System.Windows.Forms.Button();
            this.textBoxPSScript = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBoxManagedPathCreate = new System.Windows.Forms.ComboBox();
            this.buttonMoveReset = new System.Windows.Forms.Button();
            this.checkBoxTimestampBackup = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageMove.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.tabPageRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestoreSPSite)).BeginInit();
            this.tabPageCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageMove);
            this.tabControl1.Controls.Add(this.tabPageBackup);
            this.tabControl1.Controls.Add(this.tabPageRestore);
            this.tabControl1.Controls.Add(this.tabPageCreate);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 421);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageMove
            // 
            this.tabPageMove.Controls.Add(this.buttonMoveReset);
            this.tabPageMove.Controls.Add(this.buttonMoveAll);
            this.tabPageMove.Controls.Add(this.label8);
            this.tabPageMove.Controls.Add(this.listBoxSPSiteDest);
            this.tabPageMove.Controls.Add(this.label7);
            this.tabPageMove.Controls.Add(this.listBoxSPSiteSource);
            this.tabPageMove.Controls.Add(this.label6);
            this.tabPageMove.Controls.Add(this.comboBoxContentDBDest);
            this.tabPageMove.Controls.Add(this.label5);
            this.tabPageMove.Controls.Add(this.comboBoxContentDBSource);
            this.tabPageMove.Controls.Add(this.label3);
            this.tabPageMove.Controls.Add(this.comboBoxWebAppMove);
            this.tabPageMove.Controls.Add(this.label2);
            this.tabPageMove.Controls.Add(this.label1);
            this.tabPageMove.Location = new System.Drawing.Point(4, 22);
            this.tabPageMove.Name = "tabPageMove";
            this.tabPageMove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMove.Size = new System.Drawing.Size(921, 395);
            this.tabPageMove.TabIndex = 1;
            this.tabPageMove.Text = "Move";
            this.tabPageMove.UseVisualStyleBackColor = true;
            // 
            // buttonMoveAll
            // 
            this.buttonMoveAll.Location = new System.Drawing.Point(363, 90);
            this.buttonMoveAll.Name = "buttonMoveAll";
            this.buttonMoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveAll.TabIndex = 18;
            this.buttonMoveAll.Text = "Move All";
            this.buttonMoveAll.UseVisualStyleBackColor = true;
            this.buttonMoveAll.Click += new System.EventHandler(this.buttonMoveAll_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Site collection";
            // 
            // listBoxSPSiteDest
            // 
            this.listBoxSPSiteDest.AllowDrop = true;
            this.listBoxSPSiteDest.FormattingEnabled = true;
            this.listBoxSPSiteDest.HorizontalScrollbar = true;
            this.listBoxSPSiteDest.Location = new System.Drawing.Point(457, 119);
            this.listBoxSPSiteDest.Name = "listBoxSPSiteDest";
            this.listBoxSPSiteDest.Size = new System.Drawing.Size(449, 264);
            this.listBoxSPSiteDest.TabIndex = 12;
            this.listBoxSPSiteDest.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxSPSiteDest_DragDrop);
            this.listBoxSPSiteDest.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxSPSiteDest_DragOver);
            this.listBoxSPSiteDest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxSPSiteDest_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Site collection (drag and drop to generate script)";
            // 
            // listBoxSPSiteSource
            // 
            this.listBoxSPSiteSource.AllowDrop = true;
            this.listBoxSPSiteSource.FormattingEnabled = true;
            this.listBoxSPSiteSource.HorizontalScrollbar = true;
            this.listBoxSPSiteSource.Location = new System.Drawing.Point(9, 119);
            this.listBoxSPSiteSource.Name = "listBoxSPSiteSource";
            this.listBoxSPSiteSource.Size = new System.Drawing.Size(429, 264);
            this.listBoxSPSiteSource.TabIndex = 10;
            this.listBoxSPSiteSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxSPSiteSource_DragDrop);
            this.listBoxSPSiteSource.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxSPSiteSource_DragOver);
            this.listBoxSPSiteSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxSPSiteSource_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Content database";
            // 
            // comboBoxContentDBDest
            // 
            this.comboBoxContentDBDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContentDBDest.FormattingEnabled = true;
            this.comboBoxContentDBDest.Location = new System.Drawing.Point(556, 64);
            this.comboBoxContentDBDest.Name = "comboBoxContentDBDest";
            this.comboBoxContentDBDest.Size = new System.Drawing.Size(350, 21);
            this.comboBoxContentDBDest.TabIndex = 8;
            this.comboBoxContentDBDest.SelectedIndexChanged += new System.EventHandler(this.comboBoxContentDBDest_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Content database";
            // 
            // comboBoxContentDBSource
            // 
            this.comboBoxContentDBSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContentDBSource.FormattingEnabled = true;
            this.comboBoxContentDBSource.Location = new System.Drawing.Point(108, 61);
            this.comboBoxContentDBSource.Name = "comboBoxContentDBSource";
            this.comboBoxContentDBSource.Size = new System.Drawing.Size(330, 21);
            this.comboBoxContentDBSource.TabIndex = 6;
            this.comboBoxContentDBSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxContentDBSource_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Web application";
            // 
            // comboBoxWebAppMove
            // 
            this.comboBoxWebAppMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWebAppMove.FormattingEnabled = true;
            this.comboBoxWebAppMove.Location = new System.Drawing.Point(108, 34);
            this.comboBoxWebAppMove.Name = "comboBoxWebAppMove";
            this.comboBoxWebAppMove.Size = new System.Drawing.Size(330, 21);
            this.comboBoxWebAppMove.TabIndex = 2;
            this.comboBoxWebAppMove.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebAppMove_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.checkBoxTimestampBackup);
            this.tabPageBackup.Controls.Add(this.buttonBrowseBackup);
            this.tabPageBackup.Controls.Add(this.textBoxFolderBackup);
            this.tabPageBackup.Controls.Add(this.label13);
            this.tabPageBackup.Controls.Add(this.buttonSelectAll);
            this.tabPageBackup.Controls.Add(this.label10);
            this.tabPageBackup.Controls.Add(this.listBoxBackupSPSite);
            this.tabPageBackup.Controls.Add(this.label12);
            this.tabPageBackup.Controls.Add(this.comboBoxBackupWebApp);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackup.Size = new System.Drawing.Size(921, 395);
            this.tabPageBackup.TabIndex = 0;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseBackup
            // 
            this.buttonBrowseBackup.Location = new System.Drawing.Point(822, 9);
            this.buttonBrowseBackup.Name = "buttonBrowseBackup";
            this.buttonBrowseBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseBackup.TabIndex = 28;
            this.buttonBrowseBackup.Text = "Browse";
            this.buttonBrowseBackup.UseVisualStyleBackColor = true;
            this.buttonBrowseBackup.Click += new System.EventHandler(this.buttonBrowseBackup_Click);
            // 
            // textBoxFolderBackup
            // 
            this.textBoxFolderBackup.Location = new System.Drawing.Point(131, 13);
            this.textBoxFolderBackup.Name = "textBoxFolderBackup";
            this.textBoxFolderBackup.ReadOnly = true;
            this.textBoxFolderBackup.Size = new System.Drawing.Size(684, 20);
            this.textBoxFolderBackup.TabIndex = 27;
            this.textBoxFolderBackup.TextChanged += new System.EventHandler(this.textBoxFolderBackup_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Backup file location";
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(131, 66);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 25;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Site collection";
            // 
            // listBoxBackupSPSite
            // 
            this.listBoxBackupSPSite.AllowDrop = true;
            this.listBoxBackupSPSite.FormattingEnabled = true;
            this.listBoxBackupSPSite.HorizontalScrollbar = true;
            this.listBoxBackupSPSite.Location = new System.Drawing.Point(16, 101);
            this.listBoxBackupSPSite.Name = "listBoxBackupSPSite";
            this.listBoxBackupSPSite.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxBackupSPSite.Size = new System.Drawing.Size(897, 277);
            this.listBoxBackupSPSite.TabIndex = 23;
            this.listBoxBackupSPSite.SelectedIndexChanged += new System.EventHandler(this.listBoxBackupSPSite_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Web application";
            // 
            // comboBoxBackupWebApp
            // 
            this.comboBoxBackupWebApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackupWebApp.FormattingEnabled = true;
            this.comboBoxBackupWebApp.Location = new System.Drawing.Point(131, 39);
            this.comboBoxBackupWebApp.Name = "comboBoxBackupWebApp";
            this.comboBoxBackupWebApp.Size = new System.Drawing.Size(330, 21);
            this.comboBoxBackupWebApp.TabIndex = 19;
            this.comboBoxBackupWebApp.SelectedIndexChanged += new System.EventHandler(this.comboBoxBackupWebApp_SelectedIndexChanged);
            // 
            // tabPageRestore
            // 
            this.tabPageRestore.Controls.Add(this.label18);
            this.tabPageRestore.Controls.Add(this.comboBoxFilesRestore);
            this.tabPageRestore.Controls.Add(this.dataGridViewRestoreSPSite);
            this.tabPageRestore.Controls.Add(this.buttonBrowseRestore);
            this.tabPageRestore.Controls.Add(this.textBoxFolderRestore);
            this.tabPageRestore.Controls.Add(this.label15);
            this.tabPageRestore.Controls.Add(this.button2);
            this.tabPageRestore.Controls.Add(this.label16);
            this.tabPageRestore.Controls.Add(this.label17);
            this.tabPageRestore.Controls.Add(this.comboBoxRestoreWebApp);
            this.tabPageRestore.Location = new System.Drawing.Point(4, 22);
            this.tabPageRestore.Name = "tabPageRestore";
            this.tabPageRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRestore.Size = new System.Drawing.Size(921, 395);
            this.tabPageRestore.TabIndex = 2;
            this.tabPageRestore.Text = "Restore";
            this.tabPageRestore.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(354, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Files";
            // 
            // comboBoxFilesRestore
            // 
            this.comboBoxFilesRestore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilesRestore.FormattingEnabled = true;
            this.comboBoxFilesRestore.Location = new System.Drawing.Point(388, 40);
            this.comboBoxFilesRestore.Name = "comboBoxFilesRestore";
            this.comboBoxFilesRestore.Size = new System.Drawing.Size(522, 21);
            this.comboBoxFilesRestore.TabIndex = 45;
            this.comboBoxFilesRestore.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilesRestore_SelectedIndexChanged);
            // 
            // dataGridViewRestoreSPSite
            // 
            this.dataGridViewRestoreSPSite.AllowUserToAddRows = false;
            this.dataGridViewRestoreSPSite.AllowUserToDeleteRows = false;
            this.dataGridViewRestoreSPSite.AllowUserToOrderColumns = true;
            this.dataGridViewRestoreSPSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestoreSPSite.Location = new System.Drawing.Point(13, 97);
            this.dataGridViewRestoreSPSite.Name = "dataGridViewRestoreSPSite";
            this.dataGridViewRestoreSPSite.Size = new System.Drawing.Size(897, 283);
            this.dataGridViewRestoreSPSite.TabIndex = 43;
            this.dataGridViewRestoreSPSite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRestoreSPSite_CellContentClick);
            // 
            // buttonBrowseRestore
            // 
            this.buttonBrowseRestore.Location = new System.Drawing.Point(835, 8);
            this.buttonBrowseRestore.Name = "buttonBrowseRestore";
            this.buttonBrowseRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseRestore.TabIndex = 38;
            this.buttonBrowseRestore.Text = "Browse";
            this.buttonBrowseRestore.UseVisualStyleBackColor = true;
            this.buttonBrowseRestore.Click += new System.EventHandler(this.buttonBrowseRestore_Click);
            // 
            // textBoxFolderRestore
            // 
            this.textBoxFolderRestore.Location = new System.Drawing.Point(128, 11);
            this.textBoxFolderRestore.Name = "textBoxFolderRestore";
            this.textBoxFolderRestore.ReadOnly = true;
            this.textBoxFolderRestore.Size = new System.Drawing.Size(701, 20);
            this.textBoxFolderRestore.TabIndex = 37;
            this.textBoxFolderRestore.TextChanged += new System.EventHandler(this.textBoxFolderRestore_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "File location";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Select All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Site collection";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Target web application";
            // 
            // comboBoxRestoreWebApp
            // 
            this.comboBoxRestoreWebApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRestoreWebApp.FormattingEnabled = true;
            this.comboBoxRestoreWebApp.Location = new System.Drawing.Point(128, 41);
            this.comboBoxRestoreWebApp.Name = "comboBoxRestoreWebApp";
            this.comboBoxRestoreWebApp.Size = new System.Drawing.Size(220, 21);
            this.comboBoxRestoreWebApp.TabIndex = 31;
            this.comboBoxRestoreWebApp.SelectedIndexChanged += new System.EventHandler(this.comboBoxRestoreWebApp_SelectedIndexChanged);
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Controls.Add(this.label24);
            this.tabPageCreate.Controls.Add(this.comboBoxManagedPathCreate);
            this.tabPageCreate.Controls.Add(this.comboBoxTemplateCreate);
            this.tabPageCreate.Controls.Add(this.textBoxCreateDescription);
            this.tabPageCreate.Controls.Add(this.textBoxCreateName);
            this.tabPageCreate.Controls.Add(this.textBoxCreatePath);
            this.tabPageCreate.Controls.Add(this.label23);
            this.tabPageCreate.Controls.Add(this.label19);
            this.tabPageCreate.Controls.Add(this.label14);
            this.tabPageCreate.Controls.Add(this.label11);
            this.tabPageCreate.Controls.Add(this.buttonCreateRefresh);
            this.tabPageCreate.Controls.Add(this.label20);
            this.tabPageCreate.Controls.Add(this.listBoxSPSiteCreate);
            this.tabPageCreate.Controls.Add(this.label21);
            this.tabPageCreate.Controls.Add(this.comboBoxContentDBCreate);
            this.tabPageCreate.Controls.Add(this.label22);
            this.tabPageCreate.Controls.Add(this.comboBoxWebAppCreate);
            this.tabPageCreate.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreate.Size = new System.Drawing.Size(921, 395);
            this.tabPageCreate.TabIndex = 3;
            this.tabPageCreate.Text = "Create";
            this.tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // comboBoxTemplateCreate
            // 
            this.comboBoxTemplateCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemplateCreate.FormattingEnabled = true;
            this.comboBoxTemplateCreate.Location = new System.Drawing.Point(112, 161);
            this.comboBoxTemplateCreate.Name = "comboBoxTemplateCreate";
            this.comboBoxTemplateCreate.Size = new System.Drawing.Size(330, 21);
            this.comboBoxTemplateCreate.TabIndex = 36;
            this.comboBoxTemplateCreate.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplateCreate_SelectedIndexChanged);
            // 
            // textBoxCreateDescription
            // 
            this.textBoxCreateDescription.Location = new System.Drawing.Point(112, 190);
            this.textBoxCreateDescription.Multiline = true;
            this.textBoxCreateDescription.Name = "textBoxCreateDescription";
            this.textBoxCreateDescription.Size = new System.Drawing.Size(330, 54);
            this.textBoxCreateDescription.TabIndex = 35;
            this.textBoxCreateDescription.TextChanged += new System.EventHandler(this.textBoxCreateDescription_TextChanged);
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.Location = new System.Drawing.Point(112, 133);
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.Size = new System.Drawing.Size(330, 20);
            this.textBoxCreateName.TabIndex = 34;
            this.textBoxCreateName.TextChanged += new System.EventHandler(this.textBoxCreateName_TextChanged);
            // 
            // textBoxCreatePath
            // 
            this.textBoxCreatePath.Location = new System.Drawing.Point(112, 105);
            this.textBoxCreatePath.Name = "textBoxCreatePath";
            this.textBoxCreatePath.Size = new System.Drawing.Size(330, 20);
            this.textBoxCreatePath.TabIndex = 33;
            this.textBoxCreatePath.TextChanged += new System.EventHandler(this.textBoxCreatePath_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Site template";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Site description";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Site name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Site path name";
            // 
            // buttonCreateRefresh
            // 
            this.buttonCreateRefresh.Location = new System.Drawing.Point(551, 16);
            this.buttonCreateRefresh.Name = "buttonCreateRefresh";
            this.buttonCreateRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateRefresh.TabIndex = 28;
            this.buttonCreateRefresh.Text = "Refresh";
            this.buttonCreateRefresh.UseVisualStyleBackColor = true;
            this.buttonCreateRefresh.Click += new System.EventHandler(this.buttonCreateRefresh_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(458, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Site collection";
            // 
            // listBoxSPSiteCreate
            // 
            this.listBoxSPSiteCreate.AllowDrop = true;
            this.listBoxSPSiteCreate.Enabled = false;
            this.listBoxSPSiteCreate.FormattingEnabled = true;
            this.listBoxSPSiteCreate.HorizontalScrollbar = true;
            this.listBoxSPSiteCreate.Location = new System.Drawing.Point(461, 45);
            this.listBoxSPSiteCreate.Name = "listBoxSPSiteCreate";
            this.listBoxSPSiteCreate.Size = new System.Drawing.Size(429, 329);
            this.listBoxSPSiteCreate.TabIndex = 24;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Content database";
            // 
            // comboBoxContentDBCreate
            // 
            this.comboBoxContentDBCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContentDBCreate.FormattingEnabled = true;
            this.comboBoxContentDBCreate.Location = new System.Drawing.Point(112, 47);
            this.comboBoxContentDBCreate.Name = "comboBoxContentDBCreate";
            this.comboBoxContentDBCreate.Size = new System.Drawing.Size(330, 21);
            this.comboBoxContentDBCreate.TabIndex = 22;
            this.comboBoxContentDBCreate.SelectedIndexChanged += new System.EventHandler(this.comboBoxContentDBCreate_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Web application";
            // 
            // comboBoxWebAppCreate
            // 
            this.comboBoxWebAppCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWebAppCreate.FormattingEnabled = true;
            this.comboBoxWebAppCreate.Location = new System.Drawing.Point(112, 18);
            this.comboBoxWebAppCreate.Name = "comboBoxWebAppCreate";
            this.comboBoxWebAppCreate.Size = new System.Drawing.Size(330, 21);
            this.comboBoxWebAppCreate.TabIndex = 20;
            this.comboBoxWebAppCreate.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebAppCreate_SelectedIndexChanged);
            // 
            // buttonClearPSScript
            // 
            this.buttonClearPSScript.Location = new System.Drawing.Point(119, 440);
            this.buttonClearPSScript.Name = "buttonClearPSScript";
            this.buttonClearPSScript.Size = new System.Drawing.Size(75, 23);
            this.buttonClearPSScript.TabIndex = 22;
            this.buttonClearPSScript.Text = "Clear";
            this.buttonClearPSScript.UseVisualStyleBackColor = true;
            this.buttonClearPSScript.Click += new System.EventHandler(this.buttonClearPSScript_Click);
            // 
            // textBoxPSScript
            // 
            this.textBoxPSScript.Location = new System.Drawing.Point(12, 469);
            this.textBoxPSScript.Multiline = true;
            this.textBoxPSScript.Name = "textBoxPSScript";
            this.textBoxPSScript.ReadOnly = true;
            this.textBoxPSScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPSScript.Size = new System.Drawing.Size(926, 193);
            this.textBoxPSScript.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "PowerShell script";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Managed Path";
            // 
            // comboBoxManagedPathCreate
            // 
            this.comboBoxManagedPathCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManagedPathCreate.FormattingEnabled = true;
            this.comboBoxManagedPathCreate.Location = new System.Drawing.Point(112, 76);
            this.comboBoxManagedPathCreate.Name = "comboBoxManagedPathCreate";
            this.comboBoxManagedPathCreate.Size = new System.Drawing.Size(330, 21);
            this.comboBoxManagedPathCreate.TabIndex = 37;
            this.comboBoxManagedPathCreate.SelectedIndexChanged += new System.EventHandler(this.comboBoxManagedPathCreate_SelectedIndexChanged);
            // 
            // buttonMoveReset
            // 
            this.buttonMoveReset.Location = new System.Drawing.Point(282, 90);
            this.buttonMoveReset.Name = "buttonMoveReset";
            this.buttonMoveReset.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveReset.TabIndex = 19;
            this.buttonMoveReset.Text = "Reset";
            this.buttonMoveReset.UseVisualStyleBackColor = true;
            this.buttonMoveReset.Click += new System.EventHandler(this.buttonMoveReset_Click);
            // 
            // checkBoxTimestampBackup
            // 
            this.checkBoxTimestampBackup.AutoSize = true;
            this.checkBoxTimestampBackup.Location = new System.Drawing.Point(243, 69);
            this.checkBoxTimestampBackup.Name = "checkBoxTimestampBackup";
            this.checkBoxTimestampBackup.Size = new System.Drawing.Size(133, 17);
            this.checkBoxTimestampBackup.TabIndex = 29;
            this.checkBoxTimestampBackup.Text = "Timestamp in file name";
            this.checkBoxTimestampBackup.UseVisualStyleBackColor = true;
            this.checkBoxTimestampBackup.CheckedChanged += new System.EventHandler(this.checkBoxTimestampBackup_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 674);
            this.Controls.Add(this.buttonClearPSScript);
            this.Controls.Add(this.textBoxPSScript);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SharePoint site collection admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMove.ResumeLayout(false);
            this.tabPageMove.PerformLayout();
            this.tabPageBackup.ResumeLayout(false);
            this.tabPageBackup.PerformLayout();
            this.tabPageRestore.ResumeLayout(false);
            this.tabPageRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestoreSPSite)).EndInit();
            this.tabPageCreate.ResumeLayout(false);
            this.tabPageCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.TabPage tabPageMove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxContentDBSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWebAppMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxSPSiteDest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxSPSiteSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxContentDBDest;
        private System.Windows.Forms.Button buttonMoveAll;
        private System.Windows.Forms.Button buttonBrowseBackup;
        private System.Windows.Forms.TextBox textBoxFolderBackup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxBackupSPSite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxBackupWebApp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPageRestore;
        private System.Windows.Forms.Button buttonBrowseRestore;
        private System.Windows.Forms.TextBox textBoxFolderRestore;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxRestoreWebApp;
        private System.Windows.Forms.DataGridView dataGridViewRestoreSPSite;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxFilesRestore;
        private System.Windows.Forms.TabPage tabPageCreate;
        private System.Windows.Forms.Button buttonCreateRefresh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox listBoxSPSiteCreate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxContentDBCreate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxWebAppCreate;
        private System.Windows.Forms.Button buttonClearPSScript;
        private System.Windows.Forms.TextBox textBoxPSScript;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxTemplateCreate;
        private System.Windows.Forms.TextBox textBoxCreateDescription;
        private System.Windows.Forms.TextBox textBoxCreateName;
        private System.Windows.Forms.TextBox textBoxCreatePath;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBoxManagedPathCreate;
        private System.Windows.Forms.Button buttonMoveReset;
        private System.Windows.Forms.CheckBox checkBoxTimestampBackup;
    }
}

