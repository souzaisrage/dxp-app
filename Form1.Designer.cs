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
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnDeleteTempAndPrefetch = new System.Windows.Forms.Button();
            this.btnCleanWindowsUpdates = new System.Windows.Forms.Button();
            this.btnCleanRecycleBin = new System.Windows.Forms.Button();
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
            this.installBtn.Location = new System.Drawing.Point(807, 12);
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
            this.listBoxDrivers.Location = new System.Drawing.Point(338, 41);
            this.listBoxDrivers.Name = "listBoxDrivers";
            this.listBoxDrivers.Size = new System.Drawing.Size(568, 251);
            this.listBoxDrivers.TabIndex = 8;
            // 
            // hardwareList
            // 
            this.hardwareList.FormattingEnabled = true;
            this.hardwareList.Location = new System.Drawing.Point(12, 41);
            this.hardwareList.Name = "hardwareList";
            this.hardwareList.Size = new System.Drawing.Size(320, 537);
            this.hardwareList.TabIndex = 9;
            // 
            // listBoxDriversUpdate
            // 
            this.listBoxDriversUpdate.FormattingEnabled = true;
            this.listBoxDriversUpdate.Location = new System.Drawing.Point(338, 302);
            this.listBoxDriversUpdate.Name = "listBoxDriversUpdate";
            this.listBoxDriversUpdate.Size = new System.Drawing.Size(568, 277);
            this.listBoxDriversUpdate.TabIndex = 10;
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewLogs.Location = new System.Drawing.Point(756, 585);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(150, 23);
            this.btnViewLogs.TabIndex = 11;
            this.btnViewLogs.Text = "View Logs";
            this.btnViewLogs.UseVisualStyleBackColor = false;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnDeleteTempAndPrefetch
            // 
            this.btnDeleteTempAndPrefetch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteTempAndPrefetch.Location = new System.Drawing.Point(528, 585);
            this.btnDeleteTempAndPrefetch.Name = "btnDeleteTempAndPrefetch";
            this.btnDeleteTempAndPrefetch.Size = new System.Drawing.Size(212, 23);
            this.btnDeleteTempAndPrefetch.TabIndex = 12;
            this.btnDeleteTempAndPrefetch.Text = "Delete Temp and Prefetch";
            this.btnDeleteTempAndPrefetch.UseVisualStyleBackColor = false;
            this.btnDeleteTempAndPrefetch.Click += new System.EventHandler(this.btnDeleteTempAndPrefetch_Click);
            // 
            // btnCleanWindowsUpdates
            // 
            this.btnCleanWindowsUpdates.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCleanWindowsUpdates.Location = new System.Drawing.Point(300, 585);
            this.btnCleanWindowsUpdates.Name = "btnCleanWindowsUpdates";
            this.btnCleanWindowsUpdates.Size = new System.Drawing.Size(212, 23);
            this.btnCleanWindowsUpdates.TabIndex = 13;
            this.btnCleanWindowsUpdates.Text = "Delete Unused Windows Updates";
            this.btnCleanWindowsUpdates.UseVisualStyleBackColor = false;
            this.btnCleanWindowsUpdates.Click += new System.EventHandler(this.btnCleanWindowsUpdates_Click);
            // 
            // btnCleanRecycleBin
            // 
            this.btnCleanRecycleBin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCleanRecycleBin.Location = new System.Drawing.Point(131, 585);
            this.btnCleanRecycleBin.Name = "btnCleanRecycleBin";
            this.btnCleanRecycleBin.Size = new System.Drawing.Size(150, 23);
            this.btnCleanRecycleBin.TabIndex = 14;
            this.btnCleanRecycleBin.Text = "Clean Recycle Bin";
            this.btnCleanRecycleBin.UseVisualStyleBackColor = false;
            this.btnCleanRecycleBin.Click += new System.EventHandler(this.btnCleanRecycleBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 610);
            this.Controls.Add(this.btnCleanRecycleBin);
            this.Controls.Add(this.btnCleanWindowsUpdates);
            this.Controls.Add(this.btnDeleteTempAndPrefetch);
            this.Controls.Add(this.btnViewLogs);
            this.Controls.Add(this.listBoxDriversUpdate);
            this.Controls.Add(this.hardwareList);
            this.Controls.Add(this.listBoxDrivers);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.checkUpdatesbtn);
            this.Controls.Add(this.installedDriversbtn);
            this.Controls.Add(this.detecthardwarebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverXpress";
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
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnDeleteTempAndPrefetch;
        private System.Windows.Forms.Button btnCleanWindowsUpdates;
        private System.Windows.Forms.Button btnCleanRecycleBin;
    }
}

