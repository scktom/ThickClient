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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Bejelentkezés
        private void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUser.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Nem adott meg felhasználó nevet vagy jelszót!");
            }
            else
            {
                //Jelszót tikosítom a HashCode osztályal és adatbázisból lekrédezem és összehasonlítom egyezzik e a hash code
                HashCode hash = new HashCode();
                FelhasznaloManager fm = new FelhasznaloManager();
                List<Felhasznalo> felhasznalok = fm.Select();
                string hashPassword = hash.PassHash(textBoxPassword.Text);
                bool panel = false;
                for (int i = 0; i < felhasznalok.Count; i++)
                {
                    if(felhasznalok[i].User == textBoxUser.Text && felhasznalok[i].Password == hashPassword)
                    {

                        panel = true;
                    }
                }
                if(panel)
                {
                    PanelForm p = new PanelForm();
                    p.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó!");
                }

            }
        }
        //Regisztráció
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm();
            r.ShowDialog();
        }
    }
}
