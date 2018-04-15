namespace Bankarsko_rabotenje
{
    partial class Obrabotka
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
            this.gridPresmetka = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnPresmetaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPresmetka)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPresmetka
            // 
            this.gridPresmetka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPresmetka.Location = new System.Drawing.Point(22, 92);
            this.gridPresmetka.Name = "gridPresmetka";
            this.gridPresmetka.RowTemplate.Height = 24;
            this.gridPresmetka.Size = new System.Drawing.Size(1213, 574);
            this.gridPresmetka.TabIndex = 0;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(22, 33);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 1;
            // 
            // btnPresmetaj
            // 
            this.btnPresmetaj.Location = new System.Drawing.Point(286, 31);
            this.btnPresmetaj.Name = "btnPresmetaj";
            this.btnPresmetaj.Size = new System.Drawing.Size(109, 23);
            this.btnPresmetaj.TabIndex = 2;
            this.btnPresmetaj.Text = "Presmetaj";
            this.btnPresmetaj.UseVisualStyleBackColor = true;
            this.btnPresmetaj.Click += new System.EventHandler(this.btnPresmetaj_Click);
            // 
            // Obrabotka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 706);
            this.Controls.Add(this.btnPresmetaj);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.gridPresmetka);
            this.Name = "Obrabotka";
            this.Text = "Obrabotka";
            this.Load += new System.EventHandler(this.Obrabotka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPresmetka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPresmetka;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnPresmetaj;
    }
}