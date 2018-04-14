namespace Bankarsko_rabotenje
{
    partial class EditorKarticki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cardproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praksaDataSet = new Bankarsko_rabotenje.PraksaDataSet();
            this.card_productsTableAdapter = new Bankarsko_rabotenje.PraksaDataSetTableAdapters.card_productsTableAdapter();
            this.gridCardProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCardProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // cardproductsBindingSource
            // 
            this.cardproductsBindingSource.DataMember = "card_products";
            this.cardproductsBindingSource.DataSource = this.praksaDataSet;
            // 
            // praksaDataSet
            // 
            this.praksaDataSet.DataSetName = "PraksaDataSet";
            this.praksaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // card_productsTableAdapter
            // 
            this.card_productsTableAdapter.ClearBeforeFill = true;
            // 
            // gridCardProducts
            // 
            this.gridCardProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCardProducts.Location = new System.Drawing.Point(11, 11);
            this.gridCardProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridCardProducts.Name = "gridCardProducts";
            this.gridCardProducts.RowTemplate.Height = 24;
            this.gridCardProducts.Size = new System.Drawing.Size(696, 286);
            this.gridCardProducts.TabIndex = 1;
            this.gridCardProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCardProducts_CellEndEdit);
            this.gridCardProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCardProducts_CellMouseClick);
            this.gridCardProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCardProducts_CellValueChanged);
            this.gridCardProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCardProducts_RowEnter);
            this.gridCardProducts.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCardProducts_RowLeave);
            this.gridCardProducts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridCardProducts_RowsAdded);
            this.gridCardProducts.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridCardProducts_UserAddedRow_1);
            this.gridCardProducts.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridCardProducts_UserDeletedRow);
            this.gridCardProducts.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridCardProducts_UserDeletingRow);
            // 
            // EditorKarticki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.gridCardProducts);
            this.Name = "EditorKarticki";
            this.Text = "EditorKarticki";
            this.Load += new System.EventHandler(this.EditorKarticki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCardProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PraksaDataSet praksaDataSet;
        private System.Windows.Forms.BindingSource cardproductsBindingSource;
        private PraksaDataSetTableAdapters.card_productsTableAdapter card_productsTableAdapter;
        private System.Windows.Forms.DataGridView gridCardProducts;
    }
}