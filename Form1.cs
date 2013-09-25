using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace SPSiteAdmin2010
{
    public partial class Form1 : Form
    {
        //Dictionary<string, string> _dictSPWebApp = new Dictionary<string, string>();
        //Dictionary<string, string> _dictContentDBSource = new Dictionary<string, string>();
        //Dictionary<string, string> _dictContentDBDest = new Dictionary<string, string>();
        //Dictionary<string, string> _dictSPSiteSource = new Dictionary<string, string>();
        //Dictionary<string, string> _dictSPSiteDest = new Dictionary<string, string>();
        Dictionary<string, string> _dictPSScriptMove = new Dictionary<string, string>();
        Dictionary<string, string> _dictPSScriptBackup = new Dictionary<string, string>();
        Dictionary<string, string> _dictPSScriptRestore = new Dictionary<string, string>();
        Dictionary<string, string> _dictPSScriptCreate = new Dictionary<string, string>();

        //site url, database name
        public const string _PSTemplate_SPSiteMove = @"Move-SPSite {0} -DestinationDatabase {1} -Confirm:$false";
        //site url, folder, file
        public const string _PSTemplate_SPSiteBackup = @"Backup-SPSite {0} -Path ""{1}\{2}""";
        //site url, folder, file, database server, database name
        public const string _PSTemplate_SPSiteRestore = @"Restore-SPSite -Identity {0} -Path ""{1}\{2}"" -Force";
        //public const string _PSTemplate_RestoreSPSite = @"Restore-SPSite -Identity {0} -Path ""{1}\{2}"" -DatabaseServer {3} -DatabaseName {4} -Force";
        public const string _PSTemplate_SPSiteCreate = @"New-SPSite {0} -OwnerAlias ""{1}"" -Name ""{2}"" -Template ""{3}"" -ContentDatabase {4} -Description ""{5}""";

        DataTable dtRestore = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private int GetComboBoxSelectedIndexByValue(ComboBox objComboBox, string strValue)
        {
            int iIndex = 0;

            for (int i = 0; i < objComboBox.Items.Count; i++)
			{
                if (((KeyValuePair<string, string>)objComboBox.Items[i]).Key.Equals(strValue, StringComparison.InvariantCultureIgnoreCase))
                {
                    return i;
                }
			}

            return iIndex;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Cursor cursorBackup = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            if (e.TabPage.Name.Equals(tabPageMove.Name, StringComparison.InvariantCultureIgnoreCase))
            {
                initTabMove();
            }
            else if (e.TabPage.Name.Equals(tabPageBackup.Name, StringComparison.InvariantCultureIgnoreCase))
            {
                initTabBackup();
            }
            else if (e.TabPage.Name.Equals(tabPageRestore.Name, StringComparison.InvariantCultureIgnoreCase))
            {
                initTabRestore();
            }
            else if (e.TabPage.Name.Equals(tabPageCreate.Name, StringComparison.InvariantCultureIgnoreCase))
            {
                initTabCreate();
            }

            textBoxPSScript.Text = string.Empty;
            Cursor.Current = cursorBackup;
        }

        private void initTabMove()
        {
            string strSPWebAppId = string.Empty;
            string strSelectedValueWebAppMove = SPSiteAdmin.Properties.Settings.Default.WebAppMove;
            string strSelectedValueContentDBSource = SPSiteAdmin.Properties.Settings.Default.ContentDBSource;
            string strSelectedValueContentDBDest = SPSiteAdmin.Properties.Settings.Default.ContentDBDest;

            comboBoxWebAppMove.Items.Clear();
            foreach (SPWebApplication objSPWebApp in SPWebService.ContentService.WebApplications)
            {
                strSPWebAppId = objSPWebApp.Id.ToString();
                //_dictSPWebApp.Add(strSPWebAppId, objSPWebApp.Name);

                comboBoxWebAppMove.Items.Add(new KeyValuePair<string, string>(strSPWebAppId, objSPWebApp.Name));
                //comboBoxWebAppDest.Items.Add(new KeyValuePair<string, string>(strSPWebAppId, objSPWebApp.Name));
            }

            comboBoxWebAppMove.DisplayMember = "Value";
            comboBoxWebAppMove.ValueMember = "Key";
            if (string.IsNullOrEmpty(strSelectedValueWebAppMove) == false)
            {
                comboBoxWebAppMove.SelectedIndex = GetComboBoxSelectedIndexByValue(comboBoxWebAppMove, strSelectedValueWebAppMove);
                comboBoxContentDBSource.SelectedIndex = GetComboBoxSelectedIndexByValue(comboBoxContentDBSource, strSelectedValueContentDBSource);
                comboBoxContentDBDest.SelectedIndex = GetComboBoxSelectedIndexByValue(comboBoxContentDBDest, strSelectedValueContentDBDest);
            }
            else
            {
                if (comboBoxWebAppMove.Items.Count > 0)
                    comboBoxWebAppMove.SelectedIndex = 0;
                if (comboBoxContentDBSource.Items.Count > 0)
                    comboBoxContentDBSource.SelectedIndex = 0;
                if (comboBoxContentDBDest.Items.Count > 0)
                    comboBoxContentDBDest.SelectedIndex = 0;
            }
        }

        private void initTabBackup()
        {
            string strSPWebAppId = string.Empty;
            string strSelectedValueBackupWebApp = SPSiteAdmin.Properties.Settings.Default.WebAppBackup;

            comboBoxBackupWebApp.Items.Clear();
            foreach (SPWebApplication objSPWebApp in SPWebService.ContentService.WebApplications)
            {
                strSPWebAppId = objSPWebApp.Id.ToString();
                //_dictSPWebApp.Add(strSPWebAppId, objSPWebApp.Name);

                comboBoxBackupWebApp.Items.Add(new KeyValuePair<string, string>(strSPWebAppId, objSPWebApp.Name));
            }
            comboBoxBackupWebApp.DisplayMember = "Value";
            comboBoxBackupWebApp.ValueMember = "Key";
            if (string.IsNullOrEmpty(strSelectedValueBackupWebApp) == false)
            {
                comboBoxBackupWebApp.SelectedIndex = GetComboBoxSelectedIndexByValue(comboBoxBackupWebApp, strSelectedValueBackupWebApp);
            }
            else
            {
                if (comboBoxBackupWebApp.Items.Count > 0)
                    comboBoxBackupWebApp.SelectedIndex = 0;
            }

            if (string.IsNullOrEmpty(SPSiteAdmin.Properties.Settings.Default.FolderBackup) == false)
            {
                textBoxFolderBackup.Text = SPSiteAdmin.Properties.Settings.Default.FolderBackup;
            }
            else
            {
                textBoxFolderBackup.Text = Environment.CurrentDirectory;
            }

            checkBoxTimestampBackup.Checked = SPSiteAdmin.Properties.Settings.Default.TimestampBackup;
        }

        private void initTabRestore()
        {
            string strSPWebAppId = string.Empty;
            string strSelectedValueRestoreWebApp = SPSiteAdmin.Properties.Settings.Default.WebAppRestore;

            comboBoxRestoreWebApp.Items.Clear();
            foreach (SPWebApplication objSPWebApp in SPWebService.ContentService.WebApplications)
            {
                strSPWebAppId = objSPWebApp.Id.ToString();
                //_dictSPWebApp.Add(strSPWebAppId, objSPWebApp.Name);

                comboBoxRestoreWebApp.Items.Add(new KeyValuePair<string, string>(strSPWebAppId, objSPWebApp.Name));
            }

            if (dtRestore != null && dtRestore.Columns.Count > 0)
            {
                dtRestore.Rows.Clear();
                dtRestore.Columns.Clear();
            }
            dtRestore.Columns.Add("Selected", typeof(bool));
            dtRestore.Columns.Add("SiteName");
            dtRestore.Columns.Add("SiteUrl");

            dataGridViewRestoreSPSite.DataSource = dtRestore;
            dataGridViewRestoreSPSite.Columns["SiteUrl"].Visible = false;
            dataGridViewRestoreSPSite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            comboBoxRestoreWebApp.DisplayMember = "Value";
            comboBoxRestoreWebApp.ValueMember = "Key";

            //DataGridViewComboBoxColumn columnSiteUrl = new DataGridViewComboBoxColumn();
            //columnSiteUrl.Name = "RestoreFile";
            //columnSiteUrl.DataSource = new string[] { "aa", "bb", "cc" };
            //dataGridViewRestoreSPSite.Columns.Add(columnSiteUrl);

            if (string.IsNullOrEmpty(strSelectedValueRestoreWebApp) == false)
            {
                comboBoxRestoreWebApp.SelectedIndex = GetComboBoxSelectedIndexByValue(comboBoxRestoreWebApp, strSelectedValueRestoreWebApp);
            }
            else
            {
                if (comboBoxRestoreWebApp.Items.Count > 0)
                    comboBoxRestoreWebApp.SelectedIndex = 0;
            }

            if (string.IsNullOrEmpty(SPSiteAdmin.Properties.Settings.Default.FolderRestore) == false)
            {
                textBoxFolderRestore.Text = SPSiteAdmin.Properties.Settings.Default.FolderRestore;
            }
            else
            {
                textBoxFolderRestore.Text = Environment.CurrentDirectory;
            }

            PopulateComboBoxFilesRestore(comboBoxFilesRestore);
        }

        private void initTabCreate()
        {
            string strSPWebAppId = string.Empty;
            string strSelectedValueWebAppCreate = SPSiteAdmin.Properties.Settings.Default.WebAppCreate;
            string strSelectedValueContentDBCreate = SPSiteAdmin.Properties.Settings.Default.ContentDBCreate;

            comboBoxRestoreWebApp.Items.Clear();
            foreach (SPWebApplication objSPWebApp in SPWebService.ContentService.WebApplications)
            {
                strSPWebAppId = objSPWebApp.Id.ToString();
                //_dictSPWebApp.Add(strSPWebAppId, objSPWebApp.Name);

                comboBoxWebAppCreate.Items.Add(new KeyValuePair<string, string>(strSPWebAppId, objSPWebApp.Name));
            }

            comboBoxWebAppCreate.DisplayMember = "Value";
            comboBoxWebAppCreate.ValueMember = "Key";
            if (string.IsNullOrEmpty(strSelectedValueWebAppCreate) == false)
            {
                comboBoxWebAppCreate.SelectedIndex = GetComboBoxSelectedIndexByValue(comboBoxWebAppCreate, strSelectedValueWebAppCreate);
                comboBoxContentDBCreate.SelectedIndex = GetComboBoxSelectedIndexByValue(comboBoxContentDBCreate, strSelectedValueContentDBCreate);
            }
            else
            {
                if (comboBoxWebAppCreate.Items.Count > 0)
                    comboBoxWebAppCreate.SelectedIndex = 0;
                if (comboBoxContentDBCreate.Items.Count > 0)
                    comboBoxContentDBCreate.SelectedIndex = 0;
            }

            Dictionary<string, string> dictSiteTemplate = new Dictionary<string, string>();
            dictSiteTemplate.Add("STS#0", "Team Site");
            dictSiteTemplate.Add("STS#1", "Blank Site");
            comboBoxTemplateCreate.DataSource = new BindingSource(dictSiteTemplate, null);
            comboBoxTemplateCreate.DisplayMember = "Value";
            comboBoxTemplateCreate.ValueMember = "Key";
            comboBoxTemplateCreate.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tabControl1.SelectedIndex = 0;

            initTabMove();
        }

        private void PopulateContentDBs(Guid guidWebApp, ComboBox comboBoxContentDB)
        {
            //if (dictContentDB.Count > 0)
            //    dictContentDB.Clear();
            if (comboBoxContentDB.Items.Count > 0)
                comboBoxContentDB.Items.Clear();

            SPWebApplication objSPWebApp = SPWebService.ContentService.WebApplications[guidWebApp];
            foreach (SPContentDatabase objSPContentDatabase in objSPWebApp.ContentDatabases)
            {
                //dictContentDB.Add(objSPContentDatabase.Id.ToString(), objSPContentDatabase.Name);
                comboBoxContentDB.Items.Add(new KeyValuePair<string, string>(objSPContentDatabase.Id.ToString(), objSPContentDatabase.Name));
            }

            //comboBoxContentDB.DataCreate = new BindingSource(dictContentDB, null);
            comboBoxContentDB.DisplayMember = "Value";
            comboBoxContentDB.ValueMember = "Key";
        }

        private void PopulateManagedPath(Guid guidWebApp, ComboBox comboBoxManagedPath)
        {
            if (comboBoxManagedPath.Items.Count > 0)
                comboBoxManagedPath.Items.Clear();

            SPWebApplication objSPWebApp = SPWebService.ContentService.WebApplications[guidWebApp];
            foreach (SPPrefix prefix in objSPWebApp.Prefixes)
            {
                if (prefix.PrefixType == SPPrefixType.WildcardInclusion || prefix.PrefixType == SPPrefixType.Wildcard)
                {
                    comboBoxManagedPath.Items.Add(new KeyValuePair<string, string>(prefix.Name, prefix.Name));
                }
            }

            //comboBoxContentDB.DataCreate = new BindingSource(dictContentDB, null);
            comboBoxManagedPath.DisplayMember = "Value";
            comboBoxManagedPath.ValueMember = "Key";
        }

        //private void comboBoxWebAppDest_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string strKey = ((KeyValuePair<string, string>)comboBoxWebAppDest.SelectedItem).Key;

        //    PopulateContentDBs(new Guid(strKey),
        //        //_dictContentDBDest,
        //        comboBoxContentDBDest);

        //    SPSiteAdmin.Properties.Settings.Default.WebAppDest = strKey;
        //    SPSiteAdmin.Properties.Settings.Default.Save();

        //    if (comboBoxContentDBDest.Items.Count > 0)
        //    {
        //        comboBoxContentDBDest.SelectedIndex = 0;
        //    }
        //}

        private void PopulateSPSites(Guid guidWebApp, Guid guidContentDB, ListBox listBoxSPSite)
        {
            //if (dictSPSite.Count > 0)
            //    dictSPSite.Clear();
            if (listBoxSPSite.Items.Count > 0)
                listBoxSPSite.Items.Clear();

            SPWebApplication objSPWebApp = SPWebService.ContentService.WebApplications[guidWebApp];
            SPContentDatabase objSPContentDatabase = objSPWebApp.ContentDatabases[guidContentDB];
            foreach (SPSite objSPSite in objSPContentDatabase.Sites)
            {
                if (objSPSite.Url.EndsWith(@"Office_Viewing_Service_Cache"))
                    continue;

                //dictSPSite.Add(objSPSite.Url, string.Format("{0}, {1}", objSPSite.RootWeb.Title, objSPSite.Url));
                listBoxSPSite.Items.Add(new KeyValuePair<string, string>(objSPSite.Url, string.Format("{0}, {1}", objSPSite.RootWeb.Title, objSPSite.Url)));
            }

            //listBoxSPSite.DataSource = new BindingSource(dictSPSite, null);
            listBoxSPSite.DisplayMember = "Value";
            listBoxSPSite.ValueMember = "Key";

            listBoxSPSite.ClearSelected();

            textBoxPSScript.Text = string.Empty;
            _dictPSScriptMove.Clear();
        }

        private void PopulateSPSites(Guid guidWebApp, ListBox listBoxSPSite)
        {
            //if (dictSPSite.Count > 0)
            //    dictSPSite.Clear();
            if (listBoxSPSite.Items.Count > 0)
                listBoxSPSite.Items.Clear();

            SPWebApplication objSPWebApp = SPWebService.ContentService.WebApplications[guidWebApp];
            foreach (SPSite objSPSite in objSPWebApp.Sites)
            {
                if (objSPSite.Url.EndsWith(@"Office_Viewing_Service_Cache"))
                    continue;

                //dictSPSite.Add(objSPSite.Url, string.Format("{0}, {1}", objSPSite.RootWeb.Title, objSPSite.Url));
                listBoxSPSite.Items.Add(new KeyValuePair<string, string>(objSPSite.Url, string.Format("{0}, {1}", objSPSite.RootWeb.Title, objSPSite.Url)));
            }

            //listBoxSPSite.DataSource = new BindingSource(dictSPSite, null);
            listBoxSPSite.DisplayMember = "Value";
            listBoxSPSite.ValueMember = "Key";

            listBoxSPSite.ClearSelected();

            textBoxPSScript.Text = string.Empty;
            _dictPSScriptBackup.Clear();
        }

        private void PopulateSPSites(Guid guidWebApp, DataGridView dataGridViewSPSite)
        {
            //if (dataGridViewSPSite.Rows.Count > 0)
            //    dataGridViewSPSite.Rows.Clear();
            if (dataGridViewSPSite.Columns.Count > 0)
                dataGridViewSPSite.Columns.Clear();
            if (dtRestore.Rows.Count > 0)
                dtRestore.Rows.Clear();

            SPWebApplication objSPWebApp = SPWebService.ContentService.WebApplications[guidWebApp];
            foreach (SPSite objSPSite in objSPWebApp.Sites)
            {
                if (objSPSite.Url.EndsWith(@"Office_Viewing_Service_Cache"))
                    continue;

                DataRow newRow = dtRestore.NewRow();
                newRow["Selected"] = 0;
                newRow["SiteName"] = objSPSite.RootWeb.Title;
                newRow["SiteUrl"] = objSPSite.Url;
                
                //newRow["RestoreFile"] = string.Empty;
                dtRestore.Rows.Add(newRow);
            }
            dataGridViewRestoreSPSite.DataSource = null;
            dataGridViewRestoreSPSite.DataSource = dtRestore;
            //dataGridViewRestoreSPSite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            textBoxPSScript.Text = string.Empty;
            _dictPSScriptRestore.Clear();
        }

        private void ResetStatusListBoxSPSite()
        {
            bool boolEnable = false;

            if (comboBoxContentDBSource.SelectedItem == null || comboBoxContentDBDest.SelectedItem == null)
            {
                ;
            }
            else if (((KeyValuePair<string, string>)comboBoxContentDBSource.SelectedItem).Key == ((KeyValuePair<string, string>)comboBoxContentDBDest.SelectedItem).Key)
            {
                ;
            }
            else
            {
                boolEnable = true;
            }

            listBoxSPSiteSource.Enabled = boolEnable;
            listBoxSPSiteDest.Enabled = boolEnable;
        }

        private void buttonMoveReset_Click(object sender, EventArgs e)
        {
            buttonClearPSScript_Click(null, null);
            comboBoxContentDBSource_SelectedIndexChanged(null, null);
            comboBoxContentDBDest_SelectedIndexChanged(null, null);
        }

        private void comboBoxWebAppMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKey = ((KeyValuePair<string, string>)comboBoxWebAppMove.SelectedItem).Key;

            PopulateContentDBs(new Guid(strKey), comboBoxContentDBSource);
            PopulateContentDBs(new Guid(strKey), comboBoxContentDBDest);

            SPSiteAdmin.Properties.Settings.Default.WebAppMove = strKey;
            SPSiteAdmin.Properties.Settings.Default.Save();

            if (comboBoxContentDBSource.Items.Count > 0)
            {
                comboBoxContentDBSource.SelectedIndex = 0;
                comboBoxContentDBDest.SelectedIndex = 0;
            }
        }

        private void comboBoxContentDBSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKeyWebApp = ((KeyValuePair<string, string>)comboBoxWebAppMove.SelectedItem).Key;
            string strKeyContentDB = ((KeyValuePair<string, string>)comboBoxContentDBSource.SelectedItem).Key;

            PopulateSPSites(new Guid(strKeyWebApp),
                new Guid(strKeyContentDB),
                //_dictSPSiteSource,
                listBoxSPSiteSource);

            SPSiteAdmin.Properties.Settings.Default.ContentDBSource = strKeyContentDB;
            SPSiteAdmin.Properties.Settings.Default.Save();

            ResetStatusListBoxSPSite();
        }

        private void comboBoxContentDBDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKeyWebApp = ((KeyValuePair<string, string>)comboBoxWebAppMove.SelectedItem).Key;
            string strKeyContentDB = ((KeyValuePair<string, string>)comboBoxContentDBDest.SelectedItem).Key;

            PopulateSPSites(new Guid(strKeyWebApp),
                new Guid(strKeyContentDB),
                //_dictSPSiteDest,
                listBoxSPSiteDest);

            SPSiteAdmin.Properties.Settings.Default.ContentDBDest = strKeyContentDB;
            SPSiteAdmin.Properties.Settings.Default.Save();

            ResetStatusListBoxSPSite();
        }

        private void RefreshPSScriptTextBoxMove()
        {
            string strLine = string.Empty;
            textBoxPSScript.Text = string.Empty;

            foreach (string strKey in _dictPSScriptMove.Keys)
            {
                // Move-SPSite http://sharepoint/sites/moveme -DestinationDatabase WSS_Content2 
                strLine = string.Format(_PSTemplate_SPSiteMove, strKey, comboBoxContentDBDest.Text);
                textBoxPSScript.Text += strLine + Environment.NewLine;
            }
        }

        private void listBox_DragDrop(object sender, DragEventArgs e, ListBox objListBoxSource, ListBox objListBoxDest)
        {
            string strKey = string.Empty;
            string strValue = string.Empty;
            ListBox.SelectedObjectCollection objItems = objListBoxSource.SelectedItems;
            int iCurrent = int.MinValue;
            bool boolChangeFlag = false;

            if (objListBoxSource.SelectedItem == null)
                return;

            strKey = ((KeyValuePair<string, string>)objListBoxSource.SelectedItem).Key;
            strValue = ((KeyValuePair<string, string>)objListBoxSource.SelectedItem).Value;
            if (objListBoxSource == listBoxSPSiteSource)
            {
                if (_dictPSScriptMove.ContainsKey(strKey) == false)
                {
                    _dictPSScriptMove.Add(strKey, strValue);
                    boolChangeFlag = true;
                }
            }
            else
            {
                if (_dictPSScriptMove.ContainsKey(strKey))
                {
                    _dictPSScriptMove.Remove(strKey);
                    boolChangeFlag = true;
                }
            }

            if (boolChangeFlag)
            {
                foreach (var item in objItems)
                {
                    iCurrent = objListBoxDest.Items.Add(item);
                    //objListBoxDest.SetSelected(iCurrent, true);
                }
                while (objListBoxSource.SelectedItems.Count > 0)
                {
                    objListBoxSource.Items.Remove(objListBoxSource.SelectedItems[0]);
                }
                RefreshPSScriptTextBoxMove();
            }
        }

        private void listBoxSPSiteDest_DragDrop(object sender, DragEventArgs e)
        {
            listBox_DragDrop(sender, e, listBoxSPSiteSource, listBoxSPSiteDest);
        }

        private void listBoxSPSiteSource_DragDrop(object sender, DragEventArgs e)
        {
            listBox_DragDrop(sender, e, listBoxSPSiteDest, listBoxSPSiteSource);
        }

        private void listBoxSPSiteSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxSPSiteSource.SelectedItem == null)
                return;
            listBoxSPSiteSource.DoDragDrop(listBoxSPSiteSource.SelectedItem, DragDropEffects.Move);
        }

        private void listBoxSPSiteDest_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxSPSiteDest.SelectedItem == null) return;
            listBoxSPSiteDest.DoDragDrop(listBoxSPSiteDest.SelectedItem, DragDropEffects.Move);
        }

        private void listBoxSPSiteSource_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBoxSPSiteDest_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

        }

        private void buttonMoveAll_Click(object sender, EventArgs e)
        {
            for (int i = listBoxSPSiteSource.Items.Count - 1; i >= 0; i--)
            {
                listBoxSPSiteSource.SelectedIndex = i;

                listBox_DragDrop(null, null, listBoxSPSiteSource, listBoxSPSiteDest);
            }
        }

        private void buttonBrowseBackup_Click(object sender, EventArgs e)
        {
            string strFolderName = string.Empty;
            folderBrowserDialog1.ShowNewFolderButton = true;
            strFolderName = textBoxFolderBackup.Text.Trim();
            if (string.IsNullOrEmpty(strFolderName) == false)
            {
                if (System.IO.Directory.Exists(strFolderName))
                {
                    folderBrowserDialog1.SelectedPath = strFolderName;
                }
            }
            DialogResult objDialogResult = folderBrowserDialog1.ShowDialog();
            if (objDialogResult == System.Windows.Forms.DialogResult.OK)
            {
                strFolderName = folderBrowserDialog1.SelectedPath;
                SPSiteAdmin.Properties.Settings.Default.FolderBackup = strFolderName;
                SPSiteAdmin.Properties.Settings.Default.Save();
                textBoxFolderBackup.Text = strFolderName;
            }
        }

        private void comboBoxBackupWebApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKeyWebApp = ((KeyValuePair<string, string>)comboBoxBackupWebApp.SelectedItem).Key;

            PopulateSPSites(new Guid(strKeyWebApp),
                listBoxBackupSPSite);

            SPSiteAdmin.Properties.Settings.Default.WebAppBackup = strKeyWebApp;
            SPSiteAdmin.Properties.Settings.Default.Save();
        }

        private string GetFileName(string strSiteUrl)
        {
            string strFileName = string.Empty;
            int iPos = 0;

            iPos = strSiteUrl.IndexOf(@"//");
            strFileName = strSiteUrl.Substring(iPos + 2);
            strFileName = strFileName.Replace(@"/", @".");
            strFileName = strFileName.Replace(@":", @".");
            if (checkBoxTimestampBackup.Checked)
            {
                strFileName += @"." + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            }
            strFileName += ".bak";

            return strFileName;
        }

        private void textBoxFolderBackup_TextChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxBackup();
        }

        private void RefreshPSScriptTextBoxBackup()
        {
            string strKey = string.Empty;
            string strLine = string.Empty;
            string strFileFullPath = string.Empty;
            textBoxPSScript.Text = string.Empty;

            for (int i = 0; i < listBoxBackupSPSite.SelectedItems.Count; i++)
            {
                strKey = ((KeyValuePair<string, string>)listBoxBackupSPSite.SelectedItems[i]).Key;
                strFileFullPath = GetFileName(strKey);
                strLine = string.Format(_PSTemplate_SPSiteBackup, strKey, textBoxFolderBackup.Text, strFileFullPath);
                textBoxPSScript.Text += strLine + Environment.NewLine;
            }
        }

        private void listBoxBackupSPSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxBackup();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            listBoxBackupSPSite.SelectedItems.Clear();
            for (int i = listBoxBackupSPSite.Items.Count - 1; i >= 0; i--)
            {
                listBoxBackupSPSite.SelectedItems.Add(listBoxBackupSPSite.Items[i]);
            }
            RefreshPSScriptTextBoxBackup();
        }

        private void dataGridViewRestoreSPSite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dataGridViewRestoreSPSite.Rows[dataGridViewRestoreSPSite.CurrentRow.Index].Cells[0];

            if (ch1.Value == null)
                ch1.Value = false;
            switch (ch1.Value.ToString())
            {
                case "True":
                    ch1.Value = false;
                    break;
                case "False":
                    ch1.Value = true;
                    break;
            }
            RefreshPSScriptTextBoxRestore();
            //MessageBox.Show(ch1.Value.ToString());
        }

        private void comboBoxRestoreWebApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKeyWebApp = ((KeyValuePair<string, string>)comboBoxRestoreWebApp.SelectedItem).Key;

            PopulateSPSites(new Guid(strKeyWebApp), dataGridViewRestoreSPSite);

            SPSiteAdmin.Properties.Settings.Default.WebAppRestore = strKeyWebApp;
            SPSiteAdmin.Properties.Settings.Default.Save();

            RefreshPSScriptTextBoxRestore();
        }

        private void buttonBrowseRestore_Click(object sender, EventArgs e)
        {
            string strFolderName = string.Empty;

            folderBrowserDialog1.ShowNewFolderButton = true;
            strFolderName = textBoxFolderRestore.Text.Trim();
            if (string.IsNullOrEmpty(strFolderName) == false)
            {
                if (System.IO.Directory.Exists(strFolderName))
                {
                    folderBrowserDialog1.SelectedPath = strFolderName;
                }
            }
            DialogResult objDialogResult = folderBrowserDialog1.ShowDialog();
            if (objDialogResult == System.Windows.Forms.DialogResult.OK)
            {
                strFolderName = folderBrowserDialog1.SelectedPath;
                SPSiteAdmin.Properties.Settings.Default.FolderRestore = strFolderName;
                SPSiteAdmin.Properties.Settings.Default.Save();
                textBoxFolderRestore.Text = strFolderName;
            }
        }

        private void textBoxFolderRestore_TextChanged(object sender, EventArgs e)
        {
            PopulateComboBoxFilesRestore(comboBoxFilesRestore);
        }

        private void PopulateComboBoxFilesRestore(ComboBox objComboBox)
        {
            if (objComboBox.Items.Count > 0)
                objComboBox.Items.Clear();

            string targetDirectory = textBoxFolderRestore.Text;
            if (Directory.Exists(targetDirectory) == false)
                return;

            int iPos = targetDirectory.Length;
            string[] fileEntries = Directory.GetFiles(targetDirectory, @"*.bak", SearchOption.TopDirectoryOnly);

            foreach (string strEntry in fileEntries)
                objComboBox.Items.Add(strEntry.Substring(iPos + 1));

            if (objComboBox.Items.Count > 0)
                objComboBox.SelectedIndex = 0;

            if (objComboBox.SelectedItem == null)
                dataGridViewRestoreSPSite.Enabled = false;
            else
                dataGridViewRestoreSPSite.Enabled = true;
        }

        private void RefreshPSScriptTextBoxRestore()
        {
            string strSiteUrl = string.Empty;
            string strLine = string.Empty;
            string strFileFullPath = string.Empty;
            textBoxPSScript.Text = string.Empty;

            for (int i = 0; i < dataGridViewRestoreSPSite.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                ch1 = (DataGridViewCheckBoxCell)dataGridViewRestoreSPSite.Rows[i].Cells[0];
                if (ch1.Value == null)
                    ch1.Value = false;

                if ((bool)ch1.Value == true)
                {
                    strSiteUrl = (string)dataGridViewRestoreSPSite.Rows[i].Cells[2].Value;
                    strFileFullPath = comboBoxFilesRestore.SelectedValue as string;
                    //site url, folder, file
                    strLine = string.Format(_PSTemplate_SPSiteRestore, strSiteUrl, textBoxFolderRestore.Text, strFileFullPath);
                    textBoxPSScript.Text += strLine + Environment.NewLine;
                }
            }
        }

        private void comboBoxFilesRestore_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxRestore();
        }

        private void comboBoxWebAppCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKey = ((KeyValuePair<string, string>)comboBoxWebAppCreate.SelectedItem).Key;

            PopulateContentDBs(new Guid(strKey),
                comboBoxContentDBCreate);

            SPSiteAdmin.Properties.Settings.Default.WebAppCreate = strKey;
            SPSiteAdmin.Properties.Settings.Default.Save();

            if (comboBoxContentDBCreate.Items.Count > 0)
            {
                comboBoxContentDBCreate.SelectedIndex = 0;
            }

            PopulateManagedPath(new Guid(strKey), comboBoxManagedPathCreate);

            SPSiteAdmin.Properties.Settings.Default.ManagedPathCreate = strKey;
            SPSiteAdmin.Properties.Settings.Default.Save();

            if (comboBoxManagedPathCreate.Items.Count > 0)
            {
                comboBoxManagedPathCreate.SelectedIndex = 0;
            }
        }

        private void comboBoxContentDBCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKeyWebApp = ((KeyValuePair<string, string>)comboBoxWebAppCreate.SelectedItem).Key;
            string strKeyContentDB = ((KeyValuePair<string, string>)comboBoxContentDBCreate.SelectedItem).Key;

            PopulateSPSites(new Guid(strKeyWebApp),
                new Guid(strKeyContentDB),
                //_dictSPSiteCreate,
                listBoxSPSiteCreate);

            SPSiteAdmin.Properties.Settings.Default.ContentDBCreate = strKeyContentDB;
            SPSiteAdmin.Properties.Settings.Default.Save();

            RefreshPSScriptTextBoxCreate();
        }

        private void buttonCreateRefresh_Click(object sender, EventArgs e)
        {
            string strKeyWebApp = ((KeyValuePair<string, string>)comboBoxWebAppCreate.SelectedItem).Key;
            string strKeyContentDB = ((KeyValuePair<string, string>)comboBoxContentDBCreate.SelectedItem).Key;

            PopulateSPSites(new Guid(strKeyWebApp),
                new Guid(strKeyContentDB),
                //_dictSPSiteCreate,
                listBoxSPSiteCreate);

            //$template = Get-SPWebTemplate "STS#0"
        }

        private void RefreshPSScriptTextBoxCreate()
        {
            string strSitePath = textBoxCreatePath.Text.Trim();
            string strSiteName = textBoxCreateName.Text.Trim();

            if (comboBoxTemplateCreate.SelectedItem == null)
                return;

            if (string.IsNullOrEmpty(strSitePath) || string.IsNullOrEmpty(strSiteName))
                return;

            string strKeyWebApp = ((KeyValuePair<string, string>)comboBoxWebAppCreate.SelectedItem).Key;
            SPWebApplication objSPWebApp = SPWebService.ContentService.WebApplications[new Guid(strKeyWebApp)];
            string strWebAppUrl = string.Empty;
            foreach (SPAlternateUrl altUrl in objSPWebApp.AlternateUrls)
            {
                if (altUrl.UrlZone == SPUrlZone.Default)
                {
                    strWebAppUrl = altUrl.Uri.ToString();
                    break;
                }
            }

            string strManagedPath = ((KeyValuePair<string, string>)comboBoxManagedPathCreate.SelectedItem).Key;
            string strContentDB = ((KeyValuePair<string, string>)comboBoxContentDBCreate.SelectedItem).Value;

            string strSiteFullPath = string.Format(@"{0}{1}/{2}", strWebAppUrl, strManagedPath, strSitePath);
            string strSiteTemplate = ((KeyValuePair<string, string>)comboBoxTemplateCreate.SelectedItem).Key;
            
            string strSiteDescription = textBoxCreateDescription.Text.Trim();
            string strSiteCollectionOwnerLogin = string.Format(@"{0}\{1}", Environment.UserDomainName, Environment.UserName);

            textBoxPSScript.Text = string.Empty;

            // @"New-SPSite {0} -OwnerAlias ""{1}"" –Language 1033 -Name ""{2}"" -Template ""{3}"" -ContentDatabase {4} -Description {5}";
            textBoxPSScript.Text = string.Format(_PSTemplate_SPSiteCreate, strSiteFullPath, strSiteCollectionOwnerLogin,
                strSiteName, strSiteTemplate, strContentDB, strSiteDescription);
        }

        private void comboBoxManagedPathCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxCreate();
        }

        private void textBoxCreatePath_TextChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxCreate();
        }

        private void textBoxCreateName_TextChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxCreate();
        }

        private void comboBoxTemplateCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxCreate();
        }

        private void textBoxCreateDescription_TextChanged(object sender, EventArgs e)
        {
            RefreshPSScriptTextBoxCreate();
        }

        private void buttonClearPSScript_Click(object sender, EventArgs e)
        {
            textBoxPSScript.Text = string.Empty;
        }

        private void checkBoxTimestampBackup_CheckedChanged(object sender, EventArgs e)
        {
            SPSiteAdmin.Properties.Settings.Default.TimestampBackup = checkBoxTimestampBackup.Checked;
        }
    }
}
