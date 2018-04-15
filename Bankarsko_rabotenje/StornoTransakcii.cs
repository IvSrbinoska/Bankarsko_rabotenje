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
    public partial class StornoTransakcii : Form
    {
        public StornoTransakcii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtCreditCard.Text.Length == 16)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                SqlConnection db = new SqlConnection(connectionString);
                db.Open();

                string query = "Select * from card_transactions where CardNumber = '" + this.txtCreditCard.Text + "' ";
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

        private void gridTransakcii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StornoTransakcii_Load(object sender, EventArgs e)
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

        private void btnVnes_Click(object sender, EventArgs e)
        {
            
            NovaTransakcija forma = new NovaTransakcija();

            forma.Show();

        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            if(this.gridTransakcii.SelectedRows.Count == 1){
                DaliSteSIgurni frmDialog = new DaliSteSIgurni();
                DialogResult result = frmDialog.ShowDialog(this);
                if(result == DialogResult.Yes || result == DialogResult.OK){
                    // storniraj ja ovaa transakcija
                    DataGridViewRow row =  this.gridTransakcii.SelectedRows[0];
                    int id = Int32.Parse(row.Cells[0].Value.ToString());
                    
                    string cardNumber = row.Cells[1].Value.ToString();
                    float amount = - float.Parse(row.Cells[2].Value.ToString());
                    string description = "storno " + row.Cells[3].Value.ToString();
                    int stornoReferenca = id;
                    int tipTransakcija = Int32.Parse(row.Cells[6].Value.ToString());

                    string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                    SqlConnection db = new SqlConnection(connectionString);
                    db.Open();
                    string sqlInsert = "insert into card_transactions " +
                " (CardNumber, amount, description, date_processing, date_system_insert, tip_transakcija, storno_referenca) " +
                " VALUES (@CardNumber, @amount, @description, @date_processing, @date_system_insert, @tip_transakcija, @storno_referenca) ";

                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, db);
                    cmdInsert.Parameters.AddWithValue("@CardNumber", cardNumber);
                    cmdInsert.Parameters.AddWithValue("@amount", amount);
                    cmdInsert.Parameters.AddWithValue("@description", description);
                    cmdInsert.Parameters.AddWithValue("@date_processing", DateTime.Now);
                    cmdInsert.Parameters.AddWithValue("@date_system_insert", DateTime.Now);
                    cmdInsert.Parameters.AddWithValue("@tip_transakcija", tipTransakcija);
                    cmdInsert.Parameters.AddWithValue("@storno_referenca", stornoReferenca);

                    try
                    {
                        int i = cmdInsert.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Uspesna promena!");
                        }
                        else
                        {
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
    }
}
