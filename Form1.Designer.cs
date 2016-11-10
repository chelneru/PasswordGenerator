namespace PassWordGenerator
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
            this.GeneratedPassword = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.inputLengthValue = new System.Windows.Forms.TextBox();
            this.lengthError = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.charTypeError = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.showAdvOp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileGenerate = new System.Windows.Forms.CheckBox();
            this.inputFile = new System.Windows.Forms.Button();
            this.numberPasswordsLabel = new System.Windows.Forms.Label();
            this.inputNumberPasswords = new System.Windows.Forms.TextBox();
            this.countError = new System.Windows.Forms.Label();
            this.fileError = new System.Windows.Forms.Label();
            this.outputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GeneratedPassword
            // 
            this.GeneratedPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratedPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GeneratedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratedPassword.HideSelection = false;
            this.GeneratedPassword.Location = new System.Drawing.Point(12, 24);
            this.GeneratedPassword.MaxLength = 100000;
            this.GeneratedPassword.Multiline = true;
            this.GeneratedPassword.Name = "GeneratedPassword";
            this.GeneratedPassword.ReadOnly = true;
            this.GeneratedPassword.Size = new System.Drawing.Size(664, 59);
            this.GeneratedPassword.TabIndex = 1;
            this.GeneratedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(408, 89);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(118, 23);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate Password";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 141);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(89, 13);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "Password Length";
            this.lengthLabel.Visible = false;
            // 
            // inputLengthValue
            // 
            this.inputLengthValue.Location = new System.Drawing.Point(107, 138);
            this.inputLengthValue.Name = "inputLengthValue";
            this.inputLengthValue.Size = new System.Drawing.Size(100, 20);
            this.inputLengthValue.TabIndex = 7;
            this.inputLengthValue.Visible = false;
            // 
            // lengthError
            // 
            this.lengthError.AutoSize = true;
            this.lengthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthError.ForeColor = System.Drawing.Color.Red;
            this.lengthError.Location = new System.Drawing.Point(218, 142);
            this.lengthError.Name = "lengthError";
            this.lengthError.Size = new System.Drawing.Size(95, 16);
            this.lengthError.TabIndex = 8;
            this.lengthError.Text = "Invalid number";
            this.lengthError.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Contains letters",
            "Contains Digits",
            "Contains Symbols"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 167);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 45);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.Visible = false;
            // 
            // charTypeError
            // 
            this.charTypeError.AutoSize = true;
            this.charTypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charTypeError.ForeColor = System.Drawing.Color.Red;
            this.charTypeError.Location = new System.Drawing.Point(138, 178);
            this.charTypeError.Name = "charTypeError";
            this.charTypeError.Size = new System.Drawing.Size(189, 16);
            this.charTypeError.TabIndex = 11;
            this.charTypeError.Text = "Error, choose at least one type";
            this.charTypeError.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(275, 326);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(126, 13);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // showAdvOp
            // 
            this.showAdvOp.Location = new System.Drawing.Point(107, 89);
            this.showAdvOp.Name = "showAdvOp";
            this.showAdvOp.Size = new System.Drawing.Size(144, 23);
            this.showAdvOp.TabIndex = 13;
            this.showAdvOp.Text = "Show Advanced options";
            this.showAdvOp.UseVisualStyleBackColor = true;
            this.showAdvOp.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Copy to clipboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileGenerate
            // 
            this.fileGenerate.AutoSize = true;
            this.fileGenerate.Location = new System.Drawing.Point(12, 218);
            this.fileGenerate.Name = "fileGenerate";
            this.fileGenerate.Size = new System.Drawing.Size(159, 17);
            this.fileGenerate.TabIndex = 15;
            this.fileGenerate.Text = "Generate passwords in a file";
            this.fileGenerate.UseVisualStyleBackColor = true;
            this.fileGenerate.CheckedChanged += new System.EventHandler(this.fileGenerate_CheckedChanged);
            // 
            // inputFile
            // 
            this.inputFile.Location = new System.Drawing.Point(12, 252);
            this.inputFile.Name = "inputFile";
            this.inputFile.Size = new System.Drawing.Size(75, 23);
            this.inputFile.TabIndex = 16;
            this.inputFile.Text = "Select folder... ";
            this.inputFile.UseVisualStyleBackColor = true;
            this.inputFile.Visible = false;
            this.inputFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // numberPasswordsLabel
            // 
            this.numberPasswordsLabel.AutoSize = true;
            this.numberPasswordsLabel.Location = new System.Drawing.Point(12, 287);
            this.numberPasswordsLabel.Name = "numberPasswordsLabel";
            this.numberPasswordsLabel.Size = new System.Drawing.Size(169, 13);
            this.numberPasswordsLabel.TabIndex = 18;
            this.numberPasswordsLabel.Text = "Number of passwords to generate:";
            this.numberPasswordsLabel.Visible = false;
            // 
            // inputNumberPasswords
            // 
            this.inputNumberPasswords.Location = new System.Drawing.Point(15, 309);
            this.inputNumberPasswords.Name = "inputNumberPasswords";
            this.inputNumberPasswords.Size = new System.Drawing.Size(100, 20);
            this.inputNumberPasswords.TabIndex = 19;
            this.inputNumberPasswords.Visible = false;
            // 
            // countError
            // 
            this.countError.AutoSize = true;
            this.countError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countError.ForeColor = System.Drawing.Color.Red;
            this.countError.Location = new System.Drawing.Point(122, 309);
            this.countError.Name = "countError";
            this.countError.Size = new System.Drawing.Size(95, 16);
            this.countError.TabIndex = 20;
            this.countError.Text = "Invalid number";
            this.countError.Visible = false;
            // 
            // fileError
            // 
            this.fileError.AutoSize = true;
            this.fileError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileError.ForeColor = System.Drawing.Color.Red;
            this.fileError.Location = new System.Drawing.Point(218, 255);
            this.fileError.Name = "fileError";
            this.fileError.Size = new System.Drawing.Size(76, 16);
            this.fileError.TabIndex = 21;
            this.fileError.Text = "Invalid path";
            this.fileError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(294, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileError);
            this.Controls.Add(this.countError);
            this.Controls.Add(this.inputNumberPasswords);
            this.Controls.Add(this.numberPasswordsLabel);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.fileGenerate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showAdvOp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.charTypeError);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lengthError);
            this.Controls.Add(this.inputLengthValue);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.GeneratedPassword);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GeneratedPassword;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox inputLengthValue;
        private System.Windows.Forms.Label lengthError;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label charTypeError;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button showAdvOp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox fileGenerate;
        private System.Windows.Forms.Button inputFile;
        private System.Windows.Forms.Label numberPasswordsLabel;
        private System.Windows.Forms.TextBox inputNumberPasswords;
        private System.Windows.Forms.Label countError;
        private System.Windows.Forms.Label fileError;
        private System.Windows.Forms.FolderBrowserDialog outputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

