namespace Bankarsko_rabotenje
{
    partial class NovaTransakcija
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
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dropDownSifra = new System.Windows.Forms.ComboBox();
            this.btnVnes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(292, 55);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(239, 22);
            this.txtCard.TabIndex = 0;
            this.txtCard.Text = "card number";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(292, 202);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(239, 22);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "amount";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(292, 102);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(239, 22);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "description";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(292, 253);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(239, 22);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "date";
            // 
            // dropDownSifra
            // 
            this.dropDownSifra.FormattingEnabled = true;
            this.dropDownSifra.Items.AddRange(new object[] {
            "-1",
            "0",
            "1"});
            this.dropDownSifra.Location = new System.Drawing.Point(292, 155);
            this.dropDownSifra.Name = "dropDownSifra";
            this.dropDownSifra.Size = new System.Drawing.Size(121, 24);
            this.dropDownSifra.TabIndex = 4;
            // 
            // btnVnes
            // 
            this.btnVnes.Location = new System.Drawing.Point(292, 326);
            this.btnVnes.Name = "btnVnes";
            this.btnVnes.Size = new System.Drawing.Size(121, 30);
            this.btnVnes.TabIndex = 5;
            this.btnVnes.Text = "Zapisi";
            this.btnVnes.UseVisualStyleBackColor = true;
            this.btnVnes.Click += new System.EventHandler(this.btnVnes_Click);
            // 
            // NovaTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVnes);
            this.Controls.Add(this.dropDownSifra);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCard);
            this.Name = "NovaTransakcija";
            this.Text = "NovaTransakcija";
            this.Load += new System.EventHandler(this.NovaTransakcija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox dropDownSifra;
        private System.Windows.Forms.Button btnVnes;
    }
}