using Beadando.Adatbazis.Rekordok;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Manager
{
    class ElofizetesManager : AdatbazisManager
    {
        //Hozzáadás
        public int ElofizetesAdd(Elofizetes e)
        {

            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "ElofizetesekAdd";
            command.Parameters.AddWithValue("@id", e.Id);
            command.Parameters.AddWithValue("@ugyfel", e.Ugyfel);
            command.Parameters.AddWithValue("@tarifacsomag", e.Tarifacsomag);
            command.Parameters.AddWithValue("@szerzodeskot", e.SzerzodesKot);
            command.Parameters.AddWithValue("@szerzodeslemond", e.SzerzodesLemond);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Törlés
        public int ElofizetesekTorles(Elofizetes e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "ElofizetesekTorol";
            command.Parameters.AddWithValue("@id", e.Id);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Szerkesztés
        public int ElofizetesekSzerkeszt(Elofizetes e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "ElofizetesekSzerkeszt";
            command.Parameters.AddWithValue("@id", e.Id);
            command.Parameters.AddWithValue("@ugyfel", e.Ugyfel);
            command.Parameters.AddWithValue("@tarifacsomag", e.Tarifacsomag);
            command.Parameters.AddWithValue("@szerzodeskot", e.SzerzodesKot);
            command.Parameters.AddWithValue("@szerzodeslemond", e.SzerzodesLemond);


            int succes = ExecuteDML(command);
            return succes;
        }
        //Listázás
        public List<Elofizetes> Select()
        {
            List<Elofizetes> rekordok = new List<Elofizetes>();
            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Elofizetesek";

            try
            {
                SqlConnection connection = getConnection();
                connection.Open();
                command.Connection = connection;

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            Elofizetes e = new Elofizetes(int.Parse(reader["Id"].ToString()), int.Parse(reader["Ugyfel"].ToString()),
                                int.Parse(reader["Tarifacsomag"].ToString()), reader["SzerszodesKot"].ToString(),
                                reader["SzerzodesLemond"].ToString());
                            rekordok.Add(e);
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }

            return rekordok;
        }
    }
}
