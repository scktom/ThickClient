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
    public partial class ElofizetesAddForm : Form
    {
        public ElofizetesAddForm()
        {
            InitializeComponent();
        }

        //Amikor betölt az ablak feltöltöm az Id-t, ügyfél nevekkel és tarifacsomagok nevével a comboboxot
        private void ElofizetesAddForm_Load(object sender, EventArgs e)
        {
            UgyfelManager um = new UgyfelManager();
            List<Ugyfel> ugyfelek = um.Select();
            foreach (Ugyfel ugyfel in ugyfelek)
            {
                comboBoxNev.Items.Add(ugyfel.Nev);
            }
            TarifaManager tm = new TarifaManager();
            List<Tarifacsomag> tarifak = tm.Select();
            foreach (Tarifacsomag t in tarifak)
            {
                comboBoxTarifa.Items.Add(t.Nev);
            }
        }
        //Ki olvasom az értékeket és elküldöm az adatbázisnak
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxNev.SelectedItem == null || comboBoxTarifa.SelectedItem == null)
            {
                MessageBox.Show("Kötelező egy ügyfelet és tarifát kiválasztani!");
            }
            else
            {
                ElofizetesManager em = new ElofizetesManager();
                UgyfelManager um = new UgyfelManager();
                TarifaManager tm = new TarifaManager();
                List<Elofizetes> elofizetesek = em.Select();
                int id = elofizetesek.Count + 1;
                int ugyfel = um.Search(comboBoxNev.SelectedItem.ToString());
                int tarifa = tm.Search(comboBoxTarifa.SelectedItem.ToString());
                string szerzodesKot = dateTimePickerKot.Value.Date.ToShortDateString().ToString();
                string szerzodesLemond = dateTimePickerLemond.Value.Date.ToShortDateString().ToString();
                Elofizetes elofizetes = new Elofizetes(id, ugyfel, tarifa, szerzodesKot, szerzodesLemond);
                em.ElofizetesAdd(elofizetes);
                MessageBox.Show("Sikeres hozzáadás!");
                this.Close();
            }
        }
    }
}
