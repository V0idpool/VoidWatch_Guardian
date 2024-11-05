namespace VoidWatchDog
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            button1 = new Button();
            nsGroupBox1 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            chkAutoRestart = new Voidbot_Discord_Bot_GUI.NSCheckBox();
            chkAutoStartMonitoring = new Voidbot_Discord_Bot_GUI.NSCheckBox();
            restartInterval = new NumericUpDown();
            label2 = new Label();
            monitoringInterval = new NumericUpDown();
            label1 = new Label();
            nsGroupBox2 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            nsGroupBox3 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            nsGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)restartInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monitoringInterval).BeginInit();
            nsGroupBox2.SuspendLayout();
            nsGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nsGroupBox1
            // 
            nsGroupBox1.BackColor = Color.FromArgb(30, 30, 30);
            nsGroupBox1.Controls.Add(chkAutoStartMonitoring);
            nsGroupBox1.Controls.Add(monitoringInterval);
            nsGroupBox1.Controls.Add(label1);
            nsGroupBox1.DrawSeperator = false;
            nsGroupBox1.Location = new Point(12, 12);
            nsGroupBox1.Name = "nsGroupBox1";
            nsGroupBox1.Size = new Size(397, 79);
            nsGroupBox1.SubTitle = "Configure your settings here.";
            nsGroupBox1.TabIndex = 13;
            nsGroupBox1.Text = "nsGroupBox1";
            nsGroupBox1.Title = "Settings";
            // 
            // chkAutoRestart
            // 
            chkAutoRestart.Checked = false;
            chkAutoRestart.Location = new Point(3, 41);
            chkAutoRestart.Name = "chkAutoRestart";
            chkAutoRestart.Size = new Size(180, 23);
            chkAutoRestart.TabIndex = 24;
            chkAutoRestart.Text = "Automatically Restart Apps";
            // 
            // chkAutoStartMonitoring
            // 
            chkAutoStartMonitoring.Checked = false;
            chkAutoStartMonitoring.Location = new Point(243, 3);
            chkAutoStartMonitoring.Name = "chkAutoStartMonitoring";
            chkAutoStartMonitoring.Size = new Size(151, 23);
            chkAutoStartMonitoring.TabIndex = 23;
            chkAutoStartMonitoring.Text = "Auto Start Apps on Run";
            // 
            // restartInterval
            // 
            restartInterval.Font = new Font("Microsoft Sans Serif", 9.75F);
            restartInterval.Location = new Point(152, 65);
            restartInterval.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            restartInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            restartInterval.Name = "restartInterval";
            restartInterval.Size = new Size(51, 22);
            restartInterval.TabIndex = 21;
            restartInterval.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(143, 16);
            label2.TabIndex = 20;
            label2.Text = "Restart Interval (Hours)";
            // 
            // monitoringInterval
            // 
            monitoringInterval.Font = new Font("Microsoft Sans Serif", 9.75F);
            monitoringInterval.Location = new Point(189, 41);
            monitoringInterval.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            monitoringInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            monitoringInterval.Name = "monitoringInterval";
            monitoringInterval.Size = new Size(51, 22);
            monitoringInterval.TabIndex = 18;
            monitoringInterval.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(3, 43);
            label1.Name = "label1";
            label1.Size = new Size(180, 16);
            label1.TabIndex = 17;
            label1.Text = "Monitoring Interval (Seconds)";
            // 
            // nsGroupBox2
            // 
            nsGroupBox2.BackColor = Color.FromArgb(30, 30, 30);
            nsGroupBox2.Controls.Add(label2);
            nsGroupBox2.Controls.Add(chkAutoRestart);
            nsGroupBox2.Controls.Add(restartInterval);
            nsGroupBox2.DrawSeperator = false;
            nsGroupBox2.Location = new Point(12, 97);
            nsGroupBox2.Name = "nsGroupBox2";
            nsGroupBox2.Size = new Size(394, 101);
            nsGroupBox2.SubTitle = "Restart apps periodically based on the interval set";
            nsGroupBox2.TabIndex = 25;
            nsGroupBox2.Text = "nsGroupBox2";
            nsGroupBox2.Title = "App Restart Settings";
            // 
            // nsGroupBox3
            // 
            nsGroupBox3.BackColor = Color.FromArgb(30, 30, 30);
            nsGroupBox3.Controls.Add(button1);
            nsGroupBox3.DrawSeperator = false;
            nsGroupBox3.Location = new Point(282, 204);
            nsGroupBox3.Name = "nsGroupBox3";
            nsGroupBox3.Size = new Size(124, 36);
            nsGroupBox3.SubTitle = "";
            nsGroupBox3.TabIndex = 26;
            nsGroupBox3.Text = "nsGroupBox3";
            nsGroupBox3.Title = "";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(421, 248);
            Controls.Add(nsGroupBox3);
            Controls.Add(nsGroupBox2);
            Controls.Add(nsGroupBox1);
            ForeColor = Color.FromArgb(0, 192, 192);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            nsGroupBox1.ResumeLayout(false);
            nsGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)restartInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)monitoringInterval).EndInit();
            nsGroupBox2.ResumeLayout(false);
            nsGroupBox2.PerformLayout();
            nsGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox1;
        private NumericUpDown restartInterval;
        private Label label2;
        private NumericUpDown monitoringInterval;
        private Label label1;
        private Voidbot_Discord_Bot_GUI.NSCheckBox chkAutoStartMonitoring;
        private Voidbot_Discord_Bot_GUI.NSCheckBox chkAutoRestart;
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox2;
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox3;
    }
}