using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace DataEntry
{
    public partial class Form1 : Form
    {
        List<string> _users = new List<string>();
        List<string> _actions = new List<string>();
        string appPath;
        string filePath;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            appPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            filePath = System.IO.Path.Combine(appPath, txtSettingsFileName.Text);
        }

        private void LoadSettings()
        {
            if (ConfigurationManager.AppSettings[Constants.Users] != null)
            {
                LoadFileName();
                LoadDefaultUser();
                //LoadUsers();
                LoadActions();
            }
        }

        private void LoadDefaultUser()
        {
            string defaultUser = ConfigurationManager.AppSettings[Constants.DefaultUser];
            txtSettingsUser.Text = defaultUser;
        }
        private void LoadFileName()
        {
            string fileNameValue = ConfigurationManager.AppSettings[Constants.FileName];
            txtSettingsFileName.Text = fileNameValue;            
        }

        private void LoadUsers()
        {
            string usersValue = ConfigurationManager.AppSettings[Constants.Users];
            _users = usersValue.Split(',').ToList();
            txtSettingsUsers.Text = usersValue;
            ddlUsers_NOTUSED.Items.Clear();
            foreach (string userName in _users)
            {
                ddlUsers_NOTUSED.Items.Add(userName);
            }
        }

        private void LoadActions()
        {
            string actionsValue = ConfigurationManager.AppSettings[Constants.Actions];
            _actions = actionsValue.Split(',').ToList();
            txtSettingsActions.Text = actionsValue;
            ddlAction.Items.Clear();
            foreach (string action in _actions)
            {
                ddlAction.Items.Add(action);
            }
        }

        private void btnSettingSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings[Constants.Users].Value = txtSettingsUsers.Text;
            config.AppSettings.Settings[Constants.Actions].Value = txtSettingsActions.Text;
            config.AppSettings.Settings[Constants.FileName].Value = txtSettingsFileName.Text;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");

            if(MessageBox.Show("Settings saved successfully. Do you want to re-start the application to use new settings?","Settings",MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Restart();
        }

        private void btnSettingReset_Click(object sender, EventArgs e)
        {
            txtSettingsUsers.Text = ConfigurationManager.AppSettings[Constants.Users];
            txtSettingsActions.Text = ConfigurationManager.AppSettings[Constants.Actions];
            txtSettingsFileName.Text = ConfigurationManager.AppSettings[Constants.FileName];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(IsValid())
           {
                FileWriter writer = new FileWriter(filePath);
                writer.SaveRecord(txtFamiliyID.Text, txtMemberID.Text, ddlAction.Text, txtSettingsUser.Text);

                Reset();
            }
        }

        private bool IsValid()
        {
            bool isValid = true;
            string errorMsg = "Please correct below errors : ";
            int familyID;

            if (string.IsNullOrEmpty(txtFamiliyID.Text) && string.IsNullOrEmpty(txtMemberID.Text))
            {
                errorMsg += "\n- Please provide Family id or Member id.";
                isValid = false;
            }
            else if (!string.IsNullOrEmpty(txtFamiliyID.Text) && txtFamiliyID.Text.Length != 8)
            {
                errorMsg += "\n- Length of family id should be 8 charecters.";
                isValid = false;
            }

            if (!string.IsNullOrEmpty(txtFamiliyID.Text) && !int.TryParse(txtFamiliyID.Text,out familyID))
            {
                errorMsg += "\n- Invalid family id.";
                isValid = false;
            }

            if(ddlAction.SelectedItem == null)
            {
                errorMsg += "\n- Please select Action.";
                isValid = false;
            }

            if (String.IsNullOrEmpty(txtSettingsUser.Text))
            {
                errorMsg += "\n- Please select User.";
                isValid = false;
            }
            //if (ddlUsers_NOTUSED.SelectedItem == null)
            //{
            //    errorMsg += "\n- Please select User.";
            //    isValid = false;
            //}

            if (!CheckDuplicate())
            {
                errorMsg += "\n- Duplicate record found.";
                isValid = false;
            }

            if (!isValid)
                MessageBox.Show(errorMsg,"Error");

            return isValid;
        }

        private bool CheckDuplicate()
        {
            string searchString = String.Format("{0},{1},{2}", txtFamiliyID.Text, txtMemberID.Text, ddlAction.Text);
            if (File.Exists(filePath))
            {
                List<string> matches = File.ReadLines(filePath).Where(line => line.Contains(searchString)).ToList();

                if (matches != null && matches.Count > 0)
                    return false;
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtFamiliyID.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            ddlAction.SelectedItem = null;
            ddlUsers_NOTUSED.SelectedItem = null;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtImportPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtImportPath.Text))
            {
                txtLog.Text += "Importing from " + txtImportPath.Text;

                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(txtImportPath.Text);
                string mergeFilePath = txtImportPath.Text + "\\Merged.csv";

                txtLog.Text += "Merge file path : " + mergeFilePath;

                FileInfo[] files = dirInfo.GetFiles("*.csv");

                if (files != null && files.Length > 0)
                {
                    txtLog.Text += String.Format("Total {0} csv files found", files.Length);

                    foreach (var file in files)
                    {
                        txtLog.Text += String.Format("Importing " + file.Name);

                        using (StreamWriter writer = new System.IO.StreamWriter(mergeFilePath, true))
                        {
                            using (StreamReader reader = new StreamReader(file.FullName))
                            {
                                writer.Write(reader.ReadToEnd());
                            }
                        }
                        txtLog.Text += String.Format("Importing successfull - " + file.Name);
                    }
                }
                txtLog.Text += String.Format("Import successfull.");
                MessageBox.Show("Import successfull.");
            }
            else
            {
                MessageBox.Show("Please select import folder first.");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                this.AcceptButton = btnSave;
                this.CancelButton = btnReset;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                this.AcceptButton = btnSettingSave;
                this.CancelButton = btnSettingReset;
            }
        }
    }
}
