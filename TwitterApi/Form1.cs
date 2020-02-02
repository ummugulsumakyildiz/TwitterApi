using System;
using System.Windows.Forms;
using TwitterApi.Helper;
using TwitterApi.DAO;
using Tweetinvi;
using System.Collections.Generic;
using System.Diagnostics;
using Tweetinvi.Parameters;
using TwitterApi.Service;

namespace TwitterApi
{
    public partial class Form1 : Form
    {
        // Veri tabanına kayıt işlemi yapan sınıf Dao nesneleri
        AuthInfoDao authDao = new AuthInfoDao();
        TwetterDAO tweetDAO = new TwetterDAO();
        TweetService tweetService = new TweetService();
        private int count = 20;
        private AuthInfo authInfo = null;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = string.Empty; 
            //Konfigürasyon Textboxlarına Veri çekme  
             authInfo = authDao.LastRecord();
            if (authInfo!=null) 
            {
                txtConsumerKey.Text = authInfo.OAuthConsumerKeyString;
                txtConsumerSecret.Text = authInfo.OAuthConsumerSecretString;
                txtAccessToken.Text = authInfo.AccessToken;
                txtTokenSecret.Text = authInfo.TokenSecret;
                txtGetTwettNumber.Text = authInfo.GetTwettNumber.ToString();
                if (!string.IsNullOrEmpty(txtGetTwettNumber.Text))
                {
                    count = int.Parse(txtGetTwettNumber.Text); 
                }
                // Twitter api için bilgiler setlendi
                Auth.SetUserCredentials(authInfo.OAuthConsumerKeyString, authInfo.OAuthConsumerSecretString,
                      authInfo.AccessToken, authInfo.TokenSecret);
                //var user = User.GetAuthenticatedUser();
            }
            else
            {
                MessageBox.Show("Lütfen Konfigurasyon menüsünden twitter api bilgileri doldurunuz");
                tabControl1.SelectedTab = tabPage4;
            }
            
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
                // Twitter rest api kullanılarak tweet atma
                Tweet.PublishTweet(text);
                richTextBox1.Text = string.Empty;
                // Kullanıcının paylaştığı tweet db ye kaydediliyor
                TweetPost post = new TweetPost();
                post.tweet = text;
                post.username = User.GetAuthenticatedUser().Name;
                post.created_at = DateTime.Now;
                post.type = "tweet_paylas"; 
                // Tweet paylaşma
                tweetService.Post(post.tweet);
              
                bool sonuc = tweetDAO.Save(post);
                if (sonuc)
                {
                    MessageBox.Show("İşlem başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt başarılı değil");
                }
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
            AuthInfo info = new AuthInfo();
            info.AccessToken = txtAccessToken.Text;
            info.OAuthConsumerKeyString = txtConsumerKey.Text;
            info.OAuthConsumerSecretString = txtConsumerSecret.Text;
            info.TokenSecret = txtTokenSecret.Text;
            if (!string.IsNullOrEmpty(txtGetTwettNumber.Text))//  GetTwettNumber null ve boş mu kontrolü yapıldı 
            {
                info.GetTwettNumber = int.Parse(txtGetTwettNumber.Text);
            }
            bool control = authDao.Save(info);
            if (control)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
            // Konfigurasyon ekranından kayıt ettiğim bilgileri setliyorum. 
            authInfo = authDao.LastRecord();
            Auth.SetUserCredentials(authInfo.OAuthConsumerKeyString, authInfo.OAuthConsumerSecretString,
                    authInfo.AccessToken, authInfo.TokenSecret); 
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (authInfo==null)
            {
                tabControl1.SelectedTab = tabPage4;
            }
           
            else if (tabControl1.SelectedTab == tabPage2)
            {
                var liste = tweetService.GetStreams(count);
                liste.ForEach(a=>listBox2.Items.Add(a.FullText));
                bool saveControl = tweetDAO.InsertAllPost(liste, textBox1.Text, "stream"); 
                if (saveControl)
                {
                    MessageBox.Show("İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show("Database kayıt başarısız");
                }
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var tweets = tweetService.GetTweetsByUsername(textBox1.Text,count); 
            bool saveControl =  tweetDAO.InsertAllPost(tweets, textBox1.Text,"tweet_oku");
            
            if (saveControl)
            {
                foreach (var item in tweets)
                {
                    listBox1.Items.Add(item.FullText);
                    listBox1.Items.Add("\n");

                }
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Database kayıt başarısız");
            }
            
        }
    }
}
