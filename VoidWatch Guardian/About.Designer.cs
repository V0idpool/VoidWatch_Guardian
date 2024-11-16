namespace VoidWatchDog
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            nsGroupBox1 = new Voidbot_Discord_Bot_GUI.NSGroupBox();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            nsGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nsGroupBox1
            // 
            nsGroupBox1.BackColor = Color.FromArgb(30, 30, 30);
            nsGroupBox1.Controls.Add(linkLabel5);
            nsGroupBox1.Controls.Add(linkLabel4);
            nsGroupBox1.Controls.Add(linkLabel3);
            nsGroupBox1.Controls.Add(linkLabel2);
            nsGroupBox1.Controls.Add(linkLabel1);
            nsGroupBox1.Controls.Add(label1);
            nsGroupBox1.DrawSeperator = false;
            nsGroupBox1.Location = new Point(12, 12);
            nsGroupBox1.Name = "nsGroupBox1";
            nsGroupBox1.Size = new Size(784, 406);
            nsGroupBox1.SubTitle = "VoidWatch Guardian - A Reliable Monitoring Solution";
            nsGroupBox1.TabIndex = 2;
            nsGroupBox1.Text = "nsGroupBox1";
            nsGroupBox1.Title = "About VoidWatch Guardian";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Segoe UI", 9.75F);
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(87, 124);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(173, 17);
            linkLabel5.TabIndex = 11;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "https://github.com/V0idpool";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Segoe UI", 9.75F);
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(183, 224);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(189, 17);
            linkLabel4.TabIndex = 10;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "https://discord.gg/nsSpGJ5saD";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 9.75F);
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(123, 204);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(117, 17);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "https://voidbot.lol/";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9.75F);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(170, 304);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(181, 17);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://cash.app/$KenM1337/";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(210, 283);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(247, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.buymeacoffee.com/voidpool";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 177, 165);
            label1.Location = new Point(8, 43);
            label1.Name = "label1";
            label1.Size = new Size(767, 340);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(807, 429);
            Controls.Add(nsGroupBox1);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "About";
            Text = "About";
            nsGroupBox1.ResumeLayout(false);
            nsGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Voidbot_Discord_Bot_GUI.NSGroupBox nsGroupBox1;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}