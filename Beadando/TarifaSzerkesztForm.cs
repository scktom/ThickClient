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
    public partial class TarifaSzerkesztForm : Form
    {
        public TarifaSzerkesztForm()
        {
            InitializeComponent();
        }
        //Betöltöm az ID-ket az adatbázisból
        private void TarifaSzerkesztForm_Load(object sender, EventArgs e)
        {
            TarifaManager tm = new TarifaManager();
            List<Tarifacsomag> tarifak = tm.Select();
            foreach (Tarifacsomag tarifa in tarifak)
            {
                comboBoxId.Items.Add(tarifa.Id);
            }
        }
        //A kiválasztott ID-hez betöltöltöm a hozzá tartozó értékeket
        private void comboBoxId_SelectedValueChanged(object sender, EventArgs e)
        {
            TarifaManager tm = new TarifaManager();
            List<Tarifacsomag> tarifak = tm.Select();
            int id = (int)comboBoxId.SelectedItem;
            foreach (Tarifacsomag tarifa in tarifak)
            {
                if(id==tarifa.Id)
                {
                    textBoxNev.Enabled = true;
                    textBoxNev.Text = tarifa.Nev;
                    textBoxLeiras.Enabled = true;
                    textBoxLeiras.Text = tarifa.Leiras;
                    break;
                }
            }
        }
        //Kiolvasom az értékeket és elküldöm az adatbázisnak
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNev.Text) || string.IsNullOrWhiteSpace(textBoxLeiras.Text))
            {
                MessageBox.Show("Kötelező a mezők megadása!");
            }
            else
            {
                int id = (int)comboBoxId.SelectedItem;
                string nev = textBoxNev.Text;
                string leiras = textBoxLeiras.Text;
                TarifaManager tm = new TarifaManager();
                Tarifacsomag t = new Tarifacsomag(id, nev, leiras);
                tm.TarifaSzerkeszt(t);
                MessageBox.Show("Sikeres szerkesztés!");
                this.Close();
            }
        }
    }
}
