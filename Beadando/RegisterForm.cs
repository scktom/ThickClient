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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxUser.Text) 
                || string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxPassword2.Text))
            {
                MessageBox.Show("Kötelező felhasználónév és jelszó megadása!");
            }
            else if(textBoxPassword.Text != textBoxPassword2.Text)
            {
                MessageBox.Show("A két jelszó nem egyezik meg!");
            }
            else
            {
                //Jelszót titkosítom a HashCodedal
                HashCode h = new HashCode();
                FelhasznaloManager fm = new FelhasznaloManager();
                List<Felhasznalo> lista = fm.Select();
                int lastId = 0;
                bool ok = false;
                for (int i = 0; i < lista.Count; i++)
                {
                    if(lista[i].User != textBoxUser.Text)
                    {
                        ok = true;
                    }
                    if(i == lista.Count-1)
                    {
                        lastId = lista[i].Id;
                    }
                }
                if(ok)
                {
                    lastId += 1;
                    Felhasznalo f = new Felhasznalo(lastId, textBoxUser.Text, h.PassHash(textBoxPassword.Text));
                    fm.FelhasznaloAdd(f);
                    MessageBox.Show("Sikeres regisztrálás!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ilyen felhasználónév már létezik!");
                }
            }
            
        }
    }
}
