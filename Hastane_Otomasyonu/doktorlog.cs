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
    public partial class doktorlog : Form
    {
        public doktorlog()
        {
            InitializeComponent();
        }

        private void doktorlog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dokadi_TextChanged(object sender, EventArgs e)
        {
    
        }
      
        private void dktrlogbtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.setUserName(dokadi.Text);
            u.setPassword(dopasw.Text);
            try
            {
                if (VTB.userLogin(u))
                {
                    MessageBox.Show("Welcome");
                    DoktorMenu f = new DoktorMenu();
                    f.Show();

                }

                else
                    MessageBox.Show("Sorry");


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dopasw_TextChanged(object sender, EventArgs e)
        {
            dopasw.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
                //checkBox işaretli ise
                if (checkBox1.Checked)
                {
                    //karakteri göster.
                    dopasw.PasswordChar =  '\0';
            }
                //değilse karakterlerin yerine * koy.
                else
                {
                    dopasw.PasswordChar = '*';
            }
            }
    }
}
