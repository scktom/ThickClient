using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Rekordok
{
    class Tarifacsomag
    {
        private int id;
        private string nev;
        private string leiras;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public string Leiras
        {
            get { return leiras; }
            set { leiras = value; }
        }
        public Tarifacsomag(int id, string nev, string leiras)
        {
            Id = id;
            Nev = nev;
            Leiras = leiras;
        }
    }
}
