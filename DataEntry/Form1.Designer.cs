namespace DataEntry
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlAction = new System.Windows.Forms.ComboBox();
            this.ddlUsers_NOTUSED = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtFamiliyID = new System.Windows.Forms.TextBox();
            this.lblFamilyId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSettingsUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSettingsFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSettingsActions = new System.Windows.Forms.TextBox();
            this.btnSettingReset = new System.Windows.Forms.Button();
            this.btnSettingSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSettingsUsers = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImportPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 282);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMemberID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ddlAction);
            this.tabPage1.Controls.Add(this.ddlUsers_NOTUSED);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lblUser);
            this.tabPage1.Controls.Add(this.lblAction);
            this.tabPage1.Controls.Add(this.txtFamiliyID);
            this.tabPage1.Controls.Add(this.lblFamilyId);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(134, 51);
            this.txtMemberID.MaxLength = 100;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(217, 20);
            this.txtMemberID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Member ID";
            // 
            // ddlAction
            // 
            this.ddlAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAction.FormattingEnabled = true;
            this.ddlAction.Location = new System.Drawing.Point(134, 78);
            this.ddlAction.Name = "ddlAction";
            this.ddlAction.Size = new System.Drawing.Size(217, 21);
            this.ddlAction.TabIndex = 2;
            // 
            // ddlUsers_NOTUSED
            // 
            this.ddlUsers_NOTUSED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUsers_NOTUSED.FormattingEnabled = true;
            this.ddlUsers_NOTUSED.Location = new System.Drawing.Point(134, 107);
            this.ddlUsers_NOTUSED.Name = "ddlUsers_NOTUSED";
            this.ddlUsers_NOTUSED.Size = new System.Drawing.Size(217, 21);
            this.ddlUsers_NOTUSED.TabIndex = 3;
            this.ddlUsers_NOTUSED.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(252, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(95, 111);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "User : ";
            this.lblUser.Visible = false;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(90, 82);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(43, 13);
            this.lblAction.TabIndex = 11;
            this.lblAction.Text = "Action :";
            // 
            // txtFamiliyID
            // 
            this.txtFamiliyID.Location = new System.Drawing.Point(134, 25);
            this.txtFamiliyID.MaxLength = 8;
            this.txtFamiliyID.Name = "txtFamiliyID";
            this.txtFamiliyID.Size = new System.Drawing.Size(217, 20);
            this.txtFamiliyID.TabIndex = 0;
            // 
            // lblFamilyId
            // 
            this.lblFamilyId.AutoSize = true;
            this.lblFamilyId.Location = new System.Drawing.Point(77, 29);
            this.lblFamilyId.Name = "lblFamilyId";
            this.lblFamilyId.Size = new System.Drawing.Size(56, 13);
            this.lblFamilyId.TabIndex = 9;
            this.lblFamilyId.Text = "Family ID :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSettingsUser);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSettingsFileName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtSettingsActions);
            this.tabPage2.Controls.Add(this.btnSettingReset);
            this.tabPage2.Controls.Add(this.btnSettingSave);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtSettingsUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Default User";
            // 
            // txtSettingsUser
            // 
            this.txtSettingsUser.Location = new System.Drawing.Point(81, 150);
            this.txtSettingsUser.Name = "txtSettingsUser";
            this.txtSettingsUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSettingsUser.Size = new System.Drawing.Size(349, 20);
            this.txtSettingsUser.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Name";
            // 
            // txtSettingsFileName
            // 
            this.txtSettingsFileName.Location = new System.Drawing.Point(69, 125);
            this.txtSettingsFileName.Name = "txtSettingsFileName";
            this.txtSettingsFileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSettingsFileName.Size = new System.Drawing.Size(361, 20);
            this.txtSettingsFileName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actions";
            // 
            // txtSettingsActions
            // 
            this.txtSettingsActions.Location = new System.Drawing.Point(69, 75);
            this.txtSettingsActions.Multiline = true;
            this.txtSettingsActions.Name = "txtSettingsActions";
            this.txtSettingsActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSettingsActions.Size = new System.Drawing.Size(361, 44);
            this.txtSettingsActions.TabIndex = 4;
            // 
            // btnSettingReset
            // 
            this.btnSettingReset.Location = new System.Drawing.Point(355, 225);
            this.btnSettingReset.Name = "btnSettingReset";
            this.btnSettingReset.Size = new System.Drawing.Size(75, 23);
            this.btnSettingReset.TabIndex = 3;
            this.btnSettingReset.Text = "Reset";
            this.btnSettingReset.UseVisualStyleBackColor = true;
            this.btnSettingReset.Click += new System.EventHandler(this.btnSettingReset_Click);
            // 
            // btnSettingSave
            // 
            this.btnSettingSave.Location = new System.Drawing.Point(256, 225);
            this.btnSettingSave.Name = "btnSettingSave";
            this.btnSettingSave.Size = new System.Drawing.Size(75, 23);
            this.btnSettingSave.TabIndex = 2;
            this.btnSettingSave.Text = "Save";
            this.btnSettingSave.UseVisualStyleBackColor = true;
            this.btnSettingSave.Click += new System.EventHandler(this.btnSettingSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            // 
            // txtSettingsUsers
            // 
            this.txtSettingsUsers.Location = new System.Drawing.Point(69, 25);
            this.txtSettingsUsers.Multiline = true;
            this.txtSettingsUsers.Name = "txtSettingsUsers";
            this.txtSettingsUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSettingsUsers.Size = new System.Drawing.Size(361, 44);
            this.txtSettingsUsers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtLog);
            this.tabPage3.Controls.Add(this.btnImport);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtImportPath);
            this.tabPage3.Controls.Add(this.btnSelectFolder);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(448, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Import";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(11, 80);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(429, 158);
            this.txtLog.TabIndex = 4;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(393, 24);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(47, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Import Folder";
            // 
            // txtImportPath
            // 
            this.txtImportPath.Location = new System.Drawing.Point(78, 25);
            this.txtImportPath.Name = "txtImportPath";
            this.txtImportPath.ReadOnly = true;
            this.txtImportPath.Size = new System.Drawing.Size(281, 20);
            this.txtImportPath.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(365, 24);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(456, 282);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Unique";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox ddlAction;
        private System.Windows.Forms.ComboBox ddlUsers_NOTUSED;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtFamiliyID;
        private System.Windows.Forms.Label lblFamilyId;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSettingReset;
        private System.Windows.Forms.Button btnSettingSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSettingsUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSettingsActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSettingsFileName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImportPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSettingsUser;
    }
}

