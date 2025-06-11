namespace KenTestAzureFileShareV2
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
            this.buttonTest1a = new System.Windows.Forms.Button();
            this.buttonTest1c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTest3a = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTest3c = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonTest1b = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonTest4a = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonTest2a = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonTest2b = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonTest3b = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTest4b = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxDiskDriveForTests = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTest1a
            // 
            this.buttonTest1a.Location = new System.Drawing.Point(39, 258);
            this.buttonTest1a.Name = "buttonTest1a";
            this.buttonTest1a.Size = new System.Drawing.Size(75, 23);
            this.buttonTest1a.TabIndex = 0;
            this.buttonTest1a.Text = "Test1a";
            this.buttonTest1a.UseVisualStyleBackColor = true;
            this.buttonTest1a.Click += new System.EventHandler(this.buttonTest1a_Click);
            // 
            // buttonTest1c
            // 
            this.buttonTest1c.Location = new System.Drawing.Point(39, 316);
            this.buttonTest1c.Name = "buttonTest1c";
            this.buttonTest1c.Size = new System.Drawing.Size(75, 23);
            this.buttonTest1c.TabIndex = 2;
            this.buttonTest1c.Text = "Test1c";
            this.buttonTest1c.UseVisualStyleBackColor = true;
            this.buttonTest1c.Click += new System.EventHandler(this.buttonTest1c_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upload local file ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upload bytearray (size greater than 4 MB)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test KenAzureFileShareLibrary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(624, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Microsoft Azure Storage Explorer is a useful tool for validating the results of t" +
    "hese tests!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add metadata to a file in the cloud";
            // 
            // buttonTest3a
            // 
            this.buttonTest3a.Location = new System.Drawing.Point(39, 483);
            this.buttonTest3a.Name = "buttonTest3a";
            this.buttonTest3a.Size = new System.Drawing.Size(75, 23);
            this.buttonTest3a.TabIndex = 7;
            this.buttonTest3a.Text = "Test3a";
            this.buttonTest3a.UseVisualStyleBackColor = true;
            this.buttonTest3a.Click += new System.EventHandler(this.buttonTest3a_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Key,
            this.Column_Value});
            this.dataGridView1.Location = new System.Drawing.Point(460, 469);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 118);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column_Key
            // 
            this.Column_Key.HeaderText = "Key";
            this.Column_Key.Name = "Column_Key";
            this.Column_Key.ReadOnly = true;
            // 
            // Column_Value
            // 
            this.Column_Value.HeaderText = "Value";
            this.Column_Value.Name = "Column_Value";
            this.Column_Value.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Current metatdata for file";
            // 
            // buttonTest3c
            // 
            this.buttonTest3c.Location = new System.Drawing.Point(39, 541);
            this.buttonTest3c.Name = "buttonTest3c";
            this.buttonTest3c.Size = new System.Drawing.Size(75, 23);
            this.buttonTest3c.TabIndex = 16;
            this.buttonTest3c.Text = "Test3c";
            this.buttonTest3c.UseVisualStyleBackColor = true;
            this.buttonTest3c.Click += new System.EventHandler(this.buttonTest3c_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Clear (purge) metadata for a file in the cloud";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Upload local file to file share root directory";
            // 
            // buttonTest1b
            // 
            this.buttonTest1b.Location = new System.Drawing.Point(39, 287);
            this.buttonTest1b.Name = "buttonTest1b";
            this.buttonTest1b.Size = new System.Drawing.Size(75, 23);
            this.buttonTest1b.TabIndex = 18;
            this.buttonTest1b.Text = "Test1b";
            this.buttonTest1b.UseVisualStyleBackColor = true;
            this.buttonTest1b.Click += new System.EventHandler(this.buttonTest1b_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 617);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Map local file path to a ShareFileClient";
            // 
            // buttonTest4a
            // 
            this.buttonTest4a.Location = new System.Drawing.Point(39, 614);
            this.buttonTest4a.Name = "buttonTest4a";
            this.buttonTest4a.Size = new System.Drawing.Size(75, 23);
            this.buttonTest4a.TabIndex = 20;
            this.buttonTest4a.Text = "Test4a";
            this.buttonTest4a.UseVisualStyleBackColor = true;
            this.buttonTest4a.Click += new System.EventHandler(this.buttonTest4aClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Download a cloud file to a local file path.";
            // 
            // buttonTest2a
            // 
            this.buttonTest2a.Location = new System.Drawing.Point(39, 381);
            this.buttonTest2a.Name = "buttonTest2a";
            this.buttonTest2a.Size = new System.Drawing.Size(75, 23);
            this.buttonTest2a.TabIndex = 24;
            this.buttonTest2a.Text = "Test2a";
            this.buttonTest2a.UseVisualStyleBackColor = true;
            this.buttonTest2a.Click += new System.EventHandler(this.buttonTest2a_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(120, 646);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Map a ShareFileClient to a local file path.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(120, 413);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(226, 16);
            this.label21.TabIndex = 41;
            this.label21.Text = "Download a cloud file to a byte array.";
            // 
            // buttonTest2b
            // 
            this.buttonTest2b.Location = new System.Drawing.Point(39, 410);
            this.buttonTest2b.Name = "buttonTest2b";
            this.buttonTest2b.Size = new System.Drawing.Size(75, 23);
            this.buttonTest2b.TabIndex = 40;
            this.buttonTest2b.Text = "Test2b";
            this.buttonTest2b.UseVisualStyleBackColor = true;
            this.buttonTest2b.Click += new System.EventHandler(this.buttonTest2b_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(120, 515);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(324, 16);
            this.label22.TabIndex = 43;
            this.label22.Text = "Remove an item in the metatdata for a file in the cloud.";
            // 
            // buttonTest3b
            // 
            this.buttonTest3b.Location = new System.Drawing.Point(39, 512);
            this.buttonTest3b.Name = "buttonTest3b";
            this.buttonTest3b.Size = new System.Drawing.Size(75, 23);
            this.buttonTest3b.TabIndex = 42;
            this.buttonTest3b.Text = "Test3b";
            this.buttonTest3b.UseVisualStyleBackColor = true;
            this.buttonTest3b.Click += new System.EventHandler(this.buttonTest3b_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(119, 230);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 20);
            this.label23.TabIndex = 44;
            this.label23.Text = "Upload tests";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(119, 353);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 20);
            this.label24.TabIndex = 45;
            this.label24.Text = "Download tests";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(119, 452);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 20);
            this.label25.TabIndex = 46;
            this.label25.Text = "Metadata tests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Mapping tests";
            // 
            // buttonTest4b
            // 
            this.buttonTest4b.Location = new System.Drawing.Point(39, 643);
            this.buttonTest4b.Name = "buttonTest4b";
            this.buttonTest4b.Size = new System.Drawing.Size(75, 23);
            this.buttonTest4b.TabIndex = 48;
            this.buttonTest4b.Text = "Test4b";
            this.buttonTest4b.UseVisualStyleBackColor = true;
            this.buttonTest4b.Click += new System.EventHandler(this.buttonTest4b_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(54, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(600, 60);
            this.label7.TabIndex = 49;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(109, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Desired disk drive for tests:";
            // 
            // comboBoxDiskDriveForTests
            // 
            this.comboBoxDiskDriveForTests.FormattingEnabled = true;
            this.comboBoxDiskDriveForTests.Items.AddRange(new object[] {
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:",
            "J:"});
            this.comboBoxDiskDriveForTests.Location = new System.Drawing.Point(247, 179);
            this.comboBoxDiskDriveForTests.Name = "comboBoxDiskDriveForTests";
            this.comboBoxDiskDriveForTests.Size = new System.Drawing.Size(66, 21);
            this.comboBoxDiskDriveForTests.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkViolet;
            this.label15.Location = new System.Drawing.Point(54, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(512, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Setup: Modify Form1.cs to specify your_AzureStorageConnectionString";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 701);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxDiskDriveForTests);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonTest4b);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.buttonTest3b);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonTest2b);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonTest2a);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonTest4a);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonTest1b);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonTest3c);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonTest3a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTest1c);
            this.Controls.Add(this.buttonTest1a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTest1a;
        private System.Windows.Forms.Button buttonTest1c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTest3a;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Value;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTest3c;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonTest1b;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonTest4a;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonTest2a;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonTest2b;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonTest3b;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTest4b;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxDiskDriveForTests;
        private System.Windows.Forms.Label label15;
    }
}

