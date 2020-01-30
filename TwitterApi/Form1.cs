using System;
using System.Windows.Forms;
using TwitterApi.Helper;

namespace TwitterApi
{
    public partial class Form1 : Form
    {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
