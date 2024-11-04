namespace VoidWatchDog
{
    public partial class Settings : Form
    {
        string userfile = @"\UserCFG.ini";
        private inisettings INI2;
        private string iniPath;
        public Settings()
        {
            InitializeComponent();
            INI2 = new VoidWatchDog.inisettings();
            iniPath = Path.Combine(Application.StartupPath, "UserCFG.ini");
            INI2.Path = iniPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to save your settings?",
                "VoidWatch Guardian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int monitoringIntervalValue = (int)monitoringInterval.Value;

                // Save the interval to the INI file
                INI2.WriteValue("Settings", "MonitoringInterval", monitoringIntervalValue.ToString(), INI2.GetPath());

                // Save the Auto Start Monitoring setting to the INI file
                string autoStartMonitoringValue = chkAutoStartMonitoring.Checked ? "True" : "False";
                INI2.WriteValue("Settings", "AutoStart", autoStartMonitoringValue, INI2.GetPath());

            }
            else
            {
                // Do nothing
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var INI2 = new VoidWatchDog.inisettings();
            iniPath = Path.Combine(Application.StartupPath, "UserCFG.ini");
            INI2.Path = iniPath;

            // Read the interval value as a string from the INI file
            string intervalString = INI2.ReadValue("Settings", "MonitoringInterval");

            // Try to parse the string to an integer
            if (int.TryParse(intervalString, out int monitoringIntervalValue))
            {
                monitoringInterval.Value = monitoringIntervalValue;
            }
            else
            {
                MessageBox.Show("Invalid Monitoring Interval in INI file, check for white spaces, or incorrect settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string autoStartMonitoringValue = INI2.ReadValue("Settings", "AutoStart", "False");
            chkAutoStartMonitoring.Checked = autoStartMonitoringValue.Equals("True", StringComparison.OrdinalIgnoreCase);
        }

    }
}
