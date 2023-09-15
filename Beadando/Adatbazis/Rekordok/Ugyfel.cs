using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Rekordok
{
    class Ugyfel
    {
        private int id;
        private string nev;
        private int szulhely;
        private string szulido;
        private int lakhely;
        private string cim;
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
        public int Szulhely
        {
            get { return szulhely; }
            set { szulhely = value; }
        }
        public string Szulido
        {
            get { return szulido; }
            set { szulido = value; }
        }
        public int Lakhely
        {
            get { return lakhely; }
            set { lakhely = value; }
        }
        public string Cim
        {
            get { return cim; }
            set { cim = value; }
        }
        public Ugyfel(int id, string nev, int szulhely, string szulido, int lakhely, string cim)
        {
            Id = id;
            Nev = nev;
            Szulhely = szulhely;
            Szulido = szulido;
            Lakhely = lakhely;
            Cim = cim;
        }
    }
}
