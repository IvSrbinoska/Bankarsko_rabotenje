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
    public partial class EditorKarticki : Form
    {

        SqlDataAdapter dtaCard = null;
        bool adding = false;
        private BindingSource bindingSource = new BindingSource();

        public EditorKarticki()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void EditorKarticki_Load(object sender, EventArgs e)
        {

            //this.gridCardProducts.DataSource = bindingSource;




            // TODO: This line of code loads data into the 'praksaDataSet.card_products' table. You can move, or remove it, as needed.
            //this.card_productsTableAdapter.Fill(this.praksaDataSet.card_products);
            
            
            
            //
            // read from Database to fill dataGrid
            //
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();
            
            string sqlCmd = "Select * from card_products";
            dtaCard = new SqlDataAdapter(sqlCmd, db);
            DataTable dtCard = new DataTable();
            dtaCard.Fill(dtCard);
            //bindingSource.DataSource = dtCard;
            this.gridCardProducts.DataSource = dtCard;


        }

        private void gridCardProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            ////
            //// UPDATE all cells from edited row
            ////
            //DataTable dt = (DataTable)this.gridCardProducts.DataSource;
            //string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            //SqlConnection db = new SqlConnection(connectionString);
            //db.Open();
            ////string sqlUpdate = "update card_products set " +
            ////                " name_series = @name_series," +
            ////                " debit_credit = @debit_credit, " +
            ////                " brand_card = @brand_card," +
            ////                " fees = @fees " +
            ////                " where IDProduct = @id";

            ////int row = e.RowIndex;
            ////SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, db);
            ////cmdUpdate.Parameters.AddWithValue("@id", dt.Rows[row]["IDProduct"]);
            ////cmdUpdate.Parameters.AddWithValue("@name_series", dt.Rows[row]["name_series"]);
            ////cmdUpdate.Parameters.AddWithValue("@debit_credit", dt.Rows[row]["debit_credit"]);
            ////cmdUpdate.Parameters.AddWithValue("@brand_card", dt.Rows[row]["brand_card"]);
            ////cmdUpdate.Parameters.AddWithValue("@fees", dt.Rows[row]["fees"]);
            ////try
            ////{
            ////    cmdUpdate.ExecuteNonQuery();
            ////}
            ////catch (Exception)
            ////{

            ////    throw;
            ////}


            //// experiment
            ////
            //// UPDATE ONY edited cell (one) from edited row
            ////
            //int row = e.RowIndex;
            //int col = e.ColumnIndex;
            //string dbKolona = "";
            //if(col == 1){
            //    dbKolona = "name_series";
            //}
            //else if(col == 2){
            //    dbKolona = "debit_credit";

            //}
            //else if (col == 3)
            //{
            //    dbKolona = "brand_card";

            //}
            //else if (col == 4)
            //{
            //    dbKolona = "fees";

            //}

            //var gridItemID = dt.Rows[row][0];
            //SqlCommand cmdUpdate = new SqlCommand();
            //cmdUpdate.Connection = db;
            //cmdUpdate.Parameters.AddWithValue("@id", gridItemID);
            //cmdUpdate.Parameters.AddWithValue("@param", dt.Rows[row][col]);
            //string sqlUpdate = "update card_products set " + 
            //                dbKolona + " = @param " +
            //               " where IDProduct = @id";
            //cmdUpdate.CommandText = sqlUpdate;

            //try
            //{
            //    if (gridItemID != null && (int)gridItemID > 0)
            //    {
            //        cmdUpdate.ExecuteNonQuery();
            //    }
            //    else{
            //        //
            //        // ADD
            //        //
            //        string sqlInsert = "insert into card_products (name_series,debit_credit,brand_card,fees) " +
            //                " VALUES (@name_series,@debit_credit,@brand_card,@fees) ";

            //        SqlCommand cmdInsert = new SqlCommand(sqlInsert, db);
            //        cmdUpdate.Parameters.AddWithValue("@name_series", dt.Rows[row]["name_series"]);
            //        cmdUpdate.Parameters.AddWithValue("@debit_credit", dt.Rows[row]["debit_credit"]);
            //        cmdUpdate.Parameters.AddWithValue("@brand_card", dt.Rows[row]["brand_card"]);
            //        cmdUpdate.Parameters.AddWithValue("@fees", dt.Rows[row]["fees"]);
            //        cmdUpdate.ExecuteNonQuery();

            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}



           




            ////int rowsUpdated = writeAdapter.Update(dt);



        }

        private void gridCardProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gridCardProducts_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           if(adding){
                // add row to Database
                //DataTable dt = (DataTable)this.gridCardProducts.DataSource;
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                SqlConnection db = new SqlConnection(connectionString);
                db.Open();
                string sqlInsert = "insert into card_products (name_series,debit_credit,brand_card,fees) " +
                        " VALUES (@name_series,@debit_credit,@brand_card,@fees) ";

                SqlCommand cmdInsert = new SqlCommand(sqlInsert, db);
                cmdInsert.Parameters.AddWithValue("@name_series", this.gridCardProducts.Rows[this.gridCardProducts.RowCount-1].Cells[1].Value);
                cmdInsert.Parameters.AddWithValue("@debit_credit", this.gridCardProducts.Rows[this.gridCardProducts.RowCount-1].Cells[2].Value);
                cmdInsert.Parameters.AddWithValue("@brand_card", this.gridCardProducts.Rows[this.gridCardProducts.RowCount-1].Cells[3].Value);
                cmdInsert.Parameters.AddWithValue("@fees", this.gridCardProducts.Rows[this.gridCardProducts.RowCount-1].Cells[4].Value);
                try
                {
                    cmdInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw;
                }
                adding = false;

           }
            
        }

        private void gridCardProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int count = e.RowCount;
            

        }
        private void gridCardProducts_UserAddedRow_1(object sender, DataGridViewRowEventArgs e){
            adding = true;

        }
        //private void gridCardProducts_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        //    SqlConnection db = new SqlConnection(connectionString);
        //    db.Open();
        //    string sqlUpdate = "insert into card_products (name_series,debit_credit,brand_card,fees) " +
        //                    " VALUES (@name_series,@debit_credit,@brand_card,@fees) ";

        //    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, db);
        //    //cmdUpdate.Parameters.AddWithValue("@id", e.Row.Cells[0]);
        //    cmdUpdate.Parameters.AddWithValue("@name_series", e.Row.Cells[1]);
        //    cmdUpdate.Parameters.AddWithValue("@debit_credit", e.Row.Cells[2]);
        //    cmdUpdate.Parameters.AddWithValue("@brand_card", e.Row.Cells[3]);
        //    cmdUpdate.Parameters.AddWithValue("@fees", e.Row.Cells[4]);
        //    try
        //    {
        //        cmdUpdate.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        //}

        private void gridCardProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool editRow = true;
        }

        private void gridCardProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // UPDATE all cells from edited row
            //
            if(adding){
                return;
            }
            DataTable dt = (DataTable)this.gridCardProducts.DataSource;
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();
            //string sqlUpdate = "update card_products set " +
            //                " name_series = @name_series," +
            //                " debit_credit = @debit_credit, " +
            //                " brand_card = @brand_card," +
            //                " fees = @fees " +
            //                " where IDProduct = @id";

            //int row = e.RowIndex;
            //SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, db);
            //cmdUpdate.Parameters.AddWithValue("@id", dt.Rows[row]["IDProduct"]);
            //cmdUpdate.Parameters.AddWithValue("@name_series", dt.Rows[row]["name_series"]);
            //cmdUpdate.Parameters.AddWithValue("@debit_credit", dt.Rows[row]["debit_credit"]);
            //cmdUpdate.Parameters.AddWithValue("@brand_card", dt.Rows[row]["brand_card"]);
            //cmdUpdate.Parameters.AddWithValue("@fees", dt.Rows[row]["fees"]);
            //try
            //{
            //    cmdUpdate.ExecuteNonQuery();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            // experiment
            //
            // UPDATE ONY edited cell (one) from edited row
            //
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            string dbKolona = "";
            if (col == 1)
            {
                dbKolona = "name_series";
            }
            else if (col == 2)
            {
                dbKolona = "debit_credit";

            }
            else if (col == 3)
            {
                dbKolona = "brand_card";

            }
            else if (col == 4)
            {
                dbKolona = "fees";

            }

            var gridItemID = dt.Rows[row][0];
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = db;
            cmdUpdate.Parameters.AddWithValue("@id", gridItemID);
            cmdUpdate.Parameters.AddWithValue("@param", dt.Rows[row][col]);
            string sqlUpdate = "update card_products set " +
                            dbKolona + " = @param " +
                           " where IDProduct = @id";
            cmdUpdate.CommandText = sqlUpdate;

            try
            {
                if (gridItemID != null && (int)gridItemID > 0)
                {
                    cmdUpdate.ExecuteNonQuery();
                }
                //else
                //{
                //    //
                //    // ADD
                //    //
                //    string sqlInsert = "insert into card_products (name_series,debit_credit,brand_card,fees) " +
                //            " VALUES (@name_series,@debit_credit,@brand_card,@fees) ";

                //    SqlCommand cmdInsert = new SqlCommand(sqlInsert, db);
                //    cmdUpdate.Parameters.AddWithValue("@name_series", dt.Rows[row]["name_series"]);
                //    cmdUpdate.Parameters.AddWithValue("@debit_credit", dt.Rows[row]["debit_credit"]);
                //    cmdUpdate.Parameters.AddWithValue("@brand_card", dt.Rows[row]["brand_card"]);
                //    cmdUpdate.Parameters.AddWithValue("@fees", dt.Rows[row]["fees"]);
                //    cmdUpdate.ExecuteNonQuery();

                //}
            }
            catch (Exception)
            {

                throw;
            }








            //int rowsUpdated = writeAdapter.Update(dt);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gridCardProducts_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int a = 4;
        }

        private void gridCardProducts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            db.Open();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = db;
            
            int id = (int)e.Row.Cells[0].Value;

            cmdDelete.Parameters.AddWithValue("@id", id);
            string sqlDelete = "delete from card_products where IDProduct = @id ";
            cmdDelete.CommandText = sqlDelete;
            try
            {
                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw;
            }



        }
    }

}
