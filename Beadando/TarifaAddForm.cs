using Beadando.Adatbazis.Manager;
using Beadando.Adatbazis.Rekordok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class TarifaAddForm : Form
    {
        public TarifaAddForm()
        {
            InitializeComponent();
        }

        //Ki olvasom az értékeket és elküldöm az adatbázisnak
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNev.Text) || string.IsNullOrWhiteSpace(textBoxLeiras.Text))
            {
                MessageBox.Show("Kötelező a mezők kitöltése!");
            }
            else
            {
                TarifaManager tm = new TarifaManager();
                List<Tarifacsomag> tarifacsomagok = tm.Select();
                int id = tarifacsomagok.Count + 1;
                string nev = textBoxNev.Text;
                string leiras = textBoxLeiras.Text;
                Tarifacsomag t = new Tarifacsomag(id, nev, leiras);
                tm.TarifaAdd(t);
                MessageBox.Show("Sikeres hozzáadás!");
                this.Close();
            }
        }
    }
}
