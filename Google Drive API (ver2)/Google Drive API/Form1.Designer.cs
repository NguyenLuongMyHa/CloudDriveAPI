namespace Google_Drive_API
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
            this.lsv_ListFile = new System.Windows.Forms.ListView();
            this.btn_ThemFile = new System.Windows.Forms.Button();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbt_File = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_FolderName = new System.Windows.Forms.TextBox();
            this.lbl_FolderName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsv_ListFile
            // 
            this.lsv_ListFile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_ListFile.Location = new System.Drawing.Point(12, 188);
            this.lsv_ListFile.Margin = new System.Windows.Forms.Padding(6);
            this.lsv_ListFile.MultiSelect = false;
            this.lsv_ListFile.Name = "lsv_ListFile";
            this.lsv_ListFile.ShowItemToolTips = true;
            this.lsv_ListFile.Size = new System.Drawing.Size(709, 322);
            this.lsv_ListFile.TabIndex = 0;
            this.lsv_ListFile.UseCompatibleStateImageBehavior = false;
            this.lsv_ListFile.View = System.Windows.Forms.View.Details;
            this.lsv_ListFile.SelectedIndexChanged += new System.EventHandler(this.lsv_ListFile_SelectedIndexChanged);
            // 
            // btn_ThemFile
            // 
            this.btn_ThemFile.BackColor = System.Drawing.Color.Green;
            this.btn_ThemFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemFile.Location = new System.Drawing.Point(583, 522);
            this.btn_ThemFile.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ThemFile.Name = "btn_ThemFile";
            this.btn_ThemFile.Size = new System.Drawing.Size(138, 44);
            this.btn_ThemFile.TabIndex = 3;
            this.btn_ThemFile.Text = "Add File";
            this.btn_ThemFile.UseVisualStyleBackColor = false;
            this.btn_ThemFile.Click += new System.EventHandler(this.btn_ThemFile_Click);
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Location = new System.Drawing.Point(538, 147);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(77, 31);
            this.lbl_TrangThai.TabIndex = 4;
            this.lbl_TrangThai.Text = "Show";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(608, 145);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(113, 39);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "16110060 - Nguyen Luong My Ha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "16110095 - Le Ba Huynh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "16146172 - Nguyen Duy Phuoc";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(433, 522);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Folder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_ThemFolder_Click);
            // 
            // rbt_File
            // 
            this.rbt_File.AutoSize = true;
            this.rbt_File.Location = new System.Drawing.Point(543, 73);
            this.rbt_File.Name = "rbt_File";
            this.rbt_File.Size = new System.Drawing.Size(189, 35);
            this.rbt_File.TabIndex = 15;
            this.rbt_File.TabStop = true;
            this.rbt_File.Text = "Show List File";
            this.rbt_File.UseVisualStyleBackColor = true;
            this.rbt_File.CheckedChanged += new System.EventHandler(this.rbt_File_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(543, 105);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(222, 35);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show List Folder";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(653, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "GOOGLE DRIVE API";
            // 
            // txt_FolderName
            // 
            this.txt_FolderName.Location = new System.Drawing.Point(177, 529);
            this.txt_FolderName.Name = "txt_FolderName";
            this.txt_FolderName.Size = new System.Drawing.Size(247, 39);
            this.txt_FolderName.TabIndex = 19;
            // 
            // lbl_FolderName
            // 
            this.lbl_FolderName.AutoSize = true;
            this.lbl_FolderName.Location = new System.Drawing.Point(15, 532);
            this.lbl_FolderName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FolderName.Name = "lbl_FolderName";
            this.lbl_FolderName.Size = new System.Drawing.Size(162, 31);
            this.lbl_FolderName.TabIndex = 20;
            this.lbl_FolderName.Text = "Folder Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Google_Drive_API.Properties.Resources.drive;
            this.pictureBox1.Location = new System.Drawing.Point(15, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(736, 589);
            this.Controls.Add(this.lbl_FolderName);
            this.Controls.Add(this.txt_FolderName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbt_File);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_TrangThai);
            this.Controls.Add(this.btn_ThemFile);
            this.Controls.Add(this.lsv_ListFile);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Drive API";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsv_ListFile;
        private System.Windows.Forms.Button btn_ThemFile;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbt_File;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FolderName;
        private System.Windows.Forms.Label lbl_FolderName;
    }
}

