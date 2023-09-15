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
    public partial class UgyfelAddForm : Form
    {
        public UgyfelAddForm()
        {
            InitializeComponent();
        }
        //Betöltöm a születési helyeket és lakhelyeket
        private void UgyfelAddForm_Load(object sender, EventArgs e)
        {
            TelepulesManager tm = new TelepulesManager();
            List<Telepules> telepulesek = tm.Select();
            foreach (Telepules telepules in telepulesek)
            {
                comboBoxSzhely.Items.Add(telepules.Telepulesnev);
                comboBoxLakhely.Items.Add(telepules.Telepulesnev);
            }
        }
        //Kiolvasom az adatokat és elküldöm az adatbázisnak
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNev.Text) || string.IsNullOrWhiteSpace(textBoxCim.Text))
            {
                MessageBox.Show("Név és cím megadása kötelező!");
            }
            else if(comboBoxLakhely.SelectedItem == null || comboBoxSzhely.SelectedItem == null)
            {
                MessageBox.Show("Születési hely és lakhely megadása kötelező!");
            }
            else
            {
                TelepulesManager tm = new TelepulesManager();
                UgyfelManager um = new UgyfelManager();
                List<Ugyfel> ugyfelek = um.Select();
                int id = ugyfelek.Count + 1;
                string nev = textBoxNev.Text;
                int szulhely = tm.Search(comboBoxSzhely.SelectedItem.ToString());
                string szulido = dateTimePicker1.Value.Date.ToShortDateString().ToString();
                int lakhely = tm.Search(comboBoxLakhely.SelectedItem.ToString());
                string cim = textBoxCim.Text;
                Ugyfel ugyfel = new Ugyfel(id, nev, szulhely, szulido, lakhely, cim);
                um.UgyfelAdd(ugyfel);
                MessageBox.Show("Sikeres hozzáadás!");
                this.Close();
            }
        }
    }
}
