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
    public partial class OrszagSzerkesztForm : Form
    {
        public OrszagSzerkesztForm()
        {
            InitializeComponent();
            //Feltöltöm az ID-kat az adatbázisból
            OrszagokManager om = new OrszagokManager();
            List<Orszagok> orszagok = om.Select();
            foreach (Orszagok orszag in orszagok)
            {
                comboBoxList.Items.Add(orszag.Id);
            }
        }
        //Kiolvasom az értékeket és elküldöm az adatbázisnak
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNev.Text) || string.IsNullOrWhiteSpace(textBoxKod.Text) ||
                textBoxKod.Text.Length > 4)
            {
                MessageBox.Show("Nem lehet üres mezők és az országkód 4 karakternél több!");
            }
            else
            {
                OrszagokManager om = new OrszagokManager();
                Orszagok orszag = new Orszagok(
                    (int)comboBoxList.SelectedItem,
                    textBoxNev.Text,
                    textBoxKod.Text);
                om.OrszagSzerkeszt(orszag);
                MessageBox.Show("Sikeres szerkesztés!");
                this.Close();
            }

            
        }
        //Ha az ID-t kiválasztottuk ahozz az ID-hoz tartozó értékeket betöltöm
        private void comboBoxList_SelectedValueChanged(object sender, EventArgs e)
        {
            OrszagokManager om = new OrszagokManager();
            List<Orszagok> orszagok = om.Select();
            int id = (int)comboBoxList.SelectedItem;
            foreach (Orszagok orszag in orszagok)
            {
                if (id == orszag.Id)
                {
                    textBoxNev.Enabled = true;
                    textBoxKod.Enabled = true;
                    textBoxNev.Text = orszag.Orszagnev;
                    textBoxKod.Text = orszag.Orszagkod;
                    break;
                }
            }
        }
    }
}
