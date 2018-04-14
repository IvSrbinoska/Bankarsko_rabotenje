namespace Bankarsko_rabotenje
{
    partial class PregledKarticki
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
            this.praksaDataSet1 = new Bankarsko_rabotenje.PraksaDataSet1();
            this.pregledKartickiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledKartickiTableAdapter = new Bankarsko_rabotenje.PraksaDataSet1TableAdapters.PregledKartickiTableAdapter();
            this.Embg_btn = new System.Windows.Forms.Button();
            this.Embg_text = new System.Windows.Forms.TextBox();
            this.NovaKarticka_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEMBG = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblEMBG = new System.Windows.Forms.Label();
            this.dropDownKarticki = new System.Windows.Forms.ComboBox();
            this.cardproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praksaDataSet21 = new Bankarsko_rabotenje.PraksaDataSet2();
            this.praksaDataSet2 = new Bankarsko_rabotenje.PraksaDataSet();
            this.card_productsTableAdapter = new Bankarsko_rabotenje.PraksaDataSet2TableAdapters.card_productsTableAdapter();
            this.pregledKartickiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praksaDataSet3 = new Bankarsko_rabotenje.PraksaDataSet3();
            this.pregledKartickiTableAdapter1 = new Bankarsko_rabotenje.PraksaDataSet3TableAdapters.PregledKartickiTableAdapter();
            this.gridIzdadeniKarticki = new System.Windows.Forms.DataGridView();
            this.btnVnesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzdadeniKarticki)).BeginInit();
            this.SuspendLayout();
            // 
            // praksaDataSet1
            // 
            this.praksaDataSet1.DataSetName = "PraksaDataSet1";
            this.praksaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledKartickiBindingSource
            // 
            this.pregledKartickiBindingSource.DataMember = "PregledKarticki";
            this.pregledKartickiBindingSource.DataSource = this.praksaDataSet1;
            // 
            // pregledKartickiTableAdapter
            // 
            this.pregledKartickiTableAdapter.ClearBeforeFill = true;
            // 
            // Embg_btn
            // 
            this.Embg_btn.Location = new System.Drawing.Point(308, -1);
            this.Embg_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Embg_btn.Name = "Embg_btn";
            this.Embg_btn.Size = new System.Drawing.Size(100, 28);
            this.Embg_btn.TabIndex = 1;
            this.Embg_btn.Text = "EMBG";
            this.Embg_btn.UseVisualStyleBackColor = true;
            this.Embg_btn.Click += new System.EventHandler(this.Embg_btn_Click);
            // 
            // Embg_text
            // 
            this.Embg_text.Location = new System.Drawing.Point(29, 2);
            this.Embg_text.Margin = new System.Windows.Forms.Padding(4);
            this.Embg_text.Name = "Embg_text";
            this.Embg_text.Size = new System.Drawing.Size(271, 22);
            this.Embg_text.TabIndex = 2;
            // 
            // NovaKarticka_btn
            // 
            this.NovaKarticka_btn.Location = new System.Drawing.Point(167, 414);
            this.NovaKarticka_btn.Margin = new System.Windows.Forms.Padding(4);
            this.NovaKarticka_btn.Name = "NovaKarticka_btn";
            this.NovaKarticka_btn.Size = new System.Drawing.Size(109, 28);
            this.NovaKarticka_btn.TabIndex = 3;
            this.NovaKarticka_btn.Text = "NovaKarticka";
            this.NovaKarticka_btn.UseVisualStyleBackColor = true;
            this.NovaKarticka_btn.Click += new System.EventHandler(this.NovaKarticka_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVnesi);
            this.panel1.Controls.Add(this.txtCVC);
            this.panel1.Controls.Add(this.lblCVC);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtCard);
            this.panel1.Controls.Add(this.txtPrezime);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.txtEMBG);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblCard);
            this.panel1.Controls.Add(this.lblPrezime);
            this.panel1.Controls.Add(this.lblIme);
            this.panel1.Controls.Add(this.lblEMBG);
            this.panel1.Controls.Add(this.dropDownKarticki);
            this.panel1.Location = new System.Drawing.Point(304, 410);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 281);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(248, 213);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVC.Multiline = true;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.ReadOnly = true;
            this.txtCVC.Size = new System.Drawing.Size(132, 24);
            this.txtCVC.TabIndex = 12;
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(39, 217);
            this.lblCVC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(35, 17);
            this.lblCVC.TabIndex = 11;
            this.lblCVC.Text = "CVC";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(248, 175);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(132, 22);
            this.txtDate.TabIndex = 10;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(248, 142);
            this.txtCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtCard.Name = "txtCard";
            this.txtCard.ReadOnly = true;
            this.txtCard.Size = new System.Drawing.Size(275, 22);
            this.txtCard.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(248, 110);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(275, 22);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(248, 79);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(275, 22);
            this.txtIme.TabIndex = 7;
            // 
            // txtEMBG
            // 
            this.txtEMBG.Location = new System.Drawing.Point(248, 46);
            this.txtEMBG.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMBG.Name = "txtEMBG";
            this.txtEMBG.Size = new System.Drawing.Size(275, 22);
            this.txtEMBG.TabIndex = 6;
            this.txtEMBG.Leave += new System.EventHandler(this.txtEMBG_Leave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 183);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(146, 17);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Datum Na Istekuvanje";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(35, 145);
            this.lblCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(77, 17);
            this.lblCard.TabIndex = 4;
            this.lblCard.Text = "Br Karticka";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(35, 110);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 17);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(35, 79);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 17);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime";
            // 
            // lblEMBG
            // 
            this.lblEMBG.AutoSize = true;
            this.lblEMBG.Location = new System.Drawing.Point(35, 46);
            this.lblEMBG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEMBG.Name = "lblEMBG";
            this.lblEMBG.Size = new System.Drawing.Size(48, 17);
            this.lblEMBG.TabIndex = 1;
            this.lblEMBG.Text = "EMBG";
            // 
            // dropDownKarticki
            // 
            this.dropDownKarticki.DataSource = this.cardproductsBindingSource;
            this.dropDownKarticki.DisplayMember = "name_series";
            this.dropDownKarticki.FormattingEnabled = true;
            this.dropDownKarticki.Location = new System.Drawing.Point(4, 4);
            this.dropDownKarticki.Margin = new System.Windows.Forms.Padding(4);
            this.dropDownKarticki.Name = "dropDownKarticki";
            this.dropDownKarticki.Size = new System.Drawing.Size(214, 24);
            this.dropDownKarticki.TabIndex = 0;
            this.dropDownKarticki.ValueMember = "name_series";
            this.dropDownKarticki.SelectedIndexChanged += new System.EventHandler(this.dropDownKarticki_SelectedIndexChanged_1);
            // 
            // cardproductsBindingSource
            // 
            this.cardproductsBindingSource.DataMember = "card_products";
            this.cardproductsBindingSource.DataSource = this.praksaDataSet21;
            // 
            // praksaDataSet21
            // 
            this.praksaDataSet21.DataSetName = "PraksaDataSet2";
            this.praksaDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praksaDataSet2
            // 
            this.praksaDataSet2.DataSetName = "PraksaDataSet";
            this.praksaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // card_productsTableAdapter
            // 
            this.card_productsTableAdapter.ClearBeforeFill = true;
            // 
            // pregledKartickiBindingSource1
            // 
            this.pregledKartickiBindingSource1.DataMember = "PregledKarticki";
            this.pregledKartickiBindingSource1.DataSource = this.praksaDataSet3;
            // 
            // praksaDataSet3
            // 
            this.praksaDataSet3.DataSetName = "PraksaDataSet3";
            this.praksaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledKartickiTableAdapter1
            // 
            this.pregledKartickiTableAdapter1.ClearBeforeFill = true;
            // 
            // gridIzdadeniKarticki
            // 
            this.gridIzdadeniKarticki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIzdadeniKarticki.Location = new System.Drawing.Point(26, 37);
            this.gridIzdadeniKarticki.Name = "gridIzdadeniKarticki";
            this.gridIzdadeniKarticki.RowTemplate.Height = 24;
            this.gridIzdadeniKarticki.Size = new System.Drawing.Size(971, 278);
            this.gridIzdadeniKarticki.TabIndex = 5;
            // 
            // btnVnesi
            // 
            this.btnVnesi.Location = new System.Drawing.Point(448, 244);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(75, 23);
            this.btnVnesi.TabIndex = 13;
            this.btnVnesi.Text = "Vnesi";
            this.btnVnesi.UseVisualStyleBackColor = true;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            // 
            // PregledKarticki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 704);
            this.Controls.Add(this.gridIzdadeniKarticki);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NovaKarticka_btn);
            this.Controls.Add(this.Embg_text);
            this.Controls.Add(this.Embg_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PregledKarticki";
            this.Text = "PregledKarticki";
            this.Load += new System.EventHandler(this.PregledKarticki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzdadeniKarticki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PraksaDataSet1 praksaDataSet1;
        private System.Windows.Forms.BindingSource pregledKartickiBindingSource;
        private PraksaDataSet1TableAdapters.PregledKartickiTableAdapter pregledKartickiTableAdapter;
        private System.Windows.Forms.Button Embg_btn;
        private System.Windows.Forms.TextBox Embg_text;
        private System.Windows.Forms.Button NovaKarticka_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dropDownKarticki;
        private PraksaDataSet praksaDataSet2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEMBG;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblEMBG;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label lblCVC;
        private PraksaDataSet2 praksaDataSet21;
        private System.Windows.Forms.BindingSource cardproductsBindingSource;
        private PraksaDataSet2TableAdapters.card_productsTableAdapter card_productsTableAdapter;
        private PraksaDataSet3 praksaDataSet3;
        private System.Windows.Forms.BindingSource pregledKartickiBindingSource1;
        private PraksaDataSet3TableAdapters.PregledKartickiTableAdapter pregledKartickiTableAdapter1;
        private System.Windows.Forms.DataGridView gridIzdadeniKarticki;
        private System.Windows.Forms.Button btnVnesi;
    }
}