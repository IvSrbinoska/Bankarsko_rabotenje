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
    public partial class PregledKarticki : Form
    {
        SqlDataAdapter dtaCard = null;
        public PregledKarticki()
        {
            InitializeComponent();
        }

        private void PregledKarticki_Load(object sender, EventArgs e)
        {

            // read from Database to fill dataGrid
            //
            LoadDataFromDb();
        }

        private void LoadDataFromDb(){
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();

            string sqlCmd = "SELECT * from PregledKarticki";
            dtaCard = new SqlDataAdapter(sqlCmd, db);
            DataTable dtCard = new DataTable();
            dtaCard.Fill(dtCard);
            //bindingSource.DataSource = dtCard;
            this.gridIzdadeniKarticki.DataSource = dtCard;
        }
        private void Embg_btn_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();

            string query = "Select * from PregledKarticki where embg_user = '" + Embg_text.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, db);
            DataTable dtEmbg = new DataTable();
            sda.Fill(dtEmbg);
            if (dtEmbg == null || dtEmbg.Rows.Count == 0)
            {
                MessageBox.Show("Korisnikot ne postoi");
                //this.gridIzdadeniKarticki.DataSource = dtEmbg;
            }
            else
            {
                this.gridIzdadeniKarticki.DataSource = dtEmbg;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NovaKarticka_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();

            string query = "Select brand_card, name_series from card_products";
            SqlDataAdapter sda = new SqlDataAdapter(query, db);
            DataTable data = new DataTable();
            sda.Fill(data);
            
            this.dropDownKarticki.DataSource = data;
            dropDownKarticki.DisplayMember = "name_series";
            dropDownKarticki.ValueMember = "brand_card";

        }

        private void dropDownKarticki_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }
        private string GenerateCardNumber(int brandCard)
        {
            string number = "";
            if (brandCard == 1)
            {
                // MASTER
                number = "5214";
            }
            else if (brandCard == 0)
            {
                // VISA
                number = "4327";
            }
            else
            {
                throw new Exception();
            }
            // generiraj 11-set cifren broj
            string random = Create_X_DigitString(11);
            string cifra = PoslednaCifraOdZbir(random);

            return number + random + cifra;
        }
        private static Random RNG = new Random();


        private string Create_X_DigitString(int digit)
        {
            var builder = new StringBuilder();
            while (builder.Length < digit)
            {
                builder.Append(RNG.Next(10).ToString());
            }
            return builder.ToString();
        }

        private string PoslednaCifraOdZbir(string number)
        {
            string cifra = null;
            int suma = 0;
            foreach (char item in number)
            {
                int a = Int32.Parse(item.ToString());
                suma += a;
            }
            string strSuma = suma.ToString();
            cifra = strSuma.Substring(strSuma.Length - 1);
            return cifra;
        }

        private void dropDownKarticki_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRowView selection = (DataRowView)this.dropDownKarticki.SelectedItem;
            int brand = Int32.Parse(selection.Row[0].ToString());

            string cardNumber = GenerateCardNumber(brand);

            string cvc = Create_X_DigitString(3);

            DateTime datumTmp = DateTime.Now.AddYears(3);
            string datum = datumTmp.ToString("MM") + "." + datumTmp.ToString("yyyy");

            this.txtEMBG.Text = "";
            this.txtIme.Text = "ime";
            this.txtPrezime.Text = "prezime";
            this.txtCard.Text = cardNumber;
            this.txtDate.Text = datum;
            this.txtCVC.Text = cvc;

        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            //PopolniImePrezime();

            // zapisi vo Database
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();

            bool statusCard = true;
            // get card name form selected card in drop down
            DataRowView selection = (DataRowView)this.dropDownKarticki.SelectedItem;
            string tipNaKarticka = selection.Row[1].ToString();

            // najdi go id za ovoj tip na karticka
            string query = "Select IDProduct from card_products where name_series = '" + tipNaKarticka + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, db);
            DataTable data = new DataTable();
            sda.Fill(data);
            int IDProduct = -1;
            if(data.Rows.Count > 0){
                IDProduct = Int32.Parse(data.Rows[0]["IDProduct"].ToString());
            }

            if (IDProduct > 0)
            {
                string sqlInsert = "insert cards_issued " +
                    " (CardNumber,month_year_expire, cvc_code, print_name, print_surname, IDProduct, status,embg_user) " +
                    " VALUES (@CardNumber,@month_year_expire, @cvc_code, @print_name, @print_surname, @IDProduct, @status,@embg_user) ";

                SqlCommand cmd = new SqlCommand(sqlInsert, db);
                cmd.Parameters.AddWithValue("@CardNumber", this.txtCard.Text);
                cmd.Parameters.AddWithValue("@month_year_expire", this.txtDate.Text);
                cmd.Parameters.AddWithValue("@cvc_code", this.txtCVC.Text);
                cmd.Parameters.AddWithValue("@print_name", this.txtIme.Text);
                cmd.Parameters.AddWithValue("@print_surname", this.txtPrezime.Text);
                cmd.Parameters.AddWithValue("@IDProduct", IDProduct);
                cmd.Parameters.AddWithValue("@status", statusCard);
                cmd.Parameters.AddWithValue("@embg_user", this.txtEMBG.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    // refresh grid
                    LoadDataFromDb();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else{
                MessageBox.Show("Ne postoi takva karticka vo bazata");
            }

        }

        private void txtEMBG_Leave(object sender, EventArgs e)
        {
            PopolniImePrezime();

        }

        private void PopolniImePrezime(){
            string emb = this.txtEMBG.Text;
            if (!String.IsNullOrEmpty(emb))
            {
                //najdi go vo Db
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                SqlConnection db = new SqlConnection(connectionString);
                db.Open();
                //PregledKarticki
                string query = "Select top 1 * from cards_issued where embg_user = '" + emb + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, db);
                DataTable dtEmbg = new DataTable();
                sda.Fill(dtEmbg);
                if (dtEmbg.Rows.Count > 0)
                {
                    this.txtIme.Text = dtEmbg.Rows[0]["print_name"].ToString();
                    this.txtPrezime.Text = dtEmbg.Rows[0]["print_surname"].ToString();
                }
            }
        }
    }
}



