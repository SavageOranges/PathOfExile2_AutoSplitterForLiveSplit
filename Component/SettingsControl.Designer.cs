namespace LiveSplit.PathOfExile2AutoSplitter.Component
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_AutoSplit = new System.Windows.Forms.GroupBox();
            this.checkAutoStart = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLogTest = new System.Windows.Forms.Button();
            this.buttonLogBrowse = new System.Windows.Forms.Button();
            this.textBoxLogLocation = new System.Windows.Forms.TextBox();
            this.panelSplitList = new System.Windows.Forms.Panel();
            this.checkWithIcons = new System.Windows.Forms.CheckBox();
            this.buttonGenerateSplits = new System.Windows.Forms.Button();
            this.checkSelectAll = new System.Windows.Forms.CheckBox();
            this.checkedSplitList = new System.Windows.Forms.CheckedListBox();
            this.groupSplitMode = new System.Windows.Forms.GroupBox();
            this.radioLevel = new System.Windows.Forms.RadioButton();
            this.radioCampaignMandatory = new System.Windows.Forms.RadioButton();
            this.radioCampaignFull = new System.Windows.Forms.RadioButton();
            this.checkAutoSplit = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_AutoSplit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelSplitList.SuspendLayout();
            this.groupSplitMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_AutoSplit
            // 
            this.groupBox_AutoSplit.Controls.Add(this.checkAutoStart);
            this.groupBox_AutoSplit.Controls.Add(this.groupBox1);
            this.groupBox_AutoSplit.Controls.Add(this.panelSplitList);
            this.groupBox_AutoSplit.Controls.Add(this.groupSplitMode);
            this.groupBox_AutoSplit.Controls.Add(this.checkAutoSplit);
            this.groupBox_AutoSplit.Location = new System.Drawing.Point(12, 12);
            this.groupBox_AutoSplit.Name = "groupBox_AutoSplit";
            this.groupBox_AutoSplit.Size = new System.Drawing.Size(448, 435);
            this.groupBox_AutoSplit.TabIndex = 0;
            this.groupBox_AutoSplit.TabStop = false;
            this.groupBox_AutoSplit.Text = "Auto Split";
            // 
            // checkAutoStart
            // 
            this.checkAutoStart.AutoSize = true;
            this.checkAutoStart.Location = new System.Drawing.Point(142, 20);
            this.checkAutoStart.Name = "checkAutoStart";
            this.checkAutoStart.Size = new System.Drawing.Size(183, 17);
            this.checkAutoStart.TabIndex = 5;
            this.checkAutoStart.Text = "Enable New Character Auto Start";
            this.checkAutoStart.UseVisualStyleBackColor = true;
            this.checkAutoStart.CheckedChanged += new System.EventHandler(this.HandleFreshCharacterAutoStart);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLogTest);
            this.groupBox1.Controls.Add(this.buttonLogBrowse);
            this.groupBox1.Controls.Add(this.textBoxLogLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client log file location:";
            // 
            // buttonLogTest
            // 
            this.buttonLogTest.Location = new System.Drawing.Point(321, 17);
            this.buttonLogTest.Name = "buttonLogTest";
            this.buttonLogTest.Size = new System.Drawing.Size(75, 23);
            this.buttonLogTest.TabIndex = 4;
            this.buttonLogTest.Text = "Test";
            this.buttonLogTest.UseVisualStyleBackColor = true;
            this.buttonLogTest.Click += new System.EventHandler(this.HandleTestClick);
            // 
            // buttonLogBrowse
            // 
            this.buttonLogBrowse.Location = new System.Drawing.Point(240, 17);
            this.buttonLogBrowse.Name = "buttonLogBrowse";
            this.buttonLogBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonLogBrowse.TabIndex = 3;
            this.buttonLogBrowse.Text = "Browse";
            this.buttonLogBrowse.UseVisualStyleBackColor = true;
            this.buttonLogBrowse.Click += new System.EventHandler(this.HandleBrowseClick);
            // 
            // textBoxLogLocation
            // 
            this.textBoxLogLocation.Location = new System.Drawing.Point(2, 20);
            this.textBoxLogLocation.Name = "textBoxLogLocation";
            this.textBoxLogLocation.Size = new System.Drawing.Size(232, 20);
            this.textBoxLogLocation.TabIndex = 2;
            this.textBoxLogLocation.TextChanged += new System.EventHandler(this.HandleLogLocationChanged);
            // 
            // panelSplitList
            // 
            this.panelSplitList.Controls.Add(this.checkWithIcons);
            this.panelSplitList.Controls.Add(this.buttonGenerateSplits);
            this.panelSplitList.Controls.Add(this.checkSelectAll);
            this.panelSplitList.Controls.Add(this.checkedSplitList);
            this.panelSplitList.Location = new System.Drawing.Point(12, 100);
            this.panelSplitList.Name = "panelSplitList";
            this.panelSplitList.Size = new System.Drawing.Size(400, 256);
            this.panelSplitList.TabIndex = 3;
            // 
            // checkWithIcons
            // 
            this.checkWithIcons.AutoSize = true;
            this.checkWithIcons.Checked = true;
            this.checkWithIcons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWithIcons.Location = new System.Drawing.Point(112, 232);
            this.checkWithIcons.Name = "checkWithIcons";
            this.checkWithIcons.Size = new System.Drawing.Size(77, 17);
            this.checkWithIcons.TabIndex = 12;
            this.checkWithIcons.Text = "With Icons";
            this.checkWithIcons.UseVisualStyleBackColor = true;
            this.checkWithIcons.CheckedChanged += new System.EventHandler(this.HandleIconsChecked);
            // 
            // buttonGenerateSplits
            // 
            this.buttonGenerateSplits.Location = new System.Drawing.Point(2, 228);
            this.buttonGenerateSplits.Name = "buttonGenerateSplits";
            this.buttonGenerateSplits.Size = new System.Drawing.Size(104, 23);
            this.buttonGenerateSplits.TabIndex = 11;
            this.buttonGenerateSplits.Text = "Generate Splits";
            this.buttonGenerateSplits.UseVisualStyleBackColor = true;
            this.buttonGenerateSplits.Click += new System.EventHandler(this.HandleGenerateSplits);
            // 
            // checkSelectAll
            // 
            this.checkSelectAll.AutoSize = true;
            this.checkSelectAll.Checked = true;
            this.checkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSelectAll.Location = new System.Drawing.Point(272, 202);
            this.checkSelectAll.Name = "checkSelectAll";
            this.checkSelectAll.Size = new System.Drawing.Size(123, 17);
            this.checkSelectAll.TabIndex = 10;
            this.checkSelectAll.Text = "Select / Deselect All";
            this.checkSelectAll.UseVisualStyleBackColor = true;
            this.checkSelectAll.CheckedChanged += new System.EventHandler(this.HandleSelectAll);
            // 
            // checkedSplitList
            // 
            this.checkedSplitList.CheckOnClick = true;
            this.checkedSplitList.FormattingEnabled = true;
            this.checkedSplitList.Location = new System.Drawing.Point(2, 8);
            this.checkedSplitList.Name = "checkedSplitList";
            this.checkedSplitList.Size = new System.Drawing.Size(266, 214);
            this.checkedSplitList.TabIndex = 0;
            this.checkedSplitList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.HandleItemChecked);
            // 
            // groupSplitMode
            // 
            this.groupSplitMode.AutoSize = true;
            this.groupSplitMode.Controls.Add(this.radioLevel);
            this.groupSplitMode.Controls.Add(this.radioCampaignMandatory);
            this.groupSplitMode.Controls.Add(this.radioCampaignFull);
            this.groupSplitMode.Location = new System.Drawing.Point(12, 50);
            this.groupSplitMode.Name = "groupSplitMode";
            this.groupSplitMode.Size = new System.Drawing.Size(400, 50);
            this.groupSplitMode.TabIndex = 2;
            this.groupSplitMode.TabStop = false;
            this.groupSplitMode.Text = "Split mode: ";
            // 
            // radioLevel
            // 
            this.radioLevel.AutoSize = true;
            this.radioLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioLevel.Location = new System.Drawing.Point(249, 16);
            this.radioLevel.Name = "radioLevel";
            this.radioLevel.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.radioLevel.Size = new System.Drawing.Size(67, 31);
            this.radioLevel.TabIndex = 12;
            this.radioLevel.TabStop = true;
            this.radioLevel.Text = "Level";
            this.radioLevel.UseVisualStyleBackColor = true;
            this.radioLevel.CheckedChanged += new System.EventHandler(this.HandleSplitCriteriaChanged);
            // 
            // radioCampaignMandatory
            // 
            this.radioCampaignMandatory.AutoSize = true;
            this.radioCampaignMandatory.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioCampaignMandatory.Location = new System.Drawing.Point(126, 16);
            this.radioCampaignMandatory.Name = "radioCampaignMandatory";
            this.radioCampaignMandatory.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.radioCampaignMandatory.Size = new System.Drawing.Size(123, 31);
            this.radioCampaignMandatory.TabIndex = 12;
            this.radioCampaignMandatory.TabStop = true;
            this.radioCampaignMandatory.Text = "Campaign (Any%)";
            this.radioCampaignMandatory.UseVisualStyleBackColor = true;
            this.radioCampaignMandatory.CheckedChanged += new System.EventHandler(this.HandleSplitCriteriaChanged);
            // 
            // radioCampaignFull
            // 
            this.radioCampaignFull.AutoSize = true;
            this.radioCampaignFull.Checked = true;
            this.radioCampaignFull.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioCampaignFull.Location = new System.Drawing.Point(3, 16);
            this.radioCampaignFull.Margin = new System.Windows.Forms.Padding(0);
            this.radioCampaignFull.Name = "radioCampaignFull";
            this.radioCampaignFull.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.radioCampaignFull.Size = new System.Drawing.Size(123, 31);
            this.radioCampaignFull.TabIndex = 12;
            this.radioCampaignFull.TabStop = true;
            this.radioCampaignFull.Text = "Campaign (100%)";
            this.radioCampaignFull.UseVisualStyleBackColor = true;
            this.radioCampaignFull.CheckedChanged += new System.EventHandler(this.HandleSplitCriteriaChanged);
            // 
            // checkAutoSplit
            // 
            this.checkAutoSplit.AutoSize = true;
            this.checkAutoSplit.Checked = true;
            this.checkAutoSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoSplit.Location = new System.Drawing.Point(12, 20);
            this.checkAutoSplit.Name = "checkAutoSplit";
            this.checkAutoSplit.Size = new System.Drawing.Size(124, 17);
            this.checkAutoSplit.TabIndex = 0;
            this.checkAutoSplit.Text = "Enable Auto Splitting";
            this.checkAutoSplit.UseVisualStyleBackColor = true;
            this.checkAutoSplit.CheckedChanged += new System.EventHandler(this.HandleAutoSplitChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Client.txt";
            this.openFileDialog.Filter = "Text files|*.txt";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_AutoSplit);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(476, 512);
            this.groupBox_AutoSplit.ResumeLayout(false);
            this.groupBox_AutoSplit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSplitList.ResumeLayout(false);
            this.panelSplitList.PerformLayout();
            this.groupSplitMode.ResumeLayout(false);
            this.groupSplitMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_AutoSplit;
        private System.Windows.Forms.CheckBox checkAutoSplit;
        private System.Windows.Forms.GroupBox groupSplitMode;
        private System.Windows.Forms.RadioButton radioLevel;
        private System.Windows.Forms.RadioButton radioCampaignMandatory;
        private System.Windows.Forms.RadioButton radioCampaignFull;
        private System.Windows.Forms.Panel panelSplitList;
        private System.Windows.Forms.CheckedListBox checkedSplitList;
        private System.Windows.Forms.CheckBox checkSelectAll;
        private System.Windows.Forms.Button buttonGenerateSplits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLogLocation;
        private System.Windows.Forms.Button buttonLogBrowse;
        private System.Windows.Forms.Button buttonLogTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkWithIcons;
        private System.Windows.Forms.CheckBox checkAutoStart;
    }
}
