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
            startMonitoring = new Button();
            stopMonitoring = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            currentStatus = new Label();
            statusDisplay = new Label();
            lstWatchedPrograms = new DataGridView();
            removeFromList = new Button();
            addToList = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstWatchedPrograms).BeginInit();
            SuspendLayout();
            // 
            // startMonitoring
            // 
            startMonitoring.ForeColor = Color.Black;
            startMonitoring.Location = new Point(540, 415);
            startMonitoring.Name = "startMonitoring";
            startMonitoring.Size = new Size(121, 30);
            startMonitoring.TabIndex = 0;
            startMonitoring.Text = "Start Monitoring";
            startMonitoring.UseVisualStyleBackColor = true;
            startMonitoring.Click += startMonitoring_Click;
            // 
            // stopMonitoring
            // 
            stopMonitoring.ForeColor = Color.Black;
            stopMonitoring.Location = new Point(667, 415);
            stopMonitoring.Name = "stopMonitoring";
            stopMonitoring.Size = new Size(121, 30);
            stopMonitoring.TabIndex = 1;
            stopMonitoring.Text = "Stop Monitoring";
            stopMonitoring.UseVisualStyleBackColor = true;
            stopMonitoring.Click += stopMonitoring_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            aboutToolStripMenuItem.Size = new Size(180, 22);
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
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(currentStatus);
            groupBox1.Controls.Add(statusDisplay);
            groupBox1.Controls.Add(lstWatchedPrograms);
            groupBox1.Controls.Add(removeFromList);
            groupBox1.Controls.Add(addToList);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 382);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Programs and Bots Being Monitored";
            // 
            // currentStatus
            // 
            currentStatus.AutoSize = true;
            currentStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentStatus.Location = new Point(180, 21);
            currentStatus.Name = "currentStatus";
            currentStatus.Size = new Size(60, 17);
            currentStatus.TabIndex = 8;
            currentStatus.Text = "Waiting...";
            // 
            // statusDisplay
            // 
            statusDisplay.AutoSize = true;
            statusDisplay.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusDisplay.Location = new Point(6, 21);
            statusDisplay.Name = "statusDisplay";
            statusDisplay.Size = new Size(168, 17);
            statusDisplay.TabIndex = 7;
            statusDisplay.Text = "VoidWatch Guardian Status:";
            // 
            // lstWatchedPrograms
            // 
            lstWatchedPrograms.BackgroundColor = SystemColors.WindowFrame;
            lstWatchedPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstWatchedPrograms.Location = new Point(6, 43);
            lstWatchedPrograms.Name = "lstWatchedPrograms";
            lstWatchedPrograms.Size = new Size(628, 323);
            lstWatchedPrograms.TabIndex = 6;
            // 
            // removeFromList
            // 
            removeFromList.ForeColor = Color.Black;
            removeFromList.Location = new Point(640, 79);
            removeFromList.Name = "removeFromList";
            removeFromList.Size = new Size(130, 30);
            removeFromList.TabIndex = 5;
            removeFromList.Text = "Remove";
            removeFromList.UseVisualStyleBackColor = true;
            removeFromList.Click += removeFromList_Click;
            // 
            // addToList
            // 
            addToList.ForeColor = Color.Black;
            addToList.Location = new Point(640, 43);
            addToList.Name = "addToList";
            addToList.Size = new Size(130, 30);
            addToList.TabIndex = 4;
            addToList.Text = "Add";
            addToList.UseVisualStyleBackColor = true;
            addToList.Click += addToList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Controls.Add(startMonitoring);
            Controls.Add(stopMonitoring);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "VoidWatch Guardian [Program & Bot Monitoring]";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lstWatchedPrograms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startMonitoring;
        private Button stopMonitoring;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private GroupBox groupBox1;
        private Button removeFromList;
        private Button addToList;
        private DataGridView lstWatchedPrograms;
        private Label currentStatus;
        private Label statusDisplay;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
