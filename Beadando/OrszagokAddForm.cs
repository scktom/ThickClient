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
    public partial class OrszagokAddForm : Form
    {
        public OrszagokAddForm()
        {
            InitializeComponent();
        }

        //Elküldöm az adatokat az adatbázisnak
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxNev.Text) || string.IsNullOrWhiteSpace(textBoxKod.Text) || textBoxKod.Text.Length > 4)
            {
                MessageBox.Show("Nem lehet üres mező és 4 karakternél tőbb az országkód!");
            }
            else
            {
                OrszagokManager om = new OrszagokManager();
                List<Orszagok> orszagok = om.Select();
                bool v = true;
                int lastId = orszagok.Count + 1;
                foreach (Orszagok orszag in orszagok)
                {
                    if (orszag.Orszagnev == textBoxNev.Text || orszag.Orszagkod == textBoxKod.Text)
                    {
                        v = false;
                        break;
                    }
                }
                if (v)
                {
                    Orszagok orszag = new Orszagok(lastId, textBoxNev.Text, textBoxKod.Text);
                    om.OrszagAdd(orszag);
                    MessageBox.Show("Sikeresen hozáadva!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ilyen ország már létezik!");
                }
            }
            
        }
    }
}
