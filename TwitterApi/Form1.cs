﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TwitterApi.Helper;
using TwitterApi.DAO;

namespace TwitterApi
{
    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void konfigurasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            bool control=Validation.RichTextControl(text);
            if (control)
            {
                // Twitter rest api kullanılacak
            }
            else
            {
                MessageBox.Show("Girilen metin 280 karakterden fazla olamaz ve boş bırakılamaz");
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelTweetAl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthInfoDao authDao = new AuthInfoDao();// Veri tabanına kayıt işlemi yapan sınıf 
            AuthInfo info = new AuthInfo();
            info.AccessToken = txtAccessToken.Text;
            info.OAuthConsumerKeyString = txtConsumerKey.Text;
            info.OAuthConsumerSecretString = txtConsumerSecret.Text;
            info.TokenSecret = txtTokenSecret.Text;
            info.GetTwettNumber = int.Parse(txtGetTwettNumber.Text);
            bool control = authDao.Save(info);
            if (control)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }
    }
}
