namespace Bankarsko_rabotenje
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuKarticki = new System.Windows.Forms.ToolStripMenuItem();
            this.transakciiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuObrabotka_Presmetka = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKarticki_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKarticki_Pregled = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransakcii_Pregled = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransakcii_Vnes = new System.Windows.Forms.ToolStripMenuItem();
            this.presmetkaNaProvizijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKarticki,
            this.transakciiToolStripMenuItem,
            this.MenuObrabotka_Presmetka});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuKarticki
            // 
            this.menuKarticki.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKarticki_Edit,
            this.menuKarticki_Pregled});
            this.menuKarticki.Name = "menuKarticki";
            this.menuKarticki.Size = new System.Drawing.Size(58, 20);
            this.menuKarticki.Text = "Karticki";
            this.menuKarticki.Click += new System.EventHandler(this.kartickiToolStripMenuItem_Click);
            // 
            // transakciiToolStripMenuItem
            // 
            this.transakciiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTransakcii_Pregled,
            this.MenuTransakcii_Vnes});
            this.transakciiToolStripMenuItem.Name = "transakciiToolStripMenuItem";
            this.transakciiToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.transakciiToolStripMenuItem.Text = "Transakcii";
            this.transakciiToolStripMenuItem.Click += new System.EventHandler(this.transakciiToolStripMenuItem_Click);
            // 
            // MenuObrabotka_Presmetka
            // 
            this.MenuObrabotka_Presmetka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presmetkaNaProvizijaToolStripMenuItem});
            this.MenuObrabotka_Presmetka.Name = "MenuObrabotka_Presmetka";
            this.MenuObrabotka_Presmetka.Size = new System.Drawing.Size(75, 20);
            this.MenuObrabotka_Presmetka.Text = "Obrabotka";
            this.MenuObrabotka_Presmetka.Click += new System.EventHandler(this.obrabotkaToolStripMenuItem_Click);
            // 
            // menuKarticki_Edit
            // 
            this.menuKarticki_Edit.Name = "menuKarticki_Edit";
            this.menuKarticki_Edit.Size = new System.Drawing.Size(218, 22);
            this.menuKarticki_Edit.Text = "edit type/products";
            // 
            // menuKarticki_Pregled
            // 
            this.menuKarticki_Pregled.Name = "menuKarticki_Pregled";
            this.menuKarticki_Pregled.Size = new System.Drawing.Size(218, 22);
            this.menuKarticki_Pregled.Text = "Pregled na izdadeni karticki";
            // 
            // MenuTransakcii_Pregled
            // 
            this.MenuTransakcii_Pregled.Name = "MenuTransakcii_Pregled";
            this.MenuTransakcii_Pregled.Size = new System.Drawing.Size(191, 22);
            this.MenuTransakcii_Pregled.Text = "pregled transakcii";
            this.MenuTransakcii_Pregled.Click += new System.EventHandler(this.pregledTransakciiToolStripMenuItem_Click);
            // 
            // MenuTransakcii_Vnes
            // 
            this.MenuTransakcii_Vnes.Name = "MenuTransakcii_Vnes";
            this.MenuTransakcii_Vnes.Size = new System.Drawing.Size(191, 22);
            this.MenuTransakcii_Vnes.Text = "Vnes/storno transakcii";
            // 
            // presmetkaNaProvizijaToolStripMenuItem
            // 
            this.presmetkaNaProvizijaToolStripMenuItem.Name = "presmetkaNaProvizijaToolStripMenuItem";
            this.presmetkaNaProvizijaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.presmetkaNaProvizijaToolStripMenuItem.Text = "presmetka na provizija";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 395);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuKarticki;
        private System.Windows.Forms.ToolStripMenuItem menuKarticki_Edit;
        private System.Windows.Forms.ToolStripMenuItem menuKarticki_Pregled;
        private System.Windows.Forms.ToolStripMenuItem transakciiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuObrabotka_Presmetka;
        private System.Windows.Forms.ToolStripMenuItem MenuTransakcii_Pregled;
        private System.Windows.Forms.ToolStripMenuItem MenuTransakcii_Vnes;
        private System.Windows.Forms.ToolStripMenuItem presmetkaNaProvizijaToolStripMenuItem;
    }
}