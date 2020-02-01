using System;
using System.Windows.Forms;
using TwitterApi.Helper;
using TwitterApi.DAO;
using Tweetinvi;

namespace TwitterApi
{
    public partial class Form1 : Form
    {
        // Veri tabanına kayıt işlemi yapan sınıf Dao nesneleri
        AuthInfoDao authDao = new AuthInfoDao();
        TwetterDAO tweetDAO = new TwetterDAO();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Konfigürasyon Textboxlarına Veri çekme
            var authInfo = authDao.LastRecord();
            txtConsumerKey.Text= authInfo.OAuthConsumerKeyString;
            txtConsumerSecret.Text = authInfo.OAuthConsumerSecretString;
            txtAccessToken.Text = authInfo.AccessToken;
            txtTokenSecret.Text = authInfo.TokenSecret;
            txtGetTwettNumber.Text = authInfo.GetTwettNumber.ToString(); 

            // Twitter api için bilgiler setlendi
            Auth.SetUserCredentials(authInfo.OAuthConsumerKeyString, authInfo.OAuthConsumerSecretString,
                  authInfo.AccessToken, authInfo.TokenSecret);
            //var user = User.GetAuthenticatedUser();
            
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
        }
    }
}
