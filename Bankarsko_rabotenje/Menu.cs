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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // zavisno od sec_leve na korisnikot show/hide menu items
            // Edit
            if (Vraboten.Sec_level < 3)
            {
                this.menuKarticki_Edit.Enabled = true;
            }
            else
            {
                this.menuKarticki_Edit.Enabled = false;
            }
            // pregled
            if (Vraboten.Sec_level < 5)
            {
                this.menuKarticki_Pregled.Enabled = true;
                this.MenuTransakcii_Vnes.Enabled = true;
            }
            else
            {
                this.menuKarticki_Pregled.Enabled = false;
                this.MenuTransakcii_Vnes.Enabled = false;
            }

            if (Vraboten.Sec_level < 7)
            {
                this.MenuTransakcii_Pregled.Enabled = true;
            }
            else
            {
                this.MenuTransakcii_Pregled.Enabled = false;
            }

            if (Vraboten.Sec_level < 4)
            {
                this.MenuObrabotka_Presmetka.Enabled = true;
            }
            else
            {
                this.MenuObrabotka_Presmetka.Enabled = false;
            }





            // EXTRA 
            //var menuItems = this.MainMenuStrip;
            //
            //foreach(var obj in this. dagi izlista site objekti)
            //{

            //}

        }

        private void kartickiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transakciiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void obrabotkaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pregledTransakciiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.MaximizeBox = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            PregledTransakcii pregled = new PregledTransakcii();
            pregled.MdiParent = this;
            pregled.MaximizeBox = true;
            pregled.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            pregled.Show();

        }

        private void menuKarticki_Edit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //EditorKarticki ek = new EditorKarticki();
            //ek.Show();

            this.IsMdiContainer = true;
            EditorKarticki ek = new EditorKarticki();
            this.MaximizeBox = true;
            ek.MdiParent = this;
            ek.MaximizeBox = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ek.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            ek.Show();
        }

        private void menuKarticki_Pregled_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //PregledKarticki pk = new PregledKarticki();
            //pk.Show();

            this.IsMdiContainer = true;
            PregledKarticki pk = new PregledKarticki();
            this.MaximizeBox = true;
            pk.MdiParent = this;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            pk.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            pk.MdiParent = this;
            pk.Show();

        }

        private void MenuTransakcii_Vnes_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.MaximizeBox = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            StornoTransakcii forma = new StornoTransakcii();
            forma.MdiParent = this;
            forma.MaximizeBox = true;
            forma.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            forma.Show();
        }
    }
}
