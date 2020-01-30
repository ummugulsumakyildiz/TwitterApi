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
            this.menuItemPaylas = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tweetOkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPaylas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTweetAl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelPaylas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPaylas,
            this.denemeToolStripMenuItem,
            this.tweetOkuToolStripMenuItem,
            this.konfigurasyonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemPaylas
            // 
            this.menuItemPaylas.Name = "menuItemPaylas";
            this.menuItemPaylas.Size = new System.Drawing.Size(106, 24);
            this.menuItemPaylas.Text = "Tweet Paylaş";
            this.menuItemPaylas.Click += new System.EventHandler(this.menuItemPaylas_Click);
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.denemeToolStripMenuItem.Text = "Tweet Al";
            this.denemeToolStripMenuItem.Click += new System.EventHandler(this.denemeToolStripMenuItem_Click);
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
            // panelPaylas
            // 
            this.panelPaylas.Controls.Add(this.label1);
            this.panelPaylas.Controls.Add(this.richTextBox1);
            this.panelPaylas.Controls.Add(this.button1);
            this.panelPaylas.Location = new System.Drawing.Point(34, 42);
            this.panelPaylas.Name = "panelPaylas";
            this.panelPaylas.Size = new System.Drawing.Size(689, 157);
            this.panelPaylas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 101);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTweetAl
            // 
            this.panelTweetAl.Location = new System.Drawing.Point(34, 42);
            this.panelTweetAl.Name = "panelTweetAl";
            this.panelTweetAl.Size = new System.Drawing.Size(763, 527);
            this.panelTweetAl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 652);
            this.Controls.Add(this.panelTweetAl);
            this.Controls.Add(this.panelPaylas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TwitterApi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPaylas.ResumeLayout(false);
            this.panelPaylas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaylas;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tweetOkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurasyonToolStripMenuItem;
        private System.Windows.Forms.Panel panelPaylas;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTweetAl;
    }
}

