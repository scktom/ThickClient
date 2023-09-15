using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Rekordok
{
    class Felhasznalo
    {
        private int id;
        private string user;
        private string password;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string User
        {
            get { return user; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new FormatException("Nem lehet üres karakter!");
                }
                else { user = value; }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new FormatException("Nem lehet üres karakter!");
                }
                else { password = value; }
            }
        }

        public Felhasznalo(int id, string user, string password)
        {
            Id = id;
            User = user;
            Password = password;
        }
    }
}
