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
    public partial class TelepulesekSzerkesztForm : Form
    {
        public TelepulesekSzerkesztForm()
        {
            InitializeComponent();
        }
        //Betöltöm az ID-ket az adatbázból
        private void TelepulesekSzerkesztForm_Load(object sender, EventArgs e)
        {
            TelepulesManager tm = new TelepulesManager();
            List<Telepules> telepulesek = tm.Select();
            foreach (Telepules telepules in telepulesek)
            {
                comboBoxId.Items.Add(telepules.Id);
            }
        }
        //A  kiválasztott Id-hez betöltöm a hozzá tartozó adatokat
        private void comboBoxId_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxOrszag.Items.Clear();
            TelepulesManager tm = new TelepulesManager();
            List<Telepules> telepulesek = tm.Select();
            OrszagokManager om = new OrszagokManager();
            List<Orszagok> orszagok = om.Select();
            int id = (int)comboBoxId.SelectedItem;
            foreach (Orszagok orszag in orszagok)
            {
                comboBoxOrszag.Items.Add(orszag.Orszagnev);
            }
            foreach (Telepules telepules in telepulesek)
            {
                if (id == telepules.Id)
                {
                    numericUpDownIr.Enabled = true;
                    numericUpDownIr.Value = int.Parse(telepules.Iranyitoszam);
                    textBoxNev.Enabled = true;
                    textBoxNev.Text = telepules.Telepulesnev;
                    comboBoxOrszag.SelectedItem = om.Search(telepules.Orszag);
                    comboBoxKozpont.SelectedItem = telepules.KozpontE.ToString();
                }
            }
        }
        //Kiolvasom az adatokat és elküldöm az adatbázisnak
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNev.Text))
            {
                MessageBox.Show("A település kitöltése kötelező!");
            }
            else
            {
                OrszagokManager om = new OrszagokManager();
                int id = (int)comboBoxId.SelectedItem;
                string iranyitoszam = numericUpDownIr.Value.ToString();
                string telepules = textBoxNev.Text;
                int orszag = om.Search(comboBoxOrszag.SelectedItem.ToString());
                bool kozpont = bool.Parse(comboBoxKozpont.SelectedItem.ToString());
                Telepules t = new Telepules(id, iranyitoszam, telepules, orszag, kozpont);
                TelepulesManager tm = new TelepulesManager();
                tm.TelepulesSzerkeszt(t);
                MessageBox.Show("Sikeres módosítás!");
                this.Close();
            }
        }
    }
}
