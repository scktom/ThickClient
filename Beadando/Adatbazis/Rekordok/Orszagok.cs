using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Rekordok
{
    class Orszagok
    {
        private int id;
        private string orszagnev;
        private string orszagkod;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Orszagnev
        {
            get { return orszagnev; }
            set { orszagnev = value; }
        }
        public string Orszagkod
        {
            get { return orszagkod; }
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length>4)
                {
                    throw new FormatException("Nem lehet üres és 4 karakternél több!");
                }
                else { orszagkod = value; }
            }
        }
        public Orszagok(int id, string orszagnev, string orszagkod)
        {
            Id = id;
            Orszagnev = orszagnev;
            Orszagkod = orszagkod;
        }
    }
}
