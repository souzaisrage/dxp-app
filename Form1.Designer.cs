namespace dxpapp
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
            this.detecthardwarebtn = new System.Windows.Forms.Button();
            this.installedDriversbtn = new System.Windows.Forms.Button();
            this.checkUpdatesbtn = new System.Windows.Forms.Button();
            this.installBtn = new System.Windows.Forms.Button();
            this.listBoxDrivers = new System.Windows.Forms.ListBox();
            this.hardwareList = new System.Windows.Forms.ListBox();
            this.listBoxDriversUpdate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // detecthardwarebtn
            // 
            this.detecthardwarebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.detecthardwarebtn.Location = new System.Drawing.Point(12, 12);
            this.detecthardwarebtn.Name = "detecthardwarebtn";
            this.detecthardwarebtn.Size = new System.Drawing.Size(150, 23);
            this.detecthardwarebtn.TabIndex = 2;
            this.detecthardwarebtn.Text = "Detect Hardware";
            this.detecthardwarebtn.UseVisualStyleBackColor = false;
            this.detecthardwarebtn.Click += new System.EventHandler(this.detecthardwarebtn_Click);
            // 
            // installedDriversbtn
            // 
            this.installedDriversbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.installedDriversbtn.Location = new System.Drawing.Point(198, 12);
            this.installedDriversbtn.Name = "installedDriversbtn";
            this.installedDriversbtn.Size = new System.Drawing.Size(150, 23);
            this.installedDriversbtn.TabIndex = 3;
            this.installedDriversbtn.Text = "Show Installed Drivers";
            this.installedDriversbtn.UseVisualStyleBackColor = false;
            this.installedDriversbtn.Click += new System.EventHandler(this.installedDriversbtn_Click);
            // 
            // checkUpdatesbtn
            // 
            this.checkUpdatesbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkUpdatesbtn.Location = new System.Drawing.Point(381, 12);
            this.checkUpdatesbtn.Name = "checkUpdatesbtn";
            this.checkUpdatesbtn.Size = new System.Drawing.Size(150, 23);
            this.checkUpdatesbtn.TabIndex = 4;
            this.checkUpdatesbtn.Text = "Check for Updates";
            this.checkUpdatesbtn.UseVisualStyleBackColor = false;
            this.checkUpdatesbtn.Click += new System.EventHandler(this.checkUpdatesbtn_Click);
            // 
            // installBtn
            // 
            this.installBtn.Location = new System.Drawing.Point(823, 12);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(99, 23);
            this.installBtn.TabIndex = 6;
            this.installBtn.Text = "Install Update";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // listBoxDrivers
            // 
            this.listBoxDrivers.FormattingEnabled = true;
            this.listBoxDrivers.Location = new System.Drawing.Point(457, 41);
            this.listBoxDrivers.Name = "listBoxDrivers";
            this.listBoxDrivers.Size = new System.Drawing.Size(465, 251);
            this.listBoxDrivers.TabIndex = 8;
            // 
            // hardwareList
            // 
            this.hardwareList.FormattingEnabled = true;
            this.hardwareList.Location = new System.Drawing.Point(28, 41);
            this.hardwareList.Name = "hardwareList";
            this.hardwareList.Size = new System.Drawing.Size(320, 537);
            this.hardwareList.TabIndex = 9;
            // 
            // listBoxDriversUpdate
            // 
            this.listBoxDriversUpdate.FormattingEnabled = true;
            this.listBoxDriversUpdate.Location = new System.Drawing.Point(457, 311);
            this.listBoxDriversUpdate.Name = "listBoxDriversUpdate";
            this.listBoxDriversUpdate.Size = new System.Drawing.Size(465, 277);
            this.listBoxDriversUpdate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 618);
            this.Controls.Add(this.listBoxDriversUpdate);
            this.Controls.Add(this.hardwareList);
            this.Controls.Add(this.listBoxDrivers);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.checkUpdatesbtn);
            this.Controls.Add(this.installedDriversbtn);
            this.Controls.Add(this.detecthardwarebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DXP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button detecthardwarebtn;
        private System.Windows.Forms.Button installedDriversbtn;
        private System.Windows.Forms.Button checkUpdatesbtn;
        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.ListBox listBoxDrivers;
        private System.Windows.Forms.ListBox hardwareList;
        private System.Windows.Forms.ListBox listBoxDriversUpdate;
    }
}

