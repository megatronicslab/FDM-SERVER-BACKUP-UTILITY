namespace backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.backupSetting = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Backuptab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.showPath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backupData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pathLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.restoreData = new System.Windows.Forms.Button();
            this.restoreSettings = new System.Windows.Forms.Button();
            this.browseFolder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.Backuptab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restore Page";
            // 
            // backupSetting
            // 
            this.backupSetting.Location = new System.Drawing.Point(112, 125);
            this.backupSetting.Name = "backupSetting";
            this.backupSetting.Size = new System.Drawing.Size(103, 23);
            this.backupSetting.TabIndex = 2;
            this.backupSetting.Text = "Backup Settings";
            this.backupSetting.UseVisualStyleBackColor = true;
            this.backupSetting.Click += new System.EventHandler(this.backupSetting_Click);
            // 
            // Backuptab
            // 
            this.Backuptab.Controls.Add(this.tabPage1);
            this.Backuptab.Controls.Add(this.tabPage2);
            this.Backuptab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backuptab.Location = new System.Drawing.Point(21, 12);
            this.Backuptab.Margin = new System.Windows.Forms.Padding(2);
            this.Backuptab.Name = "Backuptab";
            this.Backuptab.Padding = new System.Drawing.Point(8, 3);
            this.Backuptab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Backuptab.SelectedIndex = 0;
            this.Backuptab.ShowToolTips = true;
            this.Backuptab.Size = new System.Drawing.Size(555, 329);
            this.Backuptab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Backuptab.TabIndex = 5;
            this.Backuptab.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.showPath);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.backupData);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.backupSetting);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Browse Folder";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveBackupFolder);
            // 
            // showPath
            // 
            this.showPath.AutoSize = true;
            this.showPath.Location = new System.Drawing.Point(325, 50);
            this.showPath.Name = "showPath";
            this.showPath.Size = new System.Drawing.Size(0, 15);
            this.showPath.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please Select Save Data Folder";
            // 
            // backupData
            // 
            this.backupData.Location = new System.Drawing.Point(262, 125);
            this.backupData.Name = "backupData";
            this.backupData.Size = new System.Drawing.Size(103, 23);
            this.backupData.TabIndex = 4;
            this.backupData.Text = "Backup Data";
            this.backupData.UseVisualStyleBackColor = true;
            this.backupData.Click += new System.EventHandler(this.backupAllData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Backup Page";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.pathLabel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.restoreData);
            this.tabPage2.Controls.Add(this.restoreSettings);
            this.tabPage2.Controls.Add(this.browseFolder);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(325, 50);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 13);
            this.pathLabel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Please Select Restore Folder";
            // 
            // restoreData
            // 
            this.restoreData.Location = new System.Drawing.Point(267, 125);
            this.restoreData.Name = "restoreData";
            this.restoreData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.restoreData.Size = new System.Drawing.Size(95, 23);
            this.restoreData.TabIndex = 2;
            this.restoreData.Text = "Restore Data";
            this.restoreData.UseVisualStyleBackColor = true;
            this.restoreData.Click += new System.EventHandler(this.restoreAllData);
            // 
            // restoreSettings
            // 
            this.restoreSettings.Location = new System.Drawing.Point(120, 125);
            this.restoreSettings.Name = "restoreSettings";
            this.restoreSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.restoreSettings.Size = new System.Drawing.Size(95, 23);
            this.restoreSettings.TabIndex = 1;
            this.restoreSettings.Text = "Restore Settings";
            this.restoreSettings.UseVisualStyleBackColor = true;
            this.restoreSettings.Click += new System.EventHandler(this.restoreSettings_Click);
            // 
            // browseFolder
            // 
            this.browseFolder.Location = new System.Drawing.Point(232, 46);
            this.browseFolder.Name = "browseFolder";
            this.browseFolder.Size = new System.Drawing.Size(86, 23);
            this.browseFolder.TabIndex = 0;
            this.browseFolder.Text = "Browse Folder";
            this.browseFolder.UseVisualStyleBackColor = true;
            this.browseFolder.Click += new System.EventHandler(this.selectRestoreFolder);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Backuptab);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Backup and Restore Utility";
            this.Backuptab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backupSetting;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl Backuptab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button browseFolder;
        private System.Windows.Forms.Button restoreSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button backupData;
        private System.Windows.Forms.Button restoreData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label showPath;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button button1;
    }
}

