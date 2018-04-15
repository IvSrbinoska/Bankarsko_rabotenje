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
    public partial class PregledTransakcii : Form
    {
        public PregledTransakcii()
        {
            InitializeComponent();
        }

        private void PregledTransakcii_Load(object sender, EventArgs e)
        {
            // read from Database to fill dataGrid
            //
            LoadDataFromDb();

        }
        private void LoadDataFromDb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();

            string sqlCmd = "SELECT * from card_transactions";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd, db);
            DataTable dtCard = new DataTable();
            sqlAdapter.Fill(dtCard);
            //bindingSource.DataSource = dtCard;
            this.gridTransakcii.DataSource = dtCard;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (this.txtFilter.Text.Length == 16)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                SqlConnection db = new SqlConnection(connectionString);
                db.Open();

                string query = "Select * from card_transactions where CardNumber = '" + this.txtFilter.Text + "' ";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, db);
                DataTable data = new DataTable();
                sqlAdapter.Fill(data);
                if (data == null || data.Rows.Count == 0)
                {
                    MessageBox.Show("Kreditnata karticka ne postoi");
                }
                else
                {
                    this.gridTransakcii.DataSource = data;
                }
            }
        }
    }
}
