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
            groupBox2 = new GroupBox();
            chkAutoStartMonitoring = new CheckBox();
            button1 = new Button();
            monitoringInterval = new NumericUpDown();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monitoringInterval).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkAutoStartMonitoring);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(monitoringInterval);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox2.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 143);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // chkAutoStartMonitoring
            // 
            chkAutoStartMonitoring.AutoSize = true;
            chkAutoStartMonitoring.Font = new Font("Microsoft Sans Serif", 9.75F);
            chkAutoStartMonitoring.Location = new Point(6, 22);
            chkAutoStartMonitoring.Name = "chkAutoStartMonitoring";
            chkAutoStartMonitoring.Size = new Size(128, 20);
            chkAutoStartMonitoring.TabIndex = 13;
            chkAutoStartMonitoring.Text = "Auto Start on Run";
            chkAutoStartMonitoring.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(140, 107);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // monitoringInterval
            // 
            monitoringInterval.Font = new Font("Microsoft Sans Serif", 9.75F);
            monitoringInterval.Location = new Point(192, 42);
            monitoringInterval.Name = "monitoringInterval";
            monitoringInterval.Size = new Size(51, 22);
            monitoringInterval.TabIndex = 11;
            monitoringInterval.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(180, 16);
            label1.TabIndex = 10;
            label1.Text = "Monitoring Interval (Seconds)";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(287, 168);
            Controls.Add(groupBox2);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)monitoringInterval).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button button1;
        private NumericUpDown monitoringInterval;
        private Label label1;
        private CheckBox chkAutoStartMonitoring;
    }
}