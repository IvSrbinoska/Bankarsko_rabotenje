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

namespace Bankarsko_rabotenje
{
    public partial class PregledKarticki : Form
    {
        public PregledKarticki()
        {
            InitializeComponent();
        }

        private void PregledKarticki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praksaDataSet3.PregledKarticki' table. You can move, or remove it, as needed.
            this.pregledKartickiTableAdapter1.Fill(this.praksaDataSet3.PregledKarticki);
            // TODO: This line of code loads data into the 'praksaDataSet21.card_products' table. You can move, or remove it, as needed.
            this.card_productsTableAdapter.Fill(this.praksaDataSet21.card_products);
            // TODO: This line of code loads data into the 'praksaDataSet1.PregledKarticki' table. You can move, or remove it, as needed.
            this.pregledKartickiTableAdapter.Fill(this.praksaDataSet1.PregledKarticki);

        }

        private void Embg_btn_Click(object sender, EventArgs e)
        {
            SqlConnection kon = new SqlConnection(@"Data Source=MK_2010\IVANASQL;Initial Catalog=Praksa;Integrated Security=True");
            string query = "Select * from PregledKarticki where embg_user = '" + Embg_text.Text + "' ";
            kon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, kon);
            DataTable dtEmbg = new DataTable();
            sda.Fill(dtEmbg);
            if (dtEmbg == null || dtEmbg.Rows.Count == 0)
            {
                MessageBox.Show("Korisnikot ne postoi");
            }
            else
            {
                dataGridView1.DataSource = dtEmbg;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NovaKarticka_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }
    }
}
