using System.Diagnostics;
using System.Timers;
using Voidbot_Discord_Bot_GUI;
namespace VoidWatchDog
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer _monitorTimer;
        private System.Timers.Timer _restartTimer;
        private readonly List<string> _exePaths = new();
        private inisettings INI2;
        private readonly string iniPath;
        private bool _enablePeriodicRestart;
        private double _restartInterval;
        private bool _isRestarting = false;
        public Form1()
        {
            InitializeComponent();
            INI2 = new VoidWatchDog.inisettings();
            iniPath = Path.Combine(Application.StartupPath, "UserCFG.ini");
            INI2.Path = iniPath;

            InitializeDataGridView();
            InitializeTimers();
        }

        private void InitializeDataGridView()
        {
            lstWatchedPrograms.Columns.Add("ProgramName", "Program Name");
            lstWatchedPrograms.Columns.Add("Status", "Status");
            lstWatchedPrograms.ReadOnly = true;
            lstWatchedPrograms.AllowUserToAddRows = false;
            lstWatchedPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstWatchedPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // Helper method to check for bad values, or missing values
        private double LoadIntervalSetting(string settingName, double defaultInterval)
        {
            string intervalString = INI2.ReadValue("Settings", settingName);
            if (double.TryParse(intervalString, out double intervalValue))
            {
                if (intervalValue > 0)
                {
                    return intervalValue;
                }
                else
                {
                    MessageBox.Show($"Invalid value '0' for {settingName}. Using default interval of {defaultInterval} hours.",
                                    "Invalid Interval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Invalid {settingName} format in INI file. Using default interval of {defaultInterval} hours.",
                                "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return defaultInterval;
        }
        private void InitializeTimers()
        {
            // Initialize monitoring timer
            double monitorInterval = LoadIntervalSetting("MonitoringInterval", 5); // Default to 5 seconds if parsing fails
            _monitorTimer = new System.Timers.Timer(TimeSpan.FromSeconds(monitorInterval).TotalMilliseconds);
            _monitorTimer.Elapsed += MonitorProcesses;

            // Initialize restart timer if enabled
            string enableRestart = INI2.ReadValue("Settings", "EnablePeriodicRestart", "False");
            _enablePeriodicRestart = bool.TryParse(enableRestart, out bool enabled) && enabled;

            if (_enablePeriodicRestart)
            {
                _restartInterval = LoadIntervalSetting("RestartInterval", 24); // Default to 24 hours if parsing fails
                _restartTimer = new System.Timers.Timer(TimeSpan.FromHours(_restartInterval).TotalMilliseconds);
                _restartTimer.Elapsed += RestartProcesses;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(iniPath))
            {
                MessageBox.Show("UserCFG.ini not found. Creating default settings file...", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmbeddedResourceCreation.SaveToDisk("UserCFG.ini", iniPath);
            }

            string autoStartMonitoring = INI2.ReadValue("Settings", "AutoStart", "False");
            if (bool.TryParse(autoStartMonitoring, out bool shouldAutoStart) && shouldAutoStart)
            {
                _monitorTimer.Start();
                UpdateStatusDisplay("Running", Color.Green);
                startMonitoring.Enabled = false;
                stopMonitoring.Enabled = true;
            }

            if (_enablePeriodicRestart) _restartTimer.Start();

            LoadProgramsToWatch();
        }

        private void LoadProgramsToWatch()
        {
            int programIndex = 1;
            while (true)
            {
                string key = $"Program{programIndex}";
                string filePath = INI2.ReadValue("WatchDogPrograms", key);

                if (string.IsNullOrWhiteSpace(filePath)) break;

                _exePaths.Add(filePath);
                string programName = Path.GetFileNameWithoutExtension(filePath);
                if (!string.IsNullOrEmpty(programName))
                    lstWatchedPrograms.Rows.Add(programName, "Stopped");

                programIndex++;
            }
        }

         private void MonitorProcesses(object sender, ElapsedEventArgs e)
 {
    if (_isRestarting) return; // Skip monitoring while restarting

    Invoke(new Action(() => UpdateStatusDisplay("Running...", Color.Green)));

    foreach (DataGridViewRow row in lstWatchedPrograms.Rows)
    {
        string programName = row.Cells["ProgramName"].Value?.ToString();
        string exePath = _exePaths.FirstOrDefault(p => Path.GetFileNameWithoutExtension(p) == programName);

        if (!string.IsNullOrEmpty(exePath))
        {
            Process[] processes = Process.GetProcessesByName(programName);
            string status = processes.Length > 0 ? "Running" : "Stopped";

            if (processes.Length == 0)
            {
                ExceptionHandler.LogMessage($"{programName} stopped unexpectedly. Attempting to restart.");
                Process.Start(exePath);
                status = "Restarted";
                ExceptionHandler.LogMessage($"{programName} restarted.");
            }

            Invoke(new Action(() => row.Cells["Status"].Value = status));
        }
    }
 }

private void RestartProcesses(object sender, ElapsedEventArgs e)
{
    _isRestarting = true; // Indicate that restart is in progress

    foreach (var exePath in _exePaths)
    {
        string programName = Path.GetFileNameWithoutExtension(exePath);

        // Kill any running instances of the program
        var processes = Process.GetProcessesByName(programName);
        foreach (var process in processes)
        {
            process.Kill();
            process.WaitForExit();
        }
        Process.Start(exePath);
        ExceptionHandler.LogMessage($"{programName} restarted by periodic restart timer.");
    }

    _isRestarting = false; // Restart is complete, re-enable monitoring
}


        private void UpdateStatusDisplay(string message, Color color)
        {
            currentStatus.Text = message;
            currentStatus.ForeColor = color;
        }

        private void startMonitoring_Click(object sender, EventArgs e)
        {
            _monitorTimer.Start();
            startMonitoring.Enabled = false;
            stopMonitoring.Enabled = true;
        }

        private void stopMonitoring_Click(object sender, EventArgs e)
        {
            _monitorTimer.Stop();
            UpdateStatusDisplay("Waiting...", Color.Red);
            startMonitoring.Enabled = true;
            stopMonitoring.Enabled = false;
            foreach (DataGridViewRow row in lstWatchedPrograms.Rows)
            {
                row.Cells["Status"].Value = "Stopped";
            }
        }

        private void removeFromList_Click(object sender, EventArgs e)
        {
            if (lstWatchedPrograms.SelectedRows.Count > 0)
            {
                var selectedRow = lstWatchedPrograms.SelectedRows[0];
                string programName = selectedRow.Cells["ProgramName"].Value?.ToString();
                string exePath = _exePaths.FirstOrDefault(p => Path.GetFileNameWithoutExtension(p) == programName);

                if (!string.IsNullOrEmpty(exePath))
                {
                    _exePaths.Remove(exePath);
                    lstWatchedPrograms.Rows.Remove(selectedRow);

                    int programIndex = 1;
                    string keyToDelete = null;
                    while (true)
                    {
                        string key = $"Program{programIndex}";
                        string iniPath = INI2.ReadValue("WatchDogPrograms", key);
                        if (string.IsNullOrWhiteSpace(iniPath)) break;

                        if (iniPath == exePath)
                        {
                            keyToDelete = key;
                            INI2.DeleteKey("WatchDogPrograms", key);
                            break;
                        }
                        programIndex++;
                    }

                    if (keyToDelete != null)
                    {
                        int deletedIndex = int.Parse(keyToDelete.Replace("Program", ""));
                        RenumberIniEntries(deletedIndex);
                    }

                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("No program selected to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshDataGridView()
        {
            lstWatchedPrograms.Rows.Clear();
            foreach (string filePath in _exePaths)
            {
                string programName = Path.GetFileNameWithoutExtension(filePath);
                lstWatchedPrograms.Rows.Add(programName, "Stopped");
            }
        }

        private void RenumberIniEntries(int startIndex)
        {
            int currentIndex = startIndex;
            while (true)
            {
                string currentKey = $"Program{currentIndex + 1}";
                string newKey = $"Program{currentIndex}";
                string value = INI2.ReadValue("WatchDogPrograms", currentKey);

                if (string.IsNullOrWhiteSpace(value)) break;

                INI2.WriteValue("WatchDogPrograms", newKey, value, INI2.GetPath());
                INI2.DeleteKey("WatchDogPrograms", currentKey);
                currentIndex++;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => new About().ShowDialog();

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) => new Settings().ShowDialog();

        private void addToList_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Executable Files|*.exe" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    _exePaths.Add(filePath);
                    string programName = Path.GetFileNameWithoutExtension(filePath);
                    lstWatchedPrograms.Rows.Add(programName, "Stopped");

                    int programIndex = _exePaths.Count;
                    INI2.WriteValue("WatchDogPrograms", $"Program{programIndex}", filePath, INI2.GetPath());
                }
            }
        }
    }
}
