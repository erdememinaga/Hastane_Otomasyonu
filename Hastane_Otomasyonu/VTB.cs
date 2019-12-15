 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    class VTB
    {
        public static SqlConnection openConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OFJ0EIO;Initial Catalog=hastane;Integrated Security=True");
            try
            {
                con.Open();
                return con;

            }
            catch (Exception)
            {

                throw;
            }



        }
        public static void connectionClose(SqlConnection con)
        {
            con.Close();
        }

        public static bool userLogin(User u)
        {
            SqlConnection con = openConnection();
            try
            {
                //SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From danisman_kadi where kadi = '" + dakadi.Text + "' and sifre = '" + dapasw.Text + "'", con);

                // Sqlconnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from doktor_kadi where kadi=@userName and sifre=@password", con);
                cmd.Parameters.AddWithValue("@username", u.getUserName());
                cmd.Parameters.AddWithValue("@password", u.getPassword());

                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                    return true;
                else
                    return false;

            }
            catch (Exception e)
            {

                // txt dosyaya veri ekleme yapılsın
                // loglama      id,zaman,hatamesajı,metotismi
                throw;

            }
            finally
            {
                connectionClose(con);
            }



        }

        public static bool user2Login(User u)
        {
            SqlConnection con = openConnection();
            try
            {
                //SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From danisman_kadi where kadi = '" + dakadi.Text + "' and sifre = '" + dapasw.Text + "'", con);

                // Sqlconnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from danisman_kadi where kadi=@userName and sifre=@password", con);
                cmd.Parameters.AddWithValue("@username", u.getUserName());
                cmd.Parameters.AddWithValue("@password", u.getPassword());

                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                    return true;
                else
                    return false;

            }
            catch (Exception e)
            {

                // txt dosyaya veri ekleme yapılsın
                // loglama      id,zaman,hatamesajı,metotismi
                throw;

            }
            finally
            {
                connectionClose(con);
            }


            //insert into Products(ProductName,UnitPrice,UnitsInStock) values(@ProductName, @UnitPrice, @UnitsInStock
        }
        public static bool hasta_kayit(Hasta hasta)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(@"insert into hasta_kayit(hasta_adi, hasta_soyadi, hasta_tc,hasta_dogumT,kayit_tarihi,hasta_tel,hasta_adres) 
                                                    values(@hasta_adi , @hasta_soyadi, @hasta_tc, @hasta_dogumT, @kayit_tarihi, @hasta_tel, @hasta_adres)", con);

                cmd.Parameters.AddWithValue("@hasta_adi", hasta.hasta_adi);
                cmd.Parameters.AddWithValue("@hasta_soyadi", hasta.hasta_soyadi);
                cmd.Parameters.AddWithValue("@hasta_tc", hasta.hasta_tc);
                cmd.Parameters.AddWithValue("@hasta_dogumT", hasta.hasta_dogumT);
        
                cmd.Parameters.AddWithValue("@kayit_tarihi", (DateTime.Now));
                cmd.Parameters.AddWithValue("@hasta_tel", hasta.hasta_tel);
                cmd.Parameters.AddWithValue("@hasta_adres", hasta.hasta_adres);


                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connectionClose(con);
            }
        }
        public static bool randevular(randevu randevu)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(@"insert into randevular(poli_adi, doktor_adi,hasta_tc) 
                                                    values(@poli_adi , @doktor_adi, @hasta_tc)", con);
                cmd.Parameters.AddWithValue("@poli_adi", randevu.poli_adi);
                cmd.Parameters.AddWithValue("@hasta_tc", randevu.hasta_tc);
                cmd.Parameters.AddWithValue("@doktor_adi", randevu.doktor_adi);
             

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connectionClose(con);
            }

        }
    }
}
