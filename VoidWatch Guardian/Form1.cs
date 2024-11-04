using System.Diagnostics;
using System.Timers;
using Voidbot_Discord_Bot_GUI;
namespace VoidWatchDog
{
    public partial class Form1 : Form
    {
        private readonly System.Timers.Timer _monitorTimer;
        private readonly List<string> _exePaths;
        // Define INI settings
        string userfile = @"\UserCFG.ini";
        private inisettings INI2;
        private string iniPath;

        public Form1()
        {
            InitializeComponent();
            INI2 = new VoidWatchDog.inisettings();
            iniPath = Path.Combine(Application.StartupPath, "UserCFG.ini");
            INI2.Path = iniPath;
            _exePaths = new List<string>();
            lstWatchedPrograms.Columns.Add("ProgramName", "Program Name");
            lstWatchedPrograms.Columns.Add("Status", "Status");
            lstWatchedPrograms.ReadOnly = true;
            lstWatchedPrograms.AllowUserToAddRows = false;
            lstWatchedPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstWatchedPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Set up the timer to check every x seconds defined in UserCFG.ini
            string intervalString = INI2.ReadValue("Settings", "MonitoringInterval");
            if (double.TryParse(intervalString, out double intervalInSeconds))
            {
                _monitorTimer = new System.Timers.Timer(TimeSpan.FromSeconds(intervalInSeconds).TotalMilliseconds);
            }
            else
            {
                // Handle the case where parsing fails
                MessageBox.Show("Invalid Monitoring Interval value in INI file. Using default interval of 5000 ms.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _monitorTimer = new System.Timers.Timer(TimeSpan.FromSeconds(5).TotalMicroseconds); // Default to 5000 ms if parsing fails
            }
            _monitorTimer.Elapsed += MonitorProcesses;
        }

        private void MonitorProcesses(object sender, ElapsedEventArgs e)
        {
            // Display running status
            Invoke(new Action(() =>
            {
                currentStatus.Text = "Running...";
                currentStatus.ForeColor = Color.Green;
            }));

            foreach (DataGridViewRow row in lstWatchedPrograms.Rows)
            {
                // Check if the value is not null (fixed error)
                if (row.Cells["ProgramName"].Value != null)
                {
                    string programName = row.Cells["ProgramName"].Value.ToString();
                    string exePath = _exePaths.FirstOrDefault(p => Path.GetFileNameWithoutExtension(p) == programName);

                    if (exePath != null)
                    {
                        Process[] processes = Process.GetProcessesByName(programName);
                        string status = processes.Length > 0 ? "Running" : "Stopped";

                        // If process is not running, we start it
                        if (processes.Length == 0)
                        {
                            ExceptionHandler.LogMessage($"{programName} has stopped unexpectedly. Attempting to restart.");
                            Process.Start(exePath);
                            status = "Restarted";
                            ExceptionHandler.LogMessage($"{programName} has been restarted.");
                        }
                        // Update the status of each program in the UI
                        Invoke(new Action(() =>
                        {
                            row.Cells["Status"].Value = status;
                        }));
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var INI2 = new VoidWatchDog.inisettings();
            iniPath = Path.Combine(Application.StartupPath, "UserCFG.ini");
            INI2.Path = iniPath;

            if (!File.Exists(iniPath))
            {
                MessageBox.Show("UserCFG.ini not found in App Startup Path, Creating file...");
                EmbeddedResourceCreation.SaveToDisk("UserCFG.ini", iniPath);
            }

            string autoStartMonitoringValue = INI2.ReadValue("Settings", "AutoStart");
            bool autoStartMonitoring = autoStartMonitoringValue.Equals("True", StringComparison.OrdinalIgnoreCase);

            if (autoStartMonitoring)
            {
                _monitorTimer.Start();
                currentStatus.Text = "Running...";
                currentStatus.ForeColor = Color.Green;
            }
            // Load all programs saved in UserCFG.ini and add them to the DataGridView
            int programIndex = 1;
            while (true)
            {
                string key = $"Program{programIndex}";
                string filePath = INI2.ReadValue("WatchDogPrograms", key);

                if (string.IsNullOrWhiteSpace(filePath)) break;

                _exePaths.Add(filePath); // Add path to list
                string programName = Path.GetFileNameWithoutExtension(filePath);

                if (!string.IsNullOrEmpty(programName))
                {
                    // Add each program to DataGridView with initial status as stopped
                    lstWatchedPrograms.Rows.Add(programName, "Stopped");
                }
                else
                {
                    // Do nothing
                }

                programIndex++;
            }
        }



        private void startMonitoring_Click(object sender, EventArgs e)
        {
            _monitorTimer.Start();
        }

        private void stopMonitoring_Click(object sender, EventArgs e)
        {
            // Stop the monitoring timer
            _monitorTimer.Stop();

            // Update the label to show monitoring has stopped
            currentStatus.Text = "Waiting...";
            currentStatus.ForeColor = Color.Red;

            // Update each programs status in the DataGridView to stopped
            foreach (DataGridViewRow row in lstWatchedPrograms.Rows)
            {
                if (row.Cells["Status"] != null)
                {
                    row.Cells["Status"].Value = "Stopped";
                }
            }
        }

        private void addToList_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Add program to the list of programs to be monitored.
                openFileDialog.Filter = "Executable Files|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    _exePaths.Add(filePath);

                    string programName = Path.GetFileNameWithoutExtension(filePath);
                    lstWatchedPrograms.Rows.Add(programName, "Stopped");

                    // Save to INI file
                    int programIndex = _exePaths.Count;
                    INI2.WriteValue("WatchDogPrograms", $"Program{programIndex}", filePath.ToString(), INI2.GetPath());
                }
            }
        }

        private void removeFromList_Click(object sender, EventArgs e)
        {
            if (lstWatchedPrograms.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = lstWatchedPrograms.SelectedRows[0];

                // Null check on cell
                if (selectedRow.Cells["ProgramName"].Value != null)
                {
                    string programName = selectedRow.Cells["ProgramName"].Value.ToString();
                    string exePath = _exePaths.FirstOrDefault(p => Path.GetFileNameWithoutExtension(p) == programName);

                    if (exePath != null)
                    {
                        // Remove from exePaths list
                        _exePaths.Remove(exePath);

                        // Remove the selected row from DataGridView to sync with UI
                        lstWatchedPrograms.Rows.Remove(selectedRow);

                        // Find and delete the matching ProgramX key in the INI file
                        int programIndex = 1;
                        string keyToDelete = null;
                        while (true)
                        {
                            string key = $"Program{programIndex}";
                            string iniPath = INI2.ReadValue("WatchDogPrograms", key);

                            if (string.IsNullOrWhiteSpace(iniPath)) break;

                            // If the path in the INI matches the exePath, mark for deletion
                            if (iniPath == exePath)
                            {
                                keyToDelete = key;
                                INI2.DeleteKey("WatchDogPrograms", key);
                                break;
                            }
                            programIndex++;
                        }

                        // Renumber remaining entries in the INI file
                        if (keyToDelete != null)
                        {
                            int deletedIndex = int.Parse(keyToDelete.Replace("Program", ""));
                            RenumberIniEntries(deletedIndex);
                        }

                        // Refresh the DataGridView to update items
                        RefreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Selected row does not contain a valid program name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No program selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Reload the DataGridView after renumbering with helper method
        private void RefreshDataGridView()
        {
            lstWatchedPrograms.Rows.Clear();
            foreach (string filePath in _exePaths)
            {
                string programName = Path.GetFileNameWithoutExtension(filePath);
                lstWatchedPrograms.Rows.Add(programName, "Stopped");
            }
        }

        // Renumbers the remaining entries in the INI file after a deletion
        private void RenumberIniEntries(int startIndex)
        {
            int currentIndex = startIndex;
            while (true)
            {
                string currentKey = $"Program{currentIndex + 1}";
                string newKey = $"Program{currentIndex}";
                string value = INI2.ReadValue("WatchDogPrograms", currentKey);

                if (string.IsNullOrWhiteSpace(value)) break;

                // Move value to the new key
                INI2.WriteValue("WatchDogPrograms", newKey, value, INI2.GetPath());
                // Delete the old key
                INI2.DeleteKey("WatchDogPrograms", currentKey);

                currentIndex++;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }
    }
}
