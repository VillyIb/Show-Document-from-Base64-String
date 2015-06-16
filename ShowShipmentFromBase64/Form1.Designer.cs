namespace ShowShipmentFromBase64
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
            this.XuExecute = new System.Windows.Forms.Button();
            this.XuClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.XuDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XuFilename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // XuExecute
            // 
            this.XuExecute.Location = new System.Drawing.Point(494, 285);
            this.XuExecute.Name = "XuExecute";
            this.XuExecute.Size = new System.Drawing.Size(75, 23);
            this.XuExecute.TabIndex = 0;
            this.XuExecute.Text = "Execute";
            this.XuExecute.UseVisualStyleBackColor = true;
            this.XuExecute.Click += new System.EventHandler(this.XuExecute_Click);
            // 
            // XuClose
            // 
            this.XuClose.Location = new System.Drawing.Point(494, 336);
            this.XuClose.Name = "XuClose";
            this.XuClose.Size = new System.Drawing.Size(75, 23);
            this.XuClose.TabIndex = 1;
            this.XuClose.Text = "Close";
            this.XuClose.UseVisualStyleBackColor = true;
            this.XuClose.Click += new System.EventHandler(this.XuClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kopier tekst til clipboard og tryk på Execute";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Åben fil i Explorer (filer)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XuDirectory
            // 
            this.XuDirectory.Location = new System.Drawing.Point(34, 121);
            this.XuDirectory.Name = "XuDirectory";
            this.XuDirectory.Size = new System.Drawing.Size(435, 20);
            this.XuDirectory.TabIndex = 5;
            this.XuDirectory.Text = "Vælg directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filplacering";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filnavn (uden extension)";
            // 
            // XuFilename
            // 
            this.XuFilename.Location = new System.Drawing.Point(34, 183);
            this.XuFilename.Name = "XuFilename";
            this.XuFilename.Size = new System.Drawing.Size(435, 20);
            this.XuFilename.TabIndex = 7;
            this.XuFilename.Text = "Angiv Filnavn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.XuFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XuDirectory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XuClose);
            this.Controls.Add(this.XuExecute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XuExecute;
        private System.Windows.Forms.Button XuClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox XuDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox XuFilename;
    }
}

