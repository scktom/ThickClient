using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Rekordok
{
    class Telepules
    {
        private int id;
        private string iranyitoszam;
        private string telepules;
        private int orszag;
        private bool kozpontE;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Iranyitoszam
        {
            get { return iranyitoszam; }
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length > 4)
                {
                    throw new FormatException("Nem lehet üres és 4 karakternél több!");
                }
                else
                {
                    iranyitoszam = value;
                }
            }
        }
        public string Telepulesnev
        {
            get { return telepules; }
            set { telepules = value; }
        }
        public int Orszag
        {
            get { return orszag; }
            set { orszag = value; }
        }
        public bool KozpontE
        {
            get { return kozpontE; }
            set { kozpontE = value; }
        }
        public Telepules(int id, string iranyitoszam, string telepules, int orszag, bool kozpontE)
        {
            Id = id;
            Iranyitoszam = iranyitoszam;
            Telepulesnev = telepules;
            Orszag = orszag;
            KozpontE = kozpontE;
        }
    }
}
