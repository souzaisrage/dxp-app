using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dxpapp
{
    public partial class LogsForm : Form
    {
        public LogsForm()
        {
            InitializeComponent();
            LoadLogs();
            LogManager.LogAdded += OnLogAdded;
        }

        private void LoadLogs()
        {
            // Load all existing logs into the ListBox
            var logs = LogManager.GetLogs();
            listBox1.Items.Clear();
            foreach (var log in logs)
            {
                listBox1.Items.Add(log);
            }
        }

        private void OnLogAdded(string log)
        {
            // Update the ListBox in real time
            if (InvokeRequired)
            {
                Invoke(new Action(() => listBox1.Items.Add(log)));
            }
            else
            {
                listBox1.Items.Add(log);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Unsubscribe from the event when the form is closed
            LogManager.LogAdded -= OnLogAdded;
            base.OnFormClosed(e);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the log file or list is empty
            if (LogManager.GetLogs().Count == 0)
            {
                // If the logs are empty, show a message box
                MessageBox.Show("There are no logs to delete.", "No Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show a confirmation dialog
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to clear the logs?",
                    "Clear Logs Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // If the user clicks Yes, proceed to clear the logs
                if (result == DialogResult.Yes)
                {
                    // Clear the ListBox items
                    listBox1.Items.Clear();

                    // Clear the logs in the file
                    LogManager.ClearLogs();

                    // Optionally, show a confirmation message
                    MessageBox.Show("Logs have been cleared successfully.");
                }
                // If the user clicks No, do nothing
                else
                {
                    MessageBox.Show("Logs not cleared.");
                }
            }
        }
    }
}
