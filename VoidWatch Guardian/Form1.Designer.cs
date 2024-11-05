namespace VoidWatchDog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            nsGroupBox1 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            nsGroupBox4 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            removeFromList = new Voidbot_Discord_Bot_GUI.NSButton();
            addToList = new Voidbot_Discord_Bot_GUI.NSButton();
            nsGroupBox3 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            startMonitoring = new Voidbot_Discord_Bot_GUI.NSButton();
            stopMonitoring = new Voidbot_Discord_Bot_GUI.NSButton();
            nsGroupBox2 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            statusDisplay = new Label();
            currentStatus = new Label();
            nsLabel1 = new Voidbot_Discord_Bot_GUI.NSLabel();
            lstWatchedPrograms = new DataGridView();
            menuStrip1.SuspendLayout();
            nsGroupBox1.SuspendLayout();
            nsGroupBox4.SuspendLayout();
            nsGroupBox3.SuspendLayout();
            nsGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstWatchedPrograms).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(848, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 20);
            fileToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // nsGroupBox1
            // 
            nsGroupBox1.BackColor = Color.FromArgb(30, 30, 30);
            nsGroupBox1.Controls.Add(nsGroupBox4);
            nsGroupBox1.Controls.Add(nsGroupBox3);
            nsGroupBox1.Controls.Add(nsGroupBox2);
            nsGroupBox1.Controls.Add(nsLabel1);
            nsGroupBox1.Controls.Add(lstWatchedPrograms);
            nsGroupBox1.DrawSeperator = false;
            nsGroupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nsGroupBox1.ForeColor = Color.Black;
            nsGroupBox1.Location = new Point(12, 32);
            nsGroupBox1.Name = "nsGroupBox1";
            nsGroupBox1.Size = new Size(824, 364);
            nsGroupBox1.SubTitle = "";
            nsGroupBox1.TabIndex = 9;
            nsGroupBox1.Tag = "";
            nsGroupBox1.Text = "nsGroupBox1";
            nsGroupBox1.Title = "";
            // 
            // nsGroupBox4
            // 
            nsGroupBox4.BackColor = Color.Black;
            nsGroupBox4.Controls.Add(removeFromList);
            nsGroupBox4.Controls.Add(addToList);
            nsGroupBox4.DrawSeperator = false;
            nsGroupBox4.Location = new Point(637, 29);
            nsGroupBox4.Name = "nsGroupBox4";
            nsGroupBox4.Size = new Size(179, 37);
            nsGroupBox4.SubTitle = "";
            nsGroupBox4.TabIndex = 22;
            nsGroupBox4.Text = "nsGroupBox4";
            nsGroupBox4.Title = "";
            // 
            // removeFromList
            // 
            removeFromList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeFromList.Location = new Point(92, 3);
            removeFromList.Name = "removeFromList";
            removeFromList.Size = new Size(84, 30);
            removeFromList.TabIndex = 18;
            removeFromList.Text = "Remove -";
            removeFromList.Click += removeFromList_Click;
            // 
            // addToList
            // 
            addToList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToList.Location = new Point(3, 3);
            addToList.Name = "addToList";
            addToList.Size = new Size(86, 30);
            addToList.TabIndex = 17;
            addToList.Text = "Add +";
            addToList.Click += addToList_Click;
            // 
            // nsGroupBox3
            // 
            nsGroupBox3.BackColor = Color.Black;
            nsGroupBox3.Controls.Add(startMonitoring);
            nsGroupBox3.Controls.Add(stopMonitoring);
            nsGroupBox3.DrawSeperator = false;
            nsGroupBox3.Location = new Point(637, 72);
            nsGroupBox3.Name = "nsGroupBox3";
            nsGroupBox3.Size = new Size(179, 73);
            nsGroupBox3.SubTitle = "";
            nsGroupBox3.TabIndex = 20;
            nsGroupBox3.Text = "nsGroupBox3";
            nsGroupBox3.Title = "";
            // 
            // startMonitoring
            // 
            startMonitoring.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startMonitoring.Location = new Point(3, 6);
            startMonitoring.Name = "startMonitoring";
            startMonitoring.Size = new Size(173, 30);
            startMonitoring.TabIndex = 20;
            startMonitoring.Text = "Start Monitoring";
            startMonitoring.Click += startMonitoring_Click;
            // 
            // stopMonitoring
            // 
            stopMonitoring.Enabled = false;
            stopMonitoring.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopMonitoring.Location = new Point(3, 38);
            stopMonitoring.Name = "stopMonitoring";
            stopMonitoring.Size = new Size(173, 30);
            stopMonitoring.TabIndex = 21;
            stopMonitoring.Text = "Stop Monitoring";
            stopMonitoring.Click += stopMonitoring_Click;
            // 
            // nsGroupBox2
            // 
            nsGroupBox2.BackColor = Color.Black;
            nsGroupBox2.Controls.Add(statusDisplay);
            nsGroupBox2.Controls.Add(currentStatus);
            nsGroupBox2.DrawSeperator = false;
            nsGroupBox2.Location = new Point(7, 29);
            nsGroupBox2.Name = "nsGroupBox2";
            nsGroupBox2.Size = new Size(624, 29);
            nsGroupBox2.SubTitle = "";
            nsGroupBox2.TabIndex = 19;
            nsGroupBox2.Text = "nsGroupBox2";
            nsGroupBox2.Title = "";
            // 
            // statusDisplay
            // 
            statusDisplay.AutoSize = true;
            statusDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            statusDisplay.ForeColor = Color.FromArgb(17, 177, 165);
            statusDisplay.Location = new Point(4, 4);
            statusDisplay.Name = "statusDisplay";
            statusDisplay.Size = new Size(61, 21);
            statusDisplay.TabIndex = 14;
            statusDisplay.Text = "Status:";
            // 
            // currentStatus
            // 
            currentStatus.AutoSize = true;
            currentStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            currentStatus.ForeColor = Color.FromArgb(192, 0, 0);
            currentStatus.Location = new Point(61, 4);
            currentStatus.Name = "currentStatus";
            currentStatus.Size = new Size(82, 21);
            currentStatus.TabIndex = 15;
            currentStatus.Text = "Waiting...";
            // 
            // nsLabel1
            // 
            nsLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nsLabel1.Location = new Point(7, 5);
            nsLabel1.Name = "nsLabel1";
            nsLabel1.Size = new Size(164, 23);
            nsLabel1.TabIndex = 16;
            nsLabel1.Text = "nsLabel1";
            nsLabel1.Value1 = "VoidWatch";
            nsLabel1.Value2 = " Guardian";
            // 
            // lstWatchedPrograms
            // 
            lstWatchedPrograms.BackgroundColor = Color.Black;
            lstWatchedPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstWatchedPrograms.Location = new Point(7, 64);
            lstWatchedPrograms.Name = "lstWatchedPrograms";
            lstWatchedPrograms.Size = new Size(624, 287);
            lstWatchedPrograms.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(848, 404);
            Controls.Add(nsGroupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "VoidWatch Guardian [Program & Bot Monitoring]";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            nsGroupBox1.ResumeLayout(false);
            nsGroupBox4.ResumeLayout(false);
            nsGroupBox3.ResumeLayout(false);
            nsGroupBox2.ResumeLayout(false);
            nsGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lstWatchedPrograms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox1;
        private Voidbot_Discord_Bot_GUI.NSLabel nsLabel1;
        private Label currentStatus;
        private Label statusDisplay;
        private DataGridView lstWatchedPrograms;
        private Voidbot_Discord_Bot_GUI.NSButton stopMonitoring;
        private Voidbot_Discord_Bot_GUI.NSButton addToList;
        private Voidbot_Discord_Bot_GUI.NSButton removeFromList;
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox2;
        private Voidbot_Discord_Bot_GUI.NSButton startMonitoring;
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox3;
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox4;
    }
}
