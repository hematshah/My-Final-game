namespace MonsterOnTheRunVersion2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.block = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Door = new System.Windows.Forms.Panel();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.playtimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: 0";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Black;
            this.screen.BackgroundImage = global::MonsterOnTheRunVersion2.Properties.Resources._59090eec_cb40_4af1_9fe0_cbeabae096af;
            this.screen.Controls.Add(this.panel3);
            this.screen.Controls.Add(this.panel2);
            this.screen.Controls.Add(this.block);
            this.screen.Controls.Add(this.panel1);
            this.screen.Controls.Add(this.Player);
            this.screen.Controls.Add(this.panel4);
            this.screen.Controls.Add(this.Door);
            this.screen.Location = new System.Drawing.Point(0, 1);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(580, 600);
            this.screen.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::MonsterOnTheRunVersion2.Properties.Resources.Tile_15_150x50;
            this.panel3.Location = new System.Drawing.Point(87, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 50);
            this.panel3.TabIndex = 4;
            this.panel3.Tag = "platform";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::MonsterOnTheRunVersion2.Properties.Resources.Tile_14_150x50;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 50);
            this.panel2.TabIndex = 2;
            this.panel2.Tag = "platform";
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Transparent;
            this.block.BackgroundImage = global::MonsterOnTheRunVersion2.Properties.Resources.Tile_12_150x50;
            this.block.Location = new System.Drawing.Point(183, 209);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(400, 50);
            this.block.TabIndex = 1;
            this.block.Tag = "platform";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MonsterOnTheRunVersion2.Properties.Resources.Tile_12_150x50;
            this.panel1.Location = new System.Drawing.Point(432, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 50);
            this.panel1.TabIndex = 3;
            this.panel1.Tag = "platform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Image = global::MonsterOnTheRunVersion2.Properties.Resources.StandingStill;
            this.Player.Location = new System.Drawing.Point(375, 163);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(81, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::MonsterOnTheRunVersion2.Properties.Resources.Tile_14_150x50;
            this.panel4.Location = new System.Drawing.Point(0, 544);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 50);
            this.panel4.TabIndex = 3;
            this.panel4.Tag = "platform";
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.Transparent;
            this.Door.BackgroundImage = global::MonsterOnTheRunVersion2.Properties.Resources.DoorOpen_109x170;
            this.Door.Location = new System.Drawing.Point(474, 43);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(109, 170);
            this.Door.TabIndex = 2;
            this.Door.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "PlatformGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel block;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Door;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Player;
    }
}

