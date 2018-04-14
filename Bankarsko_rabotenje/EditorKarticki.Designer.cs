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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.praksaDataSet = new Bankarsko_rabotenje.PraksaDataSet();
            this.cardproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.card_productsTableAdapter = new Bankarsko_rabotenje.PraksaDataSetTableAdapters.card_productsTableAdapter();
            this.iDProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameseriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitcreditDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.brandcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductDataGridViewTextBoxColumn,
            this.nameseriesDataGridViewTextBoxColumn,
            this.debitcreditDataGridViewCheckBoxColumn,
            this.brandcardDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cardproductsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // praksaDataSet
            // 
            this.praksaDataSet.DataSetName = "PraksaDataSet";
            this.praksaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardproductsBindingSource
            // 
            this.cardproductsBindingSource.DataMember = "card_products";
            this.cardproductsBindingSource.DataSource = this.praksaDataSet;
            // 
            // card_productsTableAdapter
            // 
            this.card_productsTableAdapter.ClearBeforeFill = true;
            // 
            // iDProductDataGridViewTextBoxColumn
            // 
            this.iDProductDataGridViewTextBoxColumn.DataPropertyName = "IDProduct";
            this.iDProductDataGridViewTextBoxColumn.HeaderText = "IDProduct";
            this.iDProductDataGridViewTextBoxColumn.Name = "iDProductDataGridViewTextBoxColumn";
            this.iDProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameseriesDataGridViewTextBoxColumn
            // 
            this.nameseriesDataGridViewTextBoxColumn.DataPropertyName = "name_series";
            this.nameseriesDataGridViewTextBoxColumn.HeaderText = "name_series";
            this.nameseriesDataGridViewTextBoxColumn.Name = "nameseriesDataGridViewTextBoxColumn";
            // 
            // debitcreditDataGridViewCheckBoxColumn
            // 
            this.debitcreditDataGridViewCheckBoxColumn.DataPropertyName = "debit_credit";
            this.debitcreditDataGridViewCheckBoxColumn.HeaderText = "debit_credit";
            this.debitcreditDataGridViewCheckBoxColumn.Name = "debitcreditDataGridViewCheckBoxColumn";
            // 
            // brandcardDataGridViewTextBoxColumn
            // 
            this.brandcardDataGridViewTextBoxColumn.DataPropertyName = "brand_card";
            this.brandcardDataGridViewTextBoxColumn.HeaderText = "brand_card";
            this.brandcardDataGridViewTextBoxColumn.Name = "brandcardDataGridViewTextBoxColumn";
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "fees";
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            // 
            // EditorKarticki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditorKarticki";
            this.Text = "EditorKarticki";
            this.Load += new System.EventHandler(this.EditorKarticki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PraksaDataSet praksaDataSet;
        private System.Windows.Forms.BindingSource cardproductsBindingSource;
        private PraksaDataSetTableAdapters.card_productsTableAdapter card_productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameseriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn debitcreditDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
    }
}