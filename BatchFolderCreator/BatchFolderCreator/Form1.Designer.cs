namespace BatchFolderCreator
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.rbFiles = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblFormatHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 90);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(53, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.MaxLength = 15;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(15, 64);
            this.txtCount.MaxLength = 4;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 3;
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Checked = true;
            this.rbFolder.Location = new System.Drawing.Point(134, 27);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(59, 17);
            this.rbFolder.TabIndex = 5;
            this.rbFolder.TabStop = true;
            this.rbFolder.Text = "Folders";
            this.rbFolder.UseVisualStyleBackColor = true;
            this.rbFolder.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbFiles
            // 
            this.rbFiles.AutoSize = true;
            this.rbFiles.Location = new System.Drawing.Point(134, 48);
            this.rbFiles.Name = "rbFiles";
            this.rbFiles.Size = new System.Drawing.Size(46, 17);
            this.rbFiles.TabIndex = 6;
            this.rbFiles.Text = "Files";
            this.rbFiles.UseVisualStyleBackColor = true;
            this.rbFiles.CheckedChanged += new System.EventHandler(this.rbFiles_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(74, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Custom Formatting";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblFormatHelp
            // 
            this.lblFormatHelp.AutoSize = true;
            this.lblFormatHelp.Location = new System.Drawing.Point(180, 90);
            this.lblFormatHelp.Name = "lblFormatHelp";
            this.lblFormatHelp.Size = new System.Drawing.Size(13, 13);
            this.lblFormatHelp.TabIndex = 8;
            this.lblFormatHelp.TabStop = true;
            this.lblFormatHelp.Text = "?";
            this.lblFormatHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFormatHelp_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 129);
            this.Controls.Add(this.lblFormatHelp);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbFiles);
            this.Controls.Add(this.rbFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Folders!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.RadioButton rbFiles;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel lblFormatHelp;
    }
}

