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
    public partial class ElofizetesekSzerkesztForm : Form
    {
        public ElofizetesekSzerkesztForm()
        {
            InitializeComponent();
        }
        //Ha betölt akkor feltöltöm a comboboxokat ID, Ügyfél névvel és tarficsomagok nevével
        private void ElofizetesekSzerkesztForm_Load(object sender, EventArgs e)
        {
            ElofizetesManager em = new ElofizetesManager();
            List<Elofizetes> elofizetesek = em.Select();
            foreach (Elofizetes elofizetes in elofizetesek)
            {
                comboBoxId.Items.Add(elofizetes.Id);
            }
            UgyfelManager um = new UgyfelManager();
            List<Ugyfel> ugyfelek = um.Select();
            foreach (Ugyfel ugyfel in ugyfelek)
            {
                comboBoxNev.Items.Add(ugyfel.Nev);
            }
            TarifaManager tm = new TarifaManager();
            List<Tarifacsomag> tarifak = tm.Select();
            foreach (Tarifacsomag tarifa in tarifak)
            {
                comboBoxCsomag.Items.Add(tarifa.Nev);
            }
        }
        //Ha a kiválasztot Id-t válasszuk az adatbázisból kiolvassva az adott értékeket betöltöm a mezökbe
        private void comboBoxId_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = (int)comboBoxId.SelectedItem;
            ElofizetesManager em = new ElofizetesManager();
            TarifaManager tm = new TarifaManager();
            UgyfelManager um = new UgyfelManager();

            List<Elofizetes> elofizetesek = em.Select();
            foreach (Elofizetes elofizetes in elofizetesek)
            {
                if(elofizetes.Id == id)
                {
                    comboBoxNev.SelectedItem = um.Search(elofizetes.Ugyfel);
                    comboBoxCsomag.SelectedItem = tm.Search(elofizetes.Tarifacsomag);
                    dateTimePickerKot.Value = DateTime.Parse(elofizetes.SzerzodesKot);
                    dateTimePickerLemond.Value = DateTime.Parse(elofizetes.SzerzodesLemond);
                    break;
                }
            }
        }
        //Kiolvasom az addott értéket és elküldöm az adatbázisnak
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(comboBoxCsomag.SelectedItem == null || comboBoxId.SelectedItem == null || comboBoxNev.SelectedItem == null)
            {
                MessageBox.Show("Kötelező minden mezőt kiválasztani!");
            }
            else
            {
                ElofizetesManager em = new ElofizetesManager();
                TarifaManager tm = new TarifaManager();
                UgyfelManager um = new UgyfelManager();
                int id = (int)comboBoxId.SelectedItem;
                int ugyfel = um.Search(comboBoxNev.SelectedItem.ToString());
                int tarifa = tm.Search(comboBoxCsomag.SelectedItem.ToString());
                string szerzodesKot = dateTimePickerKot.Value.Date.ToShortDateString();
                string szerzodesLemond = dateTimePickerLemond.Value.Date.ToShortDateString();
                Elofizetes elofizetes = new Elofizetes(id, ugyfel, tarifa, szerzodesKot, szerzodesLemond);
                em.ElofizetesekSzerkeszt(elofizetes);
                MessageBox.Show("Sikeres szerkesztés!");
                this.Close();
            }
        }
    }
}
