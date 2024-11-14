using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WUApiLib;
using System.Management;
using System.Threading;
using System.Diagnostics;

namespace dxpapp
{
    public partial class Form1 : Form
    {
        private string pcName = Environment.MachineName;
        public Form1()
        {
            InitializeComponent();
            installBtn.Enabled = true;
        }

        private void DetectInstalledDrivers()
        {

            listBoxDrivers.Items.Clear(); // Clear any previous items in the ListBox

            var driverSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPSignedDriver");

            // Add header text (you can choose to leave this out or modify the format)
            listBoxDrivers.Items.Add("Installed Drivers:");
            listBoxDrivers.Items.Add("========================================");

            // Loop through each driver and add its info to the ListBox
            foreach (ManagementObject driver in driverSearcher.Get())
            {
                listBoxDrivers.Items.Add("Device Name: " + driver["DeviceName"]);
                listBoxDrivers.Items.Add("Driver Version: " + driver["DriverVersion"]);
                listBoxDrivers.Items.Add("Manufacturer: " + driver["Manufacturer"]);
                listBoxDrivers.Items.Add("Driver Date: " + driver["DriverDate"]);
                listBoxDrivers.Items.Add("Driver Description: " + driver["Description"]);
                listBoxDrivers.Items.Add("----------------------------------------");
            }
        }

        public void GetHardwareInfo()
        {
            hardwareList.Items.Clear();

            // CPU Information
            var cpuInfo = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (var item in cpuInfo.Get())
            {
                hardwareList.Items.Add("CPU Name: " + item["Name"]);
                hardwareList.Items.Add("CPU Cores: " + item["NumberOfCores"]);
                hardwareList.Items.Add("CPU Speed: " + item["CurrentClockSpeed"] + " MHz");
                hardwareList.Items.Add("CPU Manufacturer: " + item["Manufacturer"]);
                hardwareList.Items.Add("-----------------//------------------");
            }

            // GPU Information
            var gpuInfo = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (var item in gpuInfo.Get())
            {
                hardwareList.Items.Add("GPU Name: " + item["Name"]);
                hardwareList.Items.Add("GPU Manufacturer: " + item["AdapterCompatibility"]);
                hardwareList.Items.Add("GPU Video RAM: " + Convert.ToInt64(item["AdapterRAM"]) / (1024 * 1024) + " MB"); // Video RAM in MB
                hardwareList.Items.Add("GPU Driver Version: " + item["DriverVersion"]);
                hardwareList.Items.Add("-----------------//------------------");
            }

            // RAM Information
            var ramInfo = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (var item in ramInfo.Get())
            {
                var ramSize = Convert.ToInt64(item["Capacity"]) / (1024 * 1024 * 1024); // Convert bytes to GB
                hardwareList.Items.Add("RAM Size: " + ramSize + " GB");
                hardwareList.Items.Add("RAM Manufacturer: " + item["Manufacturer"]);
                hardwareList.Items.Add("RAM Speed: " + item["Speed"] + " MHz");
                hardwareList.Items.Add("RAM Type: " + item["MemoryType"]);
                hardwareList.Items.Add("-----------------//------------------");
            }

            // Disk Drive Information
            var diskInfo = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (var item in diskInfo.Get())
            {
                hardwareList.Items.Add("Disk Model: " + item["Model"]);
                hardwareList.Items.Add("Disk Size: " + (Convert.ToInt64(item["Size"]) / (1024 * 1024 * 1024)) + " GB");
                hardwareList.Items.Add("Disk Type: " + item["MediaType"]);
                hardwareList.Items.Add("-----------------//------------------");
            }

            // Motherboard Information
            var motherboardInfo = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (var item in motherboardInfo.Get())
            {
                hardwareList.Items.Add("Motherboard Model: " + item["Product"]);
                hardwareList.Items.Add("Motherboard Manufacturer: " + item["Manufacturer"]);
                hardwareList.Items.Add("Motherboard Serial Number: " + item["SerialNumber"]);
                hardwareList.Items.Add("-----------------//------------------");
            }
            // Operating System Information
            var osInfo = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (var item in osInfo.Get())
            {
                hardwareList.Items.Add("Operating System: " + item["Caption"]);
                hardwareList.Items.Add("OS Architecture: " + item["OSArchitecture"]);
                hardwareList.Items.Add("OS Version: " + item["Version"]);
                hardwareList.Items.Add("OS Build: " + item["BuildNumber"]);
                hardwareList.Items.Add("OS Manufacturer: " + item["Manufacturer"]);
                hardwareList.Items.Add("-----------------//------------------");
            }

            // Battery Information (if applicable)
            var batteryInfo = new ManagementObjectSearcher("SELECT * FROM Win32_Battery");
            foreach (var item in batteryInfo.Get())
            {
                hardwareList.Items.Add("Battery Status: " + item["BatteryStatus"]);
                hardwareList.Items.Add("Battery Estimated Charge Remaining: " + item["EstimatedChargeRemaining"] + "%");
                //hardwareList.Items.Add("Battery Manufacturer: " + item["Manufacturer"]);
                hardwareList.Items.Add("-----------------//------------------");
            }
        }

