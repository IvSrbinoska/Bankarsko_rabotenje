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
    public partial class Obrabotka : Form
    {
        public Obrabotka()
        {
            InitializeComponent();
        }

        private void Obrabotka_Load(object sender, EventArgs e)
        {

        }

        private void btnPresmetaj_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();
            //
            // call stored procedure
            //
            DateTime datum = DateTime.Now;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable data = new DataTable();
            try
            {
                cmd = new SqlCommand("sp_Obrabotka",db);
                cmd.Parameters.Add(new SqlParameter("@datum", datum));
                cmd.CommandType = CommandType.StoredProcedure;
                sqlAdapter.SelectCommand = cmd;
                sqlAdapter.Fill(data);
                this.gridPresmetka.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!  -  " + ex.Message);
            }
            finally{
                db.Close();
            }
    }
}
