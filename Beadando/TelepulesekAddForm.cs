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
    public partial class TelepulesekAddForm : Form
    {
        public TelepulesekAddForm()
        {
            InitializeComponent();
        }
        //Betöltöm az országneveket
        private void TelepulesekAddForm_Load(object sender, EventArgs e)
        {
            OrszagokManager om = new OrszagokManager();
            List<Orszagok> orszagok = om.Select();
            foreach (Orszagok orszag in orszagok)
            {
                comboBoxOrszag.Items.Add(orszag.Orszagnev);
            }
        }
        //Ki olvasom az adatokat és elküldöm az adatbázisnak
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(textBoxNev.Text))
            {
                MessageBox.Show("A település nem lehet üres!");
            }
            else if(comboBoxKozpont.SelectedItem == null || comboBoxOrszag.SelectedItem == null)
            {
                MessageBox.Show("Az ország és központ mező kötelező!");
            }
            else
            {
                TelepulesManager tm = new TelepulesManager();
                List<Telepules> telepulesek = tm.Select();
                int id = telepulesek.Count + 1;
                string iranyitoszam = numericUpDownIr.Value.ToString();
                OrszagokManager om = new OrszagokManager();
                int orszag = om.Search(comboBoxOrszag.SelectedItem.ToString());
                bool kozpontE = bool.Parse(comboBoxKozpont.SelectedItem.ToString());
                Telepules telepules = new Telepules(id, iranyitoszam, textBoxNev.Text, orszag, kozpontE);
                tm.TelepulesAdd(telepules);
                MessageBox.Show("Sikeres hozzáadás!");
                this.Close();
            }
        }
    }
}
