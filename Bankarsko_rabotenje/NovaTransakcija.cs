using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankarsko_rabotenje
{
    public partial class NovaTransakcija : Form
    {
        public NovaTransakcija()
        {
            InitializeComponent();
        }

        private void NovaTransakcija_Load(object sender, EventArgs e)
        {
        }

        private void btnVnes_Click(object sender, EventArgs e)
        {
            //
            // zapisi vo Db
            //
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();
            string sqlInsert = "insert into card_transactions " +
                    " (CardNumber, amount, description, date_processing, date_system_insert, tip_transakcija) " +
                    " VALUES (@CardNumber, @amount, @description, @date_processing, @date_system_insert, @tip_transakcija) ";

            SqlCommand cmdInsert = new SqlCommand(sqlInsert, db);
            cmdInsert.Parameters.AddWithValue("@CardNumber", this.txtCard.Text);
            cmdInsert.Parameters.AddWithValue("@amount", float.Parse(this.txtAmount.Text));
            cmdInsert.Parameters.AddWithValue("@description", this.txtDescription.Text);
            cmdInsert.Parameters.AddWithValue("@date_processing", DateTime.Parse(this.txtDate.Text));
            cmdInsert.Parameters.AddWithValue("@date_system_insert", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("@tip_transakcija", Int32.Parse(this.dropDownSifra.SelectedItem.ToString()));
            
            try
            {
                int i= cmdInsert.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Uspesen vnes!");
                    this.Close();
                }
                else{
                    MessageBox.Show("Greska!");

                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
