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
            this.praksaDataSet2 = new Bankarsko_rabotenje.PraksaDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.praksaDataSet21 = new Bankarsko_rabotenje.PraksaDataSet2();
            this.cardproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.card_productsTableAdapter = new Bankarsko_rabotenje.PraksaDataSet2TableAdapters.card_productsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.praksaDataSet3 = new Bankarsko_rabotenje.PraksaDataSet3();
            this.pregledKartickiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pregledKartickiTableAdapter1 = new Bankarsko_rabotenje.PraksaDataSet3TableAdapters.PregledKartickiTableAdapter();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embguserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameseriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource1)).BeginInit();
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
            this.Embg_btn.Location = new System.Drawing.Point(154, 2);
            this.Embg_btn.Name = "Embg_btn";
            this.Embg_btn.Size = new System.Drawing.Size(75, 23);
            this.Embg_btn.TabIndex = 1;
            this.Embg_btn.Text = "EMBG";
            this.Embg_btn.UseVisualStyleBackColor = true;
            this.Embg_btn.Click += new System.EventHandler(this.Embg_btn_Click);
            // 
            // Embg_text
            // 
            this.Embg_text.Location = new System.Drawing.Point(22, 2);
            this.Embg_text.Name = "Embg_text";
            this.Embg_text.Size = new System.Drawing.Size(100, 20);
            this.Embg_text.TabIndex = 2;
            // 
            // NovaKarticka_btn
            // 
            this.NovaKarticka_btn.Location = new System.Drawing.Point(52, 222);
            this.NovaKarticka_btn.Name = "NovaKarticka_btn";
            this.NovaKarticka_btn.Size = new System.Drawing.Size(82, 23);
            this.NovaKarticka_btn.TabIndex = 3;
            this.NovaKarticka_btn.Text = "NovaKarticka";
            this.NovaKarticka_btn.UseVisualStyleBackColor = true;
            this.NovaKarticka_btn.Click += new System.EventHandler(this.NovaKarticka_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(202, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 228);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // praksaDataSet2
            // 
            this.praksaDataSet2.DataSetName = "PraksaDataSet";
            this.praksaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cardproductsBindingSource;
            this.comboBox1.DisplayMember = "name_series";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "name_series";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMBG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "BrKarticka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DatumNaIstekuvanje";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(186, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CVC";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(186, 173);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 12;
            // 
            // praksaDataSet21
            // 
            this.praksaDataSet21.DataSetName = "PraksaDataSet2";
            this.praksaDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardproductsBindingSource
            // 
            this.cardproductsBindingSource.DataMember = "card_products";
            this.cardproductsBindingSource.DataSource = this.praksaDataSet21;
            // 
            // card_productsTableAdapter
            // 
            this.card_productsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardNumberDataGridViewTextBoxColumn,
            this.printnameDataGridViewTextBoxColumn,
            this.printsurnameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.embguserDataGridViewTextBoxColumn,
            this.nameseriesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pregledKartickiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 101);
            this.dataGridView1.TabIndex = 5;
            // 
            // praksaDataSet3
            // 
            this.praksaDataSet3.DataSetName = "PraksaDataSet3";
            this.praksaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledKartickiBindingSource1
            // 
            this.pregledKartickiBindingSource1.DataMember = "PregledKarticki";
            this.pregledKartickiBindingSource1.DataSource = this.praksaDataSet3;
            // 
            // pregledKartickiTableAdapter1
            // 
            this.pregledKartickiTableAdapter1.ClearBeforeFill = true;
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            // 
            // printnameDataGridViewTextBoxColumn
            // 
            this.printnameDataGridViewTextBoxColumn.DataPropertyName = "print_name";
            this.printnameDataGridViewTextBoxColumn.HeaderText = "print_name";
            this.printnameDataGridViewTextBoxColumn.Name = "printnameDataGridViewTextBoxColumn";
            // 
            // printsurnameDataGridViewTextBoxColumn
            // 
            this.printsurnameDataGridViewTextBoxColumn.DataPropertyName = "print_surname";
            this.printsurnameDataGridViewTextBoxColumn.HeaderText = "print_surname";
            this.printsurnameDataGridViewTextBoxColumn.Name = "printsurnameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // embguserDataGridViewTextBoxColumn
            // 
            this.embguserDataGridViewTextBoxColumn.DataPropertyName = "embg_user";
            this.embguserDataGridViewTextBoxColumn.HeaderText = "embg_user";
            this.embguserDataGridViewTextBoxColumn.Name = "embguserDataGridViewTextBoxColumn";
            // 
            // nameseriesDataGridViewTextBoxColumn
            // 
            this.nameseriesDataGridViewTextBoxColumn.DataPropertyName = "name_series";
            this.nameseriesDataGridViewTextBoxColumn.HeaderText = "name_series";
            this.nameseriesDataGridViewTextBoxColumn.Name = "nameseriesDataGridViewTextBoxColumn";
            // 
            // PregledKarticki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NovaKarticka_btn);
            this.Controls.Add(this.Embg_text);
            this.Controls.Add(this.Embg_btn);
            this.Name = "PregledKarticki";
            this.Text = "PregledKarticki";
            this.Load += new System.EventHandler(this.PregledKarticki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praksaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKartickiBindingSource1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private PraksaDataSet praksaDataSet2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private PraksaDataSet2 praksaDataSet21;
        private System.Windows.Forms.BindingSource cardproductsBindingSource;
        private PraksaDataSet2TableAdapters.card_productsTableAdapter card_productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PraksaDataSet3 praksaDataSet3;
        private System.Windows.Forms.BindingSource pregledKartickiBindingSource1;
        private PraksaDataSet3TableAdapters.PregledKartickiTableAdapter pregledKartickiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn embguserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameseriesDataGridViewTextBoxColumn;
    }
}