namespace FileInputOutput
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
            this.FolderButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.lblPid = new System.Windows.Forms.Label();
            this.labpname = new System.Windows.Forms.Label();
            this.labpprice = new System.Windows.Forms.Label();
            this.textpid = new System.Windows.Forms.TextBox();
            this.textpname = new System.Windows.Forms.TextBox();
            this.textpprice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(171, 23);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(103, 45);
            this.FolderButton.TabIndex = 0;
            this.FolderButton.Text = "Create Folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(357, 23);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(102, 45);
            this.FileButton.TabIndex = 1;
            this.FileButton.Text = "Create File";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(210, 167);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(64, 16);
            this.lblPid.TabIndex = 2;
            this.lblPid.Text = "ProductId";
            // 
            // labpname
            // 
            this.labpname.AutoSize = true;
            this.labpname.Location = new System.Drawing.Point(210, 223);
            this.labpname.Name = "labpname";
            this.labpname.Size = new System.Drawing.Size(90, 16);
            this.labpname.TabIndex = 3;
            this.labpname.Text = "ProductName";
            this.labpname.Click += new System.EventHandler(this.label2_Click);
            // 
            // labpprice
            // 
            this.labpprice.AutoSize = true;
            this.labpprice.Location = new System.Drawing.Point(210, 276);
            this.labpprice.Name = "labpprice";
            this.labpprice.Size = new System.Drawing.Size(84, 16);
            this.labpprice.TabIndex = 4;
            this.labpprice.Text = "ProductPrice";
            // 
            // textpid
            // 
            this.textpid.Location = new System.Drawing.Point(331, 161);
            this.textpid.Name = "textpid";
            this.textpid.Size = new System.Drawing.Size(115, 22);
            this.textpid.TabIndex = 5;
            // 
            // textpname
            // 
            this.textpname.Location = new System.Drawing.Point(331, 217);
            this.textpname.Name = "textpname";
            this.textpname.Size = new System.Drawing.Size(115, 22);
            this.textpname.TabIndex = 6;
            // 
            // textpprice
            // 
            this.textpprice.Location = new System.Drawing.Point(331, 273);
            this.textpprice.Name = "textpprice";
            this.textpprice.Size = new System.Drawing.Size(115, 22);
            this.textpprice.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "write to file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textpprice);
            this.Controls.Add(this.textpname);
            this.Controls.Add(this.textpid);
            this.Controls.Add(this.labpprice);
            this.Controls.Add(this.labpname);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.FolderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Label labpname;
        private System.Windows.Forms.Label labpprice;
        private System.Windows.Forms.TextBox textpid;
        private System.Windows.Forms.TextBox textpname;
        private System.Windows.Forms.TextBox textpprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

