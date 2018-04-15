namespace Bankarsko_rabotenje
{
    partial class StornoTransakcii
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
            this.gridTransakcii = new System.Windows.Forms.DataGridView();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnVnes = new System.Windows.Forms.Button();
            this.btnStorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransakcii)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTransakcii
            // 
            this.gridTransakcii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransakcii.Location = new System.Drawing.Point(12, 79);
            this.gridTransakcii.Name = "gridTransakcii";
            this.gridTransakcii.RowTemplate.Height = 24;
            this.gridTransakcii.Size = new System.Drawing.Size(1265, 540);
            this.gridTransakcii.TabIndex = 0;
            this.gridTransakcii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransakcii_CellContentClick);
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(12, 32);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(320, 22);
            this.txtCreditCard.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(369, 30);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(95, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVnes
            // 
            this.btnVnes.Location = new System.Drawing.Point(673, 30);
            this.btnVnes.Name = "btnVnes";
            this.btnVnes.Size = new System.Drawing.Size(75, 23);
            this.btnVnes.TabIndex = 3;
            this.btnVnes.Text = "Vnes";
            this.btnVnes.UseVisualStyleBackColor = true;
            this.btnVnes.Click += new System.EventHandler(this.btnVnes_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(820, 30);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(75, 23);
            this.btnStorno.TabIndex = 4;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // StornoTransakcii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 646);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnVnes);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.gridTransakcii);
            this.Name = "StornoTransakcii";
            this.Text = "StornoTransakcii";
            this.Load += new System.EventHandler(this.StornoTransakcii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransakcii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTransakcii;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnVnes;
        private System.Windows.Forms.Button btnStorno;
    }
}