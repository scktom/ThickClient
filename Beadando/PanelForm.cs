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
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }
        //Betöltöm a listába adatbázisokat és a kiválasztott adatbázist kiiratom megjelenítem
        private void Lista_SelectedValueChanged(object sender, EventArgs e)
        {
            //Ha változik a combobox értéke akkor azt az adatbázist listázza ki
            switch (Lista.SelectedItem)
            {
                case "Országok":
                    OrszagokBetolt();
                    break;
                case "Települések":
                    TelepulesekBetolt();
                    break;
                case "Ügyfelek":
                    UgyfelBetolt();
                    break;
                case "Tarifacsomagok":
                    TarifaBetolt();
                    break;
                case "Előfizetések":
                    ElofizetesekBetolt();
                    break;
                default:
                    break;
            }
        }

        private void ElofizetesekBetolt()
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "Id";
            DataGridViewTextBoxColumn ugyfel = new DataGridViewTextBoxColumn();
            ugyfel.HeaderText = "Ügyfél";
            DataGridViewTextBoxColumn tarifacsomag = new DataGridViewTextBoxColumn();
            tarifacsomag.HeaderText = "Tarifacsomag";
            DataGridViewTextBoxColumn szerzodesKot = new DataGridViewTextBoxColumn();
            szerzodesKot.HeaderText = "Szerződés kötés";
            DataGridViewTextBoxColumn szerzodesLemond = new DataGridViewTextBoxColumn();
            szerzodesLemond.HeaderText = "Szerződés lemondása";
            tabla.Columns.Add(id);
            tabla.Columns.Add(ugyfel);
            tabla.Columns.Add(tarifacsomag);
            tabla.Columns.Add(szerzodesKot);
            tabla.Columns.Add(szerzodesLemond);

            ElofizetesManager em = new ElofizetesManager();
            List<Elofizetes> elofizetesek = em.Select();
            UgyfelManager um = new UgyfelManager();
            TarifaManager tm = new TarifaManager();
            foreach (Elofizetes elofizetes in elofizetesek)
            {
                string ugyfelNev = um.Search(elofizetes.Ugyfel);
                string tarifaNev = tm.Search(elofizetes.Tarifacsomag);
                tabla.Rows.Add(new object[]
                {
                    elofizetes.Id,
                    ugyfelNev,
                    tarifaNev,
                    elofizetes.SzerzodesKot,
                    elofizetes.SzerzodesLemond
                });
            }
        }

        private void TarifaBetolt()
        {
            // Kitöröljük a sorokat, ha vannak
            tabla.Rows.Clear();
            // Kitöröljük az oszlopokat, ha vannak
            tabla.Columns.Clear();

            //oszlopok kiírása
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "Id";
            DataGridViewTextBoxColumn Nev = new DataGridViewTextBoxColumn();
            Nev.HeaderText = "Név";
            DataGridViewTextBoxColumn Leiras = new DataGridViewTextBoxColumn();
            Leiras.HeaderText = "Leírás";
            tabla.Columns.Add(id);
            tabla.Columns.Add(Nev);
            tabla.Columns.Add(Leiras);

            //Sorok kiírása
            TarifaManager tm = new TarifaManager();
            List<Tarifacsomag> tarifak = tm.Select();
            foreach (Tarifacsomag tarifa in tarifak)
            {
                tabla.Rows.Add(new object[]
                {
                    tarifa.Id,
                    tarifa.Nev,
                    tarifa.Leiras
                });
            }
        }

        private void UgyfelBetolt()
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "Id";
            DataGridViewTextBoxColumn nev = new DataGridViewTextBoxColumn();
            nev.HeaderText = "Név";
            DataGridViewTextBoxColumn szulhely = new DataGridViewTextBoxColumn();
            szulhely.HeaderText = "Születési hely";
            DataGridViewTextBoxColumn szulido = new DataGridViewTextBoxColumn();
            szulido.HeaderText = "Születési idő";
            DataGridViewTextBoxColumn lakhely = new DataGridViewTextBoxColumn();
            lakhely.HeaderText = "Lakhely";
            DataGridViewTextBoxColumn cim = new DataGridViewTextBoxColumn();
            cim.HeaderText = "Cím";
            tabla.Columns.Add(id);
            tabla.Columns.Add(nev);
            tabla.Columns.Add(szulhely);
            tabla.Columns.Add(szulido);
            tabla.Columns.Add(lakhely);
            tabla.Columns.Add(cim);

            TelepulesManager tm = new TelepulesManager();
            UgyfelManager um = new UgyfelManager();
            List<Ugyfel> ugyfelek = um.Select();
            foreach (Ugyfel ugyfel in ugyfelek)
            {
                string szhely = tm.Search(ugyfel.Szulhely);
                string lhely = tm.Search(ugyfel.Lakhely);
                tabla.Rows.Add(new object[]
                {
                    ugyfel.Id,
                    ugyfel.Nev,
                    szhely,
                    ugyfel.Szulido,
                    lhely,
                    ugyfel.Cim
                });
            }
        }

        private void TelepulesekBetolt()
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "Id";
            DataGridViewTextBoxColumn iranyitoszam = new DataGridViewTextBoxColumn();
            iranyitoszam.HeaderText = "Irányítószám";
            DataGridViewTextBoxColumn telepulesnev = new DataGridViewTextBoxColumn();
            telepulesnev.HeaderText = "Település";
            DataGridViewTextBoxColumn orszag = new DataGridViewTextBoxColumn();
            orszag.HeaderText = "Ország";
            DataGridViewTextBoxColumn kozpontE = new DataGridViewTextBoxColumn();
            kozpontE.HeaderText = "KözpontE";
            tabla.Columns.Add(id);
            tabla.Columns.Add(iranyitoszam);
            tabla.Columns.Add(telepulesnev);
            tabla.Columns.Add(orszag);
            tabla.Columns.Add(kozpontE);

            TelepulesManager tm = new TelepulesManager();
            List<Telepules> telepulesek = tm.Select();
            OrszagokManager om = new OrszagokManager();
            foreach (Telepules telepules in telepulesek)
            {
                string orszagnev = om.Search(telepules.Orszag);
                tabla.Rows.Add(new object[]
                {
                    telepules.Id,
                    telepules.Iranyitoszam,
                    telepules.Telepulesnev,
                    orszagnev,
                    telepules.KozpontE
                });
            }
        }

        private void OrszagokBetolt()
        {
            // Kitöröljük a sorokat, ha vannak
            tabla.Rows.Clear();
            // Kitöröljük az oszlopokat, ha vannak
            tabla.Columns.Clear();

            //oszlopok kiírása
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "Id";
            DataGridViewTextBoxColumn orszagnev = new DataGridViewTextBoxColumn();
            orszagnev.HeaderText = "Országnév";
            DataGridViewTextBoxColumn orszagkod = new DataGridViewTextBoxColumn();
            orszagkod.HeaderText = "Országkód";
            tabla.Columns.Add(id);
            tabla.Columns.Add(orszagnev);
            tabla.Columns.Add(orszagkod);

            //Sorok kiírása
            OrszagokManager om = new OrszagokManager();
            List<Orszagok> orszagok = om.Select();
            foreach (Orszagok orszag in orszagok)
            {
                tabla.Rows.Add(new object[]
                {
                    orszag.Id,
                    orszag.Orszagnev,
                    orszag.Orszagkod
                });
            }
        }
        //Hozzáadás
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Ha változik a combobox értéke akkor azt az adatbázist válassza ki
            switch (Lista.SelectedItem)
            {
                case "Országok":
                    OrszagokAdd();
                    break;
                case "Települések":
                    TelepulesekAdd();
                    break;
                case "Ügyfelek":
                    UgyfelekAdd();
                    break;
                case "Tarifacsomagok":
                    TarifaAdd();
                    break;
                case "Előfizetések":
                    ElofizetesekAdd();
                    break;
                default:
                    break;
            }
        }

        private void ElofizetesekAdd()
        {
            ElofizetesAddForm elo = new ElofizetesAddForm();
            elo.ShowDialog();
            ElofizetesekBetolt();
        }

        private void TarifaAdd()
        {
            TarifaAddForm tarifaAddForm = new TarifaAddForm();
            tarifaAddForm.ShowDialog();
            TarifaBetolt();
        }

        private void UgyfelekAdd()
        {
            UgyfelAddForm ugyfelAddForm = new UgyfelAddForm();
            ugyfelAddForm.ShowDialog();
            UgyfelBetolt();
        }

        private void TelepulesekAdd()
        {
            TelepulesekAddForm telepulesekAddForm = new TelepulesekAddForm();
            telepulesekAddForm.ShowDialog();
            TelepulesekBetolt();
        }

        private void OrszagokAdd()
        {
            OrszagokAddForm orszagokAddForm = new OrszagokAddForm();
            orszagokAddForm.ShowDialog();
            OrszagokBetolt();
        }
        //Törlés
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Ha változik a combobox értéke akkor azt az adatbázist válassza ki
            switch (Lista.SelectedItem)
            {
                case "Országok":
                    OrszagokDelete();
                    break;
                case "Települések":
                    TelepulesTorles();
                    break;
                case "Ügyfelek":
                    UgyfelTorol();
                    break;
                case "Tarifacsomagok":
                    TarifaTorol();
                    break;
                case "Előfizetések":
                    ElofizetesekTorol();
                    break;
                default:
                    break;
            }
        }

        private void ElofizetesekTorol()
        {
            ElofizetesManager em = new ElofizetesManager();
            List<Elofizetes> elofizetesek = em.Select();
            int id = (int)numericUpDownID.Value;
            bool torles = false;
            foreach (Elofizetes elo in elofizetesek)
            {
                if(elo.Id == id)
                {
                    em.ElofizetesekTorles(elo);
                    torles = true;
                    break;
                }
            }
            if(torles)
            {
                MessageBox.Show("Sikeres törlés!");
                ElofizetesekBetolt();
            }
            else
            {
                MessageBox.Show("Nincs ilyen ID!");
            }
        }

        private void TarifaTorol()
        {
            TarifaManager tm = new TarifaManager();
            List<Tarifacsomag> tarifak = tm.Select();
            int id = (int)numericUpDownID.Value;
            bool torles = false;
            foreach (Tarifacsomag t in tarifak)
            {
                if(t.Id == id)
                {
                    tm.TarifaTorles(t);
                    torles = true;
                    break;
                }
            }
            if(torles)
            {
                MessageBox.Show("Sikeres törlés!");
                TarifaBetolt();
            }
            else
            {
                MessageBox.Show("Nincs ilyen ID!");
            }
        }

        private void UgyfelTorol()
        {
            UgyfelManager um = new UgyfelManager();
            List<Ugyfel> ugyfelek = um.Select();
            int id = (int)numericUpDownID.Value;
            bool torles = false;
            foreach (Ugyfel ugyfel in ugyfelek)
            {
                if(ugyfel.Id == id)
                {
                    um.UgyfelTorles(ugyfel);
                    torles = true;
                    break;
                }
            }
            if(torles)
            {
                MessageBox.Show("Sikeres törlés!");
                UgyfelBetolt();
            }
            else
            {
                MessageBox.Show("Nincs ilyen ID!");
            }
        }

        private void TelepulesTorles()
        {
            TelepulesManager tm = new TelepulesManager();
            List<Telepules> telepulesek = tm.Select();
            int id = (int)numericUpDownID.Value;
            bool torles = false;
            foreach (Telepules telepules in telepulesek)
            {
                if (telepules.Id == id)
                {
                    tm.TelepulesTorles(telepules);
                    torles = true;
                    break;
                }
            }
            if (torles)
            {
                MessageBox.Show("Sikeres törlés!");
                TelepulesekBetolt();
            }
            else
            {
                MessageBox.Show("Nincs ilyen ID!");
            }
        }

        private void OrszagokDelete()
        {
            OrszagokManager om = new OrszagokManager();
            List<Orszagok> orszagok = om.Select();
            int id = (int)numericUpDownID.Value;
            bool torles = false;
            foreach (Orszagok orszag in orszagok)
            {
                if(orszag.Id == id)
                {
                    om.OrszagTorles(orszag);
                    torles = true;
                    break;
                }
            }
            if(torles)
            {
                MessageBox.Show("Sikeres törlés!");
                OrszagokBetolt();
            }
            else
            {
                MessageBox.Show("Nincs ilyen ID!");
            }
        }
        //Szerkesztés
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Ha változik a combobox értéke akkor azt az adatbázist válassza ki
            switch (Lista.SelectedItem)
            {
                case "Országok":
                    OrszagokUpdate();
                    break;
                case "Települések":
                    TelepulesekUpdate();
                    break;
                case "Ügyfelek":
                    UgyfelSzerkeszt();
                    break;
                case "Tarifacsomagok":
                    TarifaSzerkeszt();
                    break;
                case "Előfizetések":
                    ElofizetesSzerkeszt();
                    break;
                default:
                    break;
            }
        }

        private void ElofizetesSzerkeszt()
        {
            ElofizetesekSzerkesztForm elo = new ElofizetesekSzerkesztForm();
            elo.ShowDialog();
            ElofizetesekBetolt();
        }

        private void TarifaSzerkeszt()
        {
            TarifaSzerkesztForm t = new TarifaSzerkesztForm();
            t.ShowDialog();
            TarifaBetolt();
        }

        private void UgyfelSzerkeszt()
        {
            UgyfelSzerkesztForm ugyfelSzerkesztForm = new UgyfelSzerkesztForm();
            ugyfelSzerkesztForm.ShowDialog();
            UgyfelBetolt();
        }

        private void TelepulesekUpdate()
        {
            TelepulesekSzerkesztForm telepulesekSzerkesztForm = new TelepulesekSzerkesztForm();
            telepulesekSzerkesztForm.ShowDialog();
            TelepulesekBetolt();
        }

        private void OrszagokUpdate()
        {
            OrszagSzerkesztForm szerkeszt = new OrszagSzerkesztForm();
            szerkeszt.ShowDialog();
            OrszagokBetolt();
        }
    }
}