        private void CheckForDriverUpdates()
        {
            try
            {
                UpdateSession updateSession = new UpdateSession();
                IUpdateSearcher updateSearcher = updateSession.CreateUpdateSearcher();

                // Search for driver updates
                IUpdateCollection driverUpdates = updateSearcher.Search("IsInstalled=0 and Type='Driver'").Updates;

                // Search for Windows updates
                IUpdateCollection windowsUpdates = updateSearcher.Search("IsInstalled=0 and Type='Software'").Updates;

                // Invoke UI changes to the main thread
                this.Invoke((Action)(() =>
                {
                    listBoxDriversUpdate.Items.Clear();  // Clear the list before adding new data


                    // Show driver updates if found
                    if (driverUpdates.Count > 0)
                    {
                        listBoxDriversUpdate.Items.Add("Driver Updates Found:");
                        listBoxDriversUpdate.Items.Add("========================================");

                        foreach (IUpdate update in driverUpdates)
                        {
                            listBoxDriversUpdate.Items.Add("Driver Update Found: " + update.Title);
                            listBoxDriversUpdate.Items.Add("Update ID: " + update.Identity.UpdateID);  // Display Update ID
                            listBoxDriversUpdate.Items.Add("Description: " + update.Description);
                            listBoxDriversUpdate.Items.Add("----------------------------------------");
                        }
                    }
                    else
                    {
                        listBoxDriversUpdate.Items.Add("No driver updates found.");
                    }

                    // Show Windows updates if found
                    if (windowsUpdates.Count > 0)
                    {
                        listBoxDriversUpdate.Items.Add("Windows Updates Found:");
                        listBoxDriversUpdate.Items.Add("========================================");

                        foreach (IUpdate update in windowsUpdates)
                        {
                            listBoxDriversUpdate.Items.Add("Windows Update Found: " + update.Title);
                            //listBoxDriversUpdate.Items.Add("Update ID: " + update.Identity.UpdateID);  // Display Update ID
                            listBoxDriversUpdate.Items.Add("Description: " + update.Description);
                            listBoxDriversUpdate.Items.Add("----------------------------------------");
                        }
                    }
                    else
                    {
                        listBoxDriversUpdate.Items.Add("No Windows updates found.");
                    }

                    checkUpdatesbtn.Enabled = true;
                    checkUpdatesbtn.Text = "Check for Updates";
                }));
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    MessageBox.Show("Error checking for updates: " + ex.Message);
                    checkUpdatesbtn.Enabled = true;
                    checkUpdatesbtn.Text = "Check for Updates";
                }));
            }
        }

        private void restartpc()
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = "cmd";
            proc.Arguments = "/C shutdown /s";
            Process.Start(proc);
        }

        private string ExtractUpdateID(string selectedText)
        {
            // Assuming the Update ID appears as "Update ID: <id>" in the list text
            string marker = "Update ID: ";
            int startIndex = selectedText.IndexOf(marker);
            if (startIndex >= 0)
            {
                startIndex += marker.Length;
                int endIndex = selectedText.IndexOf(' ', startIndex); // Finds the end of the ID
                return endIndex >= 0 ? selectedText.Substring(startIndex, endIndex - startIndex) : selectedText.Substring(startIndex);
            }
            return null; // Update ID not found
        }

        private void RunPowerShellScript(string scriptText)
        {
            // Create a new PowerShell process
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{scriptText}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            try
            {
                using (Process process = Process.Start(psi))
                {
                    // Capture output and errors
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    // Display output or errors
                    if (!string.IsNullOrEmpty(output))
                    {
                        MessageBox.Show($"Output: {output}");
                    }
                    if (!string.IsNullOrEmpty(errors))
                    {
                        MessageBox.Show($"Errors: {errors}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void detecthardwarebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detecting Hardware from " + pcName);
            GetHardwareInfo();
        }

        private void installedDriversbtn_Click(object sender, EventArgs e)
        {
            DetectInstalledDrivers();
        }

        private void checkUpdatesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable the button and show a message
                checkUpdatesbtn.Text = "Checking...";
                checkUpdatesbtn.Enabled = false;
                listBoxDriversUpdate.Items.Clear();

                // Use a separate thread to perform the update check
                Thread updateThread = new Thread(CheckForDriverUpdates);
                updateThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void installBtn_Click(object sender, EventArgs e)
        {
            // Check if a driver update is selected
            if (listBoxDriversUpdate.SelectedItem != null)
            {
                // Get the selected item text
                string selectedText = listBoxDriversUpdate.SelectedItem.ToString();

                // Check if the selected item is an Update ID line
                if (selectedText.Contains("Update ID:"))
                {
                    // Extract the UpdateID from the selected item
                    string updateID = ExtractUpdateID(selectedText);
                    MessageBox.Show("Updating DriverID : " + updateID);

                    // Verify we have a valid UpdateID
                    if (!string.IsNullOrEmpty(updateID))
                    {
                        // Pass the UpdateID to the PowerShell script
                        string script = $@"
                    $Session = New-Object -ComObject Microsoft.Update.Session
                    $Searcher = $Session.CreateUpdateSearcher()
                    $UpdateCollection = New-Object -ComObject Microsoft.Update.UpdateColl
                    $Result = $Searcher.Search('IsInstalled=0 and Type=''Driver''')
                    $Updates = $Result.Updates
                    foreach ($Update in $Updates) {{
                        if ($Update.Identity.UpdateID -eq '{updateID}') {{
                            $UpdateCollection.Add($Update) | Out-Null
                        }}
                    }}
                    if ($UpdateCollection.Count -gt 0) {{
                        $Downloader = $Session.CreateUpdateDownloader()
                        $Downloader.Updates = $UpdateCollection
                        $DownloadResult = $Downloader.Download()
                        if ($DownloadResult.ResultCode -eq 2) {{
                            $Installer = New-Object -ComObject Microsoft.Update.Installer
                            $Installer.Updates = $UpdateCollection
                            $InstallResult = $Installer.Install()
                            if ($InstallResult.ResultCode -eq 2) {{ 'Update installed successfully.' }}
                            else {{ 'Update installation failed.' }}
                        }} else {{ 'Download failed. Updates not installed.' }}
                    }} else {{ 'Selected driver update not found.' }}";

                        RunPowerShellScript(script);
                    }
                    else
                    {
                        MessageBox.Show("Could not extract a valid UpdateID. Please check the selection.");
                    }
                }
                else
                {
                    // Show a message if the selected item is not a driver ID
                    MessageBox.Show("Please select a driver by its Update ID.");
                }
            }
            else
            {
                // No driver update selected, prompt the user
                MessageBox.Show("Please select a driver to update.");
            }
        }
    }
}
