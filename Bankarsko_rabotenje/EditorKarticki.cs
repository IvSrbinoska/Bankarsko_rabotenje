using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankarsko_rabotenje
{
    public partial class EditorKarticki : Form
    {
        public EditorKarticki()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditorKarticki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praksaDataSet.card_products' table. You can move, or remove it, as needed.
            this.card_productsTableAdapter.Fill(this.praksaDataSet.card_products);

        }

    }
}
