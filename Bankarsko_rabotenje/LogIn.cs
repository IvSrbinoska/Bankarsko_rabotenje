using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace Bankarsko_rabotenje
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kreirame object of SqlConnection Class
            //SqlConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Praksa;Integrated Security=True");
            
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();

            string userPwd = "petar1"; // textBox2.Text;
            string userName = "p.petrovski"; // textBox1.Text;
            string query1 = "select * from username_password1 where user_name = '" + userName + "' ";
            string query2 = "select * from username_password1 where password = '" + userPwd + "' ";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, db);
            DataTable dtUserName = new DataTable();
            sda1.Fill(dtUserName);
            
            if (dtUserName == null || dtUserName.Rows.Count == 0)
            {
                MessageBox.Show("Korisnikot ne postoi");
            }
            else
            {
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, db);
                DataTable dtPwd = new DataTable();
                sda2.Fill(dtPwd);

                if (dtPwd == null || dtPwd.Rows.Count == 0)
                {
                    MessageBox.Show("Gresna lozinka");
                }
                else
                {
                    // EXTRA za da se proveri so enkriptiran password od Db
                    string encPwd = sha256_hash(userPwd);
                    if(encPwd.ToUpper() == dtPwd.Rows[0]["EnCrypted"].ToString().ToUpper()){
                        MessageBox.Show("Lozinkata na korisnikot e ISTA so lozinkata vo bazata koja e enkriptirana (za istiot korisnik)");
                    }
                    else
                    {
                        MessageBox.Show("Lozinkata na korisnikot se razlikuva od lozinkata vo bazata koja e enkriptirana (za istiot korisnik)");
                    }


                    DateTime datum = DateTime.Now;
                    string format = "dd.MM.yyyy HH:mm:ss";
                    string query3 = "insert into LOGIN_LOG1(user_name, date_time) values (@username, @data)";
                    SqlCommand cm = new SqlCommand(query3, db);
                    cm.Parameters.AddWithValue("@username", userName);
                    cm.Parameters.AddWithValue("@data", datum);
                    try
                    {
                        cm.ExecuteNonQuery();
                        // kreirame Vraboten vo Memorija
                        string sqlGetUser = "select * from VRABOTEN1 where user_name = '" + userName + "' ";
                        cm = new SqlCommand(sqlGetUser, db);
                        SqlDataAdapter sda = new SqlDataAdapter(cm);
                        DataTable dtUser = new DataTable();
                        sda.Fill(dtUser);
                        if (dtUser.Rows.Count > 0)
                        {
                            Vraboten.Ime = dtUser.Rows[0]["ime"].ToString();
                            Vraboten.Prezime = dtUser.Rows[0]["prezime"].ToString();
                            Vraboten.Sec_level = Convert.ToInt32(dtUser.Rows[0]["sec_level"].ToString());
                            Vraboten.Embg = dtUser.Rows[0]["embg"].ToString();
                            Vraboten.UserName = dtUser.Rows[0]["user_name"].ToString();
                            this.Hide();
                            Menu objMenu = new Menu();
                            objMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Korisnikot ne postoin vo bazata na podatoci.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        //public void SetVraboten(string userName)
        //{
        //    string dbekcija = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        //    SqlConnection con = new SqlConnection(dbekcija);
        //    DataTable Dt = new DataTable();
        //    try
        //    {
        //        string sql = "select * from VRABOTEN1 where user_name = '" + userName + "' ";
        //        SqlCommand cmd = new SqlCommand(sql,con);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        con.Open();
        //        sda.Fill(Dt);
        //        if (Dt == null || Dt.Rows.Count > 0)
        //        {
        //            Vraboten. = userName;
        //            Vraboten.Ime = Dt.Rows[0]["ime"].ToString();
        //            Vraboten.Prezime = Dt.Rows[0]["prezime"].ToString();
        //            Vraboten.sec_level = Convert.ToInt32(Dt.Rows[0]["SEC_LEVEL"]);
        //            Vraboten.embg = Dt.Rows[0]["EMBG"].ToString();
        //        }
        //    }
        //    catch(Exception err)
        //    {
        //        MessageBox.Show(err.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }


        //}



    }
}
