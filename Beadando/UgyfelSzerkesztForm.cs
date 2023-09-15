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
    public partial class UgyfelSzerkesztForm : Form
    {
        public UgyfelSzerkesztForm()
        {
            InitializeComponent();
        }
        //Betöltöm az ID-kat
        private void UgyfelSzerkesztForm_Load(object sender, EventArgs e)
        {
            UgyfelManager um = new UgyfelManager();
            List<Ugyfel> ugyfelek = um.Select();
            foreach (Ugyfel ugyfel in ugyfelek)
            {
                comboBoxId.Items.Add(ugyfel.Id.ToString());
            }
        }
        //Kiválasztott ID-hoz betöltöm a hozzá tartozó adatokat
        private void comboBoxId_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxLakhely.Items.Clear();
            comboBoxSzhely.Items.Clear();

            TelepulesManager tm = new TelepulesManager();
            List<Telepules> telepulesek = tm.Select();
            foreach (Telepules telepules in telepulesek)
            {
                comboBoxLakhely.Items.Add(telepules.Telepulesnev);
                comboBoxSzhely.Items.Add(telepules.Telepulesnev);
            }

            UgyfelManager um = new UgyfelManager();
            List<Ugyfel> ugyfelek = um.Select();
            int id = int.Parse(comboBoxId.SelectedItem.ToString());
            foreach (Ugyfel ugyfel in ugyfelek)
            {
                if (id == ugyfel.Id)
                {
                    textBoxNev.Enabled = true;
                    textBoxNev.Text = ugyfel.Nev;
                    comboBoxSzhely.SelectedItem = tm.Search(ugyfel.Szulhely);
                    dateTimePicker1.Value = DateTime.Parse(ugyfel.Szulido);
                    comboBoxLakhely.SelectedItem = tm.Search(ugyfel.Lakhely);
                    textBoxCim.Enabled = true;
                    textBoxCim.Text = ugyfel.Cim;
                }
            }
        }
        //Kiolvasom az adatokat és elküldöm az adatbázisnak
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNev.Text) || string.IsNullOrWhiteSpace(textBoxCim.Text))
            {
                MessageBox.Show("Név és cím megadása kötelező!");
            }
            else
            {
                TelepulesManager tm = new TelepulesManager();
                int id = int.Parse(comboBoxId.SelectedItem.ToString());
                string nev = textBoxNev.Text;
                int szulhely = tm.Search(comboBoxSzhely.SelectedItem.ToString());
                string szulido = dateTimePicker1.Value.Date.ToShortDateString();
                int lakhely = tm.Search(comboBoxLakhely.SelectedItem.ToString());
                string cim = textBoxCim.Text;

                Ugyfel u = new Ugyfel(id, nev, szulhely, szulido, lakhely, cim);
                UgyfelManager um = new UgyfelManager();
                um.UgyfelSzerkeszt(u);
                MessageBox.Show("Sikeres szerkesztés!");
                this.Close();
            }
        }
    }
}
