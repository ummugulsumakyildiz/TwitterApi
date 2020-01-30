namespace TwitterApi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tweetOkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.denemeToolStripMenuItem,
            this.tweetOkuToolStripMenuItem,
            this.konfigurasyonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.testToolStripMenuItem.Text = "Tweet Paylaş";
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.denemeToolStripMenuItem.Text = "Tweet Al";
            // 
            // tweetOkuToolStripMenuItem
            // 
            this.tweetOkuToolStripMenuItem.Name = "tweetOkuToolStripMenuItem";
            this.tweetOkuToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.tweetOkuToolStripMenuItem.Text = "Tweet Oku";
            // 
            // konfigurasyonToolStripMenuItem
            // 
            this.konfigurasyonToolStripMenuItem.Name = "konfigurasyonToolStripMenuItem";
            this.konfigurasyonToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.konfigurasyonToolStripMenuItem.Text = "Konfigürasyon";
            this.konfigurasyonToolStripMenuItem.Click += new System.EventHandler(this.konfigurasyonToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 652);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TwitterApi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tweetOkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurasyonToolStripMenuItem;
    }
}

