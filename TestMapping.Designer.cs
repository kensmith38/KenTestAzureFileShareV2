namespace KenTestAzureFileShareV2
{
    partial class TestMapping
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUncServer2KenTestAzure = new System.Windows.Forms.RadioButton();
            this.radioButtonFdriveMyTestProjectsKenTestAzure = new System.Windows.Forms.RadioButton();
            this.radioButtonFdriveKenTestAzure = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonCloudKenTestAzure = new System.Windows.Forms.RadioButton();
            this.radioButtonCloudPathCompanyAKenTestAzure = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLocalFileToCloud = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewLocalDirToCloud = new System.Windows.Forms.DataGridView();
            this.Column_LFtoCFLocalFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LFtoCFCloudFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LDtoCDLocalDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LDtoCDCloudDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewCloudFileToLocal = new System.Windows.Forms.DataGridView();
            this.Column_CFtoLFCloudFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CFtoLFLocalFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewCloudDirectoryToLocal = new System.Windows.Forms.DataGridView();
            this.Column_CDtoLDCloudDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CDtoLDLocalDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalFileToCloud)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalDirToCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCloudFileToLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCloudDirectoryToLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Test Mapping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Use KenTutorialFileShare (ShareClient name=kentutorialfileshare)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButtonUncServer2KenTestAzure);
            this.groupBox1.Controls.Add(this.radioButtonFdriveMyTestProjectsKenTestAzure);
            this.groupBox1.Controls.Add(this.radioButtonFdriveKenTestAzure);
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top level local directory";
            // 
            // radioButtonUncServer2KenTestAzure
            // 
            this.radioButtonUncServer2KenTestAzure.AutoSize = true;
            this.radioButtonUncServer2KenTestAzure.Location = new System.Drawing.Point(22, 74);
            this.radioButtonUncServer2KenTestAzure.Name = "radioButtonUncServer2KenTestAzure";
            this.radioButtonUncServer2KenTestAzure.Size = new System.Drawing.Size(144, 17);
            this.radioButtonUncServer2KenTestAzure.TabIndex = 3;
            this.radioButtonUncServer2KenTestAzure.Text = "\\\\Server2\\KenTestAzure";
            this.radioButtonUncServer2KenTestAzure.UseVisualStyleBackColor = true;
            this.radioButtonUncServer2KenTestAzure.CheckedChanged += new System.EventHandler(this.radioButtonANY_CheckedChanged);
            // 
            // radioButtonFdriveMyTestProjectsKenTestAzure
            // 
            this.radioButtonFdriveMyTestProjectsKenTestAzure.AutoSize = true;
            this.radioButtonFdriveMyTestProjectsKenTestAzure.Location = new System.Drawing.Point(22, 51);
            this.radioButtonFdriveMyTestProjectsKenTestAzure.Name = "radioButtonFdriveMyTestProjectsKenTestAzure";
            this.radioButtonFdriveMyTestProjectsKenTestAzure.Size = new System.Drawing.Size(184, 17);
            this.radioButtonFdriveMyTestProjectsKenTestAzure.TabIndex = 2;
            this.radioButtonFdriveMyTestProjectsKenTestAzure.Text = "F:\\MyTestProjects\\KenTestAzure";
            this.radioButtonFdriveMyTestProjectsKenTestAzure.UseVisualStyleBackColor = true;
            this.radioButtonFdriveMyTestProjectsKenTestAzure.CheckedChanged += new System.EventHandler(this.radioButtonANY_CheckedChanged);
            // 
            // radioButtonFdriveKenTestAzure
            // 
            this.radioButtonFdriveKenTestAzure.AutoSize = true;
            this.radioButtonFdriveKenTestAzure.Checked = true;
            this.radioButtonFdriveKenTestAzure.Location = new System.Drawing.Point(22, 28);
            this.radioButtonFdriveKenTestAzure.Name = "radioButtonFdriveKenTestAzure";
            this.radioButtonFdriveKenTestAzure.Size = new System.Drawing.Size(106, 17);
            this.radioButtonFdriveKenTestAzure.TabIndex = 1;
            this.radioButtonFdriveKenTestAzure.TabStop = true;
            this.radioButtonFdriveKenTestAzure.Text = "F:\\KenTestAzure";
            this.radioButtonFdriveKenTestAzure.UseVisualStyleBackColor = true;
            this.radioButtonFdriveKenTestAzure.CheckedChanged += new System.EventHandler(this.radioButtonANY_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.radioButtonCloudKenTestAzure);
            this.groupBox2.Controls.Add(this.radioButtonCloudPathCompanyAKenTestAzure);
            this.groupBox2.Location = new System.Drawing.Point(311, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 85);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top level cloud directory";
            // 
            // radioButtonCloudKenTestAzure
            // 
            this.radioButtonCloudKenTestAzure.AutoSize = true;
            this.radioButtonCloudKenTestAzure.Checked = true;
            this.radioButtonCloudKenTestAzure.Location = new System.Drawing.Point(22, 28);
            this.radioButtonCloudKenTestAzure.Name = "radioButtonCloudKenTestAzure";
            this.radioButtonCloudKenTestAzure.Size = new System.Drawing.Size(97, 17);
            this.radioButtonCloudKenTestAzure.TabIndex = 2;
            this.radioButtonCloudKenTestAzure.TabStop = true;
            this.radioButtonCloudKenTestAzure.Text = "/KenTestAzure";
            this.radioButtonCloudKenTestAzure.UseVisualStyleBackColor = true;
            this.radioButtonCloudKenTestAzure.CheckedChanged += new System.EventHandler(this.radioButtonANY_CheckedChanged);
            // 
            // radioButtonCloudPathCompanyAKenTestAzure
            // 
            this.radioButtonCloudPathCompanyAKenTestAzure.AutoSize = true;
            this.radioButtonCloudPathCompanyAKenTestAzure.Location = new System.Drawing.Point(22, 51);
            this.radioButtonCloudPathCompanyAKenTestAzure.Name = "radioButtonCloudPathCompanyAKenTestAzure";
            this.radioButtonCloudPathCompanyAKenTestAzure.Size = new System.Drawing.Size(153, 17);
            this.radioButtonCloudPathCompanyAKenTestAzure.TabIndex = 1;
            this.radioButtonCloudPathCompanyAKenTestAzure.Text = "/CompanyA/KenTestAzure";
            this.radioButtonCloudPathCompanyAKenTestAzure.UseVisualStyleBackColor = true;
            this.radioButtonCloudPathCompanyAKenTestAzure.CheckedChanged += new System.EventHandler(this.radioButtonANY_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(42, 210);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 260);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewLocalFileToCloud);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local file to cloud file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "The local file path gets mapped to the cloud file (represented by its path).";
            // 
            // dataGridViewLocalFileToCloud
            // 
            this.dataGridViewLocalFileToCloud.AllowUserToAddRows = false;
            this.dataGridViewLocalFileToCloud.AllowUserToDeleteRows = false;
            this.dataGridViewLocalFileToCloud.AllowUserToResizeRows = false;
            this.dataGridViewLocalFileToCloud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalFileToCloud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_LFtoCFLocalFile,
            this.Column_LFtoCFCloudFile});
            this.dataGridViewLocalFileToCloud.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewLocalFileToCloud.MultiSelect = false;
            this.dataGridViewLocalFileToCloud.Name = "dataGridViewLocalFileToCloud";
            this.dataGridViewLocalFileToCloud.ReadOnly = true;
            this.dataGridViewLocalFileToCloud.RowHeadersVisible = false;
            this.dataGridViewLocalFileToCloud.Size = new System.Drawing.Size(879, 150);
            this.dataGridViewLocalFileToCloud.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridViewLocalDirToCloud);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Local directory to cloud directory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridViewCloudFileToLocal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(922, 234);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cloud file to local file";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.dataGridViewCloudDirectoryToLocal);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(922, 234);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cloud directory to local directory";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "The local file path (of a directory) gets mapped to the cloud directory (represen" +
    "ted by its path).";
            // 
            // dataGridViewLocalDirToCloud
            // 
            this.dataGridViewLocalDirToCloud.AllowUserToAddRows = false;
            this.dataGridViewLocalDirToCloud.AllowUserToDeleteRows = false;
            this.dataGridViewLocalDirToCloud.AllowUserToResizeRows = false;
            this.dataGridViewLocalDirToCloud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalDirToCloud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_LDtoCDLocalDir,
            this.Column_LDtoCDCloudDir});
            this.dataGridViewLocalDirToCloud.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewLocalDirToCloud.MultiSelect = false;
            this.dataGridViewLocalDirToCloud.Name = "dataGridViewLocalDirToCloud";
            this.dataGridViewLocalDirToCloud.ReadOnly = true;
            this.dataGridViewLocalDirToCloud.RowHeadersVisible = false;
            this.dataGridViewLocalDirToCloud.Size = new System.Drawing.Size(879, 150);
            this.dataGridViewLocalDirToCloud.TabIndex = 21;
            // 
            // Column_LFtoCFLocalFile
            // 
            this.Column_LFtoCFLocalFile.HeaderText = "Local file path";
            this.Column_LFtoCFLocalFile.Name = "Column_LFtoCFLocalFile";
            this.Column_LFtoCFLocalFile.ReadOnly = true;
            this.Column_LFtoCFLocalFile.Width = 400;
            // 
            // Column_LFtoCFCloudFile
            // 
            this.Column_LFtoCFCloudFile.HeaderText = "Cloud file";
            this.Column_LFtoCFCloudFile.Name = "Column_LFtoCFCloudFile";
            this.Column_LFtoCFCloudFile.ReadOnly = true;
            this.Column_LFtoCFCloudFile.Width = 450;
            // 
            // Column_LDtoCDLocalDir
            // 
            this.Column_LDtoCDLocalDir.HeaderText = "Local file path (of a directory)";
            this.Column_LDtoCDLocalDir.Name = "Column_LDtoCDLocalDir";
            this.Column_LDtoCDLocalDir.ReadOnly = true;
            this.Column_LDtoCDLocalDir.Width = 400;
            // 
            // Column_LDtoCDCloudDir
            // 
            this.Column_LDtoCDCloudDir.HeaderText = "Cloud directory";
            this.Column_LDtoCDCloudDir.Name = "Column_LDtoCDCloudDir";
            this.Column_LDtoCDCloudDir.ReadOnly = true;
            this.Column_LDtoCDCloudDir.Width = 450;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "A cloud file (represented by its path) gets mapped to a local file path.";
            // 
            // dataGridViewCloudFileToLocal
            // 
            this.dataGridViewCloudFileToLocal.AllowUserToAddRows = false;
            this.dataGridViewCloudFileToLocal.AllowUserToDeleteRows = false;
            this.dataGridViewCloudFileToLocal.AllowUserToResizeRows = false;
            this.dataGridViewCloudFileToLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCloudFileToLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_CFtoLFCloudFile,
            this.Column_CFtoLFLocalFile});
            this.dataGridViewCloudFileToLocal.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewCloudFileToLocal.MultiSelect = false;
            this.dataGridViewCloudFileToLocal.Name = "dataGridViewCloudFileToLocal";
            this.dataGridViewCloudFileToLocal.ReadOnly = true;
            this.dataGridViewCloudFileToLocal.RowHeadersVisible = false;
            this.dataGridViewCloudFileToLocal.Size = new System.Drawing.Size(879, 150);
            this.dataGridViewCloudFileToLocal.TabIndex = 21;
            // 
            // Column_CFtoLFCloudFile
            // 
            this.Column_CFtoLFCloudFile.HeaderText = "Cloud file";
            this.Column_CFtoLFCloudFile.Name = "Column_CFtoLFCloudFile";
            this.Column_CFtoLFCloudFile.ReadOnly = true;
            this.Column_CFtoLFCloudFile.Width = 450;
            // 
            // Column_CFtoLFLocalFile
            // 
            this.Column_CFtoLFLocalFile.HeaderText = "Local file path";
            this.Column_CFtoLFLocalFile.Name = "Column_CFtoLFLocalFile";
            this.Column_CFtoLFLocalFile.ReadOnly = true;
            this.Column_CFtoLFLocalFile.Width = 400;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(534, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "A cloud directory (represented by its path) gets mapped to a local file path (of " +
    "a directory).";
            // 
            // dataGridViewCloudDirectoryToLocal
            // 
            this.dataGridViewCloudDirectoryToLocal.AllowUserToAddRows = false;
            this.dataGridViewCloudDirectoryToLocal.AllowUserToDeleteRows = false;
            this.dataGridViewCloudDirectoryToLocal.AllowUserToResizeRows = false;
            this.dataGridViewCloudDirectoryToLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCloudDirectoryToLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_CDtoLDCloudDirectory,
            this.Column_CDtoLDLocalDirectory});
            this.dataGridViewCloudDirectoryToLocal.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewCloudDirectoryToLocal.MultiSelect = false;
            this.dataGridViewCloudDirectoryToLocal.Name = "dataGridViewCloudDirectoryToLocal";
            this.dataGridViewCloudDirectoryToLocal.ReadOnly = true;
            this.dataGridViewCloudDirectoryToLocal.RowHeadersVisible = false;
            this.dataGridViewCloudDirectoryToLocal.Size = new System.Drawing.Size(879, 150);
            this.dataGridViewCloudDirectoryToLocal.TabIndex = 23;
            // 
            // Column_CDtoLDCloudDirectory
            // 
            this.Column_CDtoLDCloudDirectory.HeaderText = "Cloud directory";
            this.Column_CDtoLDCloudDirectory.Name = "Column_CDtoLDCloudDirectory";
            this.Column_CDtoLDCloudDirectory.ReadOnly = true;
            this.Column_CDtoLDCloudDirectory.Width = 450;
            // 
            // Column_CDtoLDLocalDirectory
            // 
            this.Column_CDtoLDLocalDirectory.HeaderText = "Local file path (of a directory)";
            this.Column_CDtoLDLocalDirectory.Name = "Column_CDtoLDLocalDirectory";
            this.Column_CDtoLDLocalDirectory.ReadOnly = true;
            this.Column_CDtoLDLocalDirectory.Width = 400;
            // 
            // TestMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "TestMapping";
            this.Text = "TestMapping";
            this.Load += new System.EventHandler(this.TestMapping_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalFileToCloud)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalDirToCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCloudFileToLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCloudDirectoryToLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFdriveKenTestAzure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCloudPathCompanyAKenTestAzure;
        private System.Windows.Forms.RadioButton radioButtonCloudKenTestAzure;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton radioButtonFdriveMyTestProjectsKenTestAzure;
        private System.Windows.Forms.DataGridView dataGridViewLocalFileToCloud;
        private System.Windows.Forms.RadioButton radioButtonUncServer2KenTestAzure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LFtoCFLocalFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LFtoCFCloudFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewLocalDirToCloud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LDtoCDLocalDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LDtoCDCloudDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewCloudFileToLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CFtoLFCloudFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CFtoLFLocalFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewCloudDirectoryToLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CDtoLDCloudDirectory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CDtoLDLocalDirectory;
    }
}