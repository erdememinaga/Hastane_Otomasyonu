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
    public partial class DanismanMenu : Form
    {
        public DanismanMenu()
        {
            InitializeComponent();
        }

        private void hastaKAyıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hasta h = new Hasta()
            {


                hasta_adi = hasta_isim.Text,
                hasta_soyadi = hasta_soyisim.Text,
                hasta_tc = Convert.ToInt64(hasta_tc.Text),

                hasta_tel = Convert.ToInt64(hasta_tel.Text),
                hasta_adres = hasta_adres.Text,
                hasta_dogumT = Convert.ToDateTime(hasta_dogumT.Text)

            };
            randevu r = new randevu()
            {


                doktor_adi = doktor_sec.GetItemText(doktor_sec.SelectedItem),
                poli_adi = poli_sec.GetItemText(poli_sec.SelectedItem),
                hasta_tc = Convert.ToInt64(hasta_tc.Text)
            };


            try
            {
                if (VTB.hasta_kayit(h) && VTB.randevular(r))
                {
                    MessageBox.Show("kayıt Başarılı");

                }
                else
                {
                    MessageBox.Show("kayıt başarısız");
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con;
        private void DanismanMenu_Load(object sender, EventArgs e)
        {



            con = new SqlConnection("Data Source=DESKTOP-OFJ0EIO;Initial Catalog=hastane;Integrated Security=True");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from poliklinikler ORDER BY poliklinik_id ASC ", con);
            da.Fill(dt);
            poli_sec.ValueMember = "poliklinik_id";
            poli_sec.DisplayMember = "poliklinik_adi";
            poli_sec.DataSource = dt;


        }

        private void hasta_adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select *from tahliller where tahlil_kisi like '%" + textBox1.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();


        }

        private void poli_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (poli_sec.SelectedIndex != -1)
            {
                //con = new SqlConnection("Data Source=DESKTOP-OFJ0EIO;Initial Catalog=hastane;Integrated Security=True");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from doktor_kadi where poli_id = " + poli_sec.SelectedValue, con);
                da.Fill(dt);
                doktor_sec.ValueMember = "doktor_id";
                doktor_sec.DisplayMember = "kadi";
                doktor_sec.DataSource = dt;
            }
        }

        private void doktor_sec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tahlillerigöster("select *from tahliller");

        }
        public void tahlillerigöster(string tahlil)
        {
            SqlDataAdapter da = new SqlDataAdapter(tahlil, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        public void hastalarigöster(string tahlil)
        {
            SqlDataAdapter da = new SqlDataAdapter(tahlil, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select *from hasta_kayit where hasta_tc like '%" + textBox2.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hastalarigöster("select *from hasta_kayit");
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void guncelle_Click_1(object sender, EventArgs e)
        {
            
           
        }
    }

   
}
