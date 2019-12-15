using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class danismanlog : Form
    {
        public danismanlog()
        {
            InitializeComponent();
        }

        private void dktrlogbtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.setUserName(dakadi.Text);
            u.setPassword(dapasw.Text);
            try
            {
                if (VTB.user2Login(u))
                {
                    MessageBox.Show("Giriş Başarılı, Sisteme Hoş Geldiniz");
                    DanismanMenu f = new DanismanMenu();
                    f.Show();

                }

                else
                    MessageBox.Show("Şifre veya Kullanıcı adı yanlış ama hangisi söylemem");


            }
            catch (Exception)
            {

                throw;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dapasw_TextChanged(object sender, EventArgs e)
        {
            dapasw.PasswordChar = '*';
        }

        private void dakadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                dapasw.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                dapasw.PasswordChar = '*';
            }
        }
    }
}
