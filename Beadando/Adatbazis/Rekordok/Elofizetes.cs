using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Rekordok
{
    class Elofizetes
    {
        private int id;
        private int ugyfel;
        private int tarifacsomag;
        private string szerzodesKot;
        private string szerzodesLemond;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Ugyfel
        {
            get { return ugyfel; }
            set { ugyfel = value; }
        }
        public int Tarifacsomag
        {
            get { return tarifacsomag; }
            set { tarifacsomag = value; }
        }
        public string SzerzodesKot
        {
            get { return szerzodesKot; }
            set { szerzodesKot = value; }
        }
        public string SzerzodesLemond
        {
            get { return szerzodesLemond; }
            set { szerzodesLemond = value; }
        }
        public Elofizetes(int id, int ugyfel, int tarifacsomag, string szerzodesKot, string szerzodesLemond)
        {
            Id = id;
            Ugyfel = ugyfel;
            Tarifacsomag = tarifacsomag;
            SzerzodesKot = szerzodesKot;
            SzerzodesLemond = szerzodesLemond;
        }
    }
}
