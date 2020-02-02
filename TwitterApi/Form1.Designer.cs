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
            this.panelPaylas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTweetAl = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.butonKaydet = new System.Windows.Forms.Button();
            this.txtTokenSecret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsumerSecret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGetTwettNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsumerKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPaylas.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPaylas
            // 
            this.panelPaylas.Controls.Add(this.label1);
            this.panelPaylas.Controls.Add(this.richTextBox1);
            this.panelPaylas.Controls.Add(this.button1);
            this.panelPaylas.Location = new System.Drawing.Point(3, 3);
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
            this.panelTweetAl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTweetAl.Location = new System.Drawing.Point(3, 3);
            this.panelTweetAl.Name = "panelTweetAl";
            this.panelTweetAl.Size = new System.Drawing.Size(830, 603);
            this.panelTweetAl.TabIndex = 2;
            this.panelTweetAl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTweetAl_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 638);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelPaylas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tweet Paylaş";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelTweetAl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Twee Al";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(836, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tweet Oku";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.butonKaydet);
            this.tabPage4.Controls.Add(this.txtTokenSecret);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtAccessToken);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtConsumerSecret);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtGetTwettNumber);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtConsumerKey);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(836, 609);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Konfigürasyon";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // butonKaydet
            // 
            this.butonKaydet.Location = new System.Drawing.Point(229, 296);
            this.butonKaydet.Name = "butonKaydet";
            this.butonKaydet.Size = new System.Drawing.Size(111, 55);
            this.butonKaydet.TabIndex = 10;
            this.butonKaydet.Text = "Kaydet";
            this.butonKaydet.UseVisualStyleBackColor = true;
            this.butonKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTokenSecret
            // 
            this.txtTokenSecret.Location = new System.Drawing.Point(283, 191);
            this.txtTokenSecret.Name = "txtTokenSecret";
            this.txtTokenSecret.Size = new System.Drawing.Size(463, 22);
            this.txtTokenSecret.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "TokenSecret";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(283, 134);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(463, 22);
            this.txtAccessToken.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "AccessToken";
            // 
            // txtConsumerSecret
            // 
            this.txtConsumerSecret.Location = new System.Drawing.Point(283, 83);
            this.txtConsumerSecret.Name = "txtConsumerSecret";
            this.txtConsumerSecret.Size = new System.Drawing.Size(463, 22);
            this.txtConsumerSecret.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "OAuthConsumerSecretString";
            // 
            // txtGetTwettNumber
            // 
            this.txtGetTwettNumber.Location = new System.Drawing.Point(283, 245);
            this.txtGetTwettNumber.Name = "txtGetTwettNumber";
            this.txtGetTwettNumber.Size = new System.Drawing.Size(112, 22);
            this.txtGetTwettNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "GetTwettNumber ";
            // 
            // txtConsumerKey
            // 
            this.txtConsumerKey.Location = new System.Drawing.Point(283, 37);
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.Size = new System.Drawing.Size(463, 22);
            this.txtConsumerKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "OAuthConsumerKeyString";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 652);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TwitterApi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPaylas.ResumeLayout(false);
            this.panelPaylas.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPaylas;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTweetAl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConsumerSecret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGetTwettNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsumerKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTokenSecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butonKaydet;
    }
}

