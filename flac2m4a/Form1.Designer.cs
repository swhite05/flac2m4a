namespace flac2m4a
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnInputFolder = new Button();
            txtInputPath = new TextBox();
            txtOutputPath = new TextBox();
            btnOutputFolder = new Button();
            btnConvert = new Button();
            fbdInputPath = new FolderBrowserDialog();
            fbdOutputPath = new FolderBrowserDialog();
            prgConversion = new ProgressBar();
            chkGenDirectory = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 67);
            label1.TabIndex = 0;
            label1.Text = "flac2m4a";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInputFolder
            // 
            btnInputFolder.Location = new Point(28, 94);
            btnInputFolder.Name = "btnInputFolder";
            btnInputFolder.Size = new Size(144, 38);
            btnInputFolder.TabIndex = 1;
            btnInputFolder.Text = "Choose input folder";
            btnInputFolder.UseVisualStyleBackColor = true;
            btnInputFolder.Click += btnInputFolder_Click;
            // 
            // txtInputPath
            // 
            txtInputPath.Location = new Point(28, 138);
            txtInputPath.Name = "txtInputPath";
            txtInputPath.Size = new Size(387, 23);
            txtInputPath.TabIndex = 2;
            // 
            // txtOutputPath
            // 
            txtOutputPath.Location = new Point(28, 220);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(387, 23);
            txtOutputPath.TabIndex = 4;
            // 
            // btnOutputFolder
            // 
            btnOutputFolder.Location = new Point(28, 176);
            btnOutputFolder.Name = "btnOutputFolder";
            btnOutputFolder.Size = new Size(144, 38);
            btnOutputFolder.TabIndex = 3;
            btnOutputFolder.Text = "Choose output folder";
            btnOutputFolder.UseVisualStyleBackColor = true;
            btnOutputFolder.Click += btnOutputFolder_Click;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(120, 306);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(202, 52);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // fbdInputPath
            // 
            fbdInputPath.Description = "Find a folder with .flac files to convert";
            fbdInputPath.UseDescriptionForTitle = true;
            // 
            // fbdOutputPath
            // 
            fbdOutputPath.Description = "Find a folder to put .m4a files in";
            fbdOutputPath.UseDescriptionForTitle = true;
            // 
            // prgConversion
            // 
            prgConversion.Location = new Point(28, 266);
            prgConversion.Name = "prgConversion";
            prgConversion.Size = new Size(387, 23);
            prgConversion.TabIndex = 6;
            // 
            // chkGenDirectory
            // 
            chkGenDirectory.AutoSize = true;
            chkGenDirectory.Location = new Point(178, 187);
            chkGenDirectory.Name = "chkGenDirectory";
            chkGenDirectory.Size = new Size(123, 19);
            chkGenDirectory.TabIndex = 7;
            chkGenDirectory.Text = "Generate directory";
            chkGenDirectory.UseVisualStyleBackColor = true;
            chkGenDirectory.CheckedChanged += chkGenDirectory_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 370);
            Controls.Add(chkGenDirectory);
            Controls.Add(prgConversion);
            Controls.Add(btnConvert);
            Controls.Add(txtOutputPath);
            Controls.Add(btnOutputFolder);
            Controls.Add(txtInputPath);
            Controls.Add(btnInputFolder);
            Controls.Add(label1);
            Name = "Form1";
            Text = "flac2m4a";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInputFolder;
        private TextBox txtInputPath;
        private TextBox txtOutputPath;
        private Button btnOutputFolder;
        private Button btnConvert;
        private FolderBrowserDialog fbdInputPath;
        private FolderBrowserDialog fbdOutputPath;
        private ProgressBar prgConversion;
        private CheckBox chkGenDirectory;
    }
}