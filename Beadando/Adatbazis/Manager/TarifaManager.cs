using Beadando.Adatbazis.Rekordok;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Manager
{
    class TarifaManager : AdatbazisManager
    {
        //Hozzáadás
        public int TarifaAdd(Tarifacsomag t)
        {

            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "TarifacsomagAdd";
            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@nev", t.Nev);
            command.Parameters.AddWithValue("@leiras", t.Leiras);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Törlés
        public int TarifaTorles(Tarifacsomag t)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "TarifacsomagTorol";
            command.Parameters.AddWithValue("@id", t.Id);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Szerkesztés
        public int TarifaSzerkeszt(Tarifacsomag t)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "TarifacsomagSzerkeszt";
            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@nev", t.Nev);
            command.Parameters.AddWithValue("@leiras", t.Leiras);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Listázás
        public List<Tarifacsomag> Select()
        {
            List<Tarifacsomag> rekordok = new List<Tarifacsomag>();
            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Tarifacsomagok";

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
                            Tarifacsomag t = new Tarifacsomag(int.Parse(reader["Id"].ToString()), reader["Nev"].ToString(),
                                reader["Leiras"].ToString());
                            rekordok.Add(t);
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }

            return rekordok;
        }
        //Az adott értékhez tartozó ID vissza adása
        public int Search(string tarifanev)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Tarifacsomagok WHERE Nev = @nev";
            SqlParameter Nev = new SqlParameter();
            Nev.SqlDbType = System.Data.SqlDbType.NVarChar;
            Nev.ParameterName = "@nev";
            Nev.Value = tarifanev;
            command.Parameters.Add(Nev);
            Tarifacsomag t = null;

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
                            t = new Tarifacsomag(int.Parse(reader["Id"].ToString()),
                               reader["Nev"].ToString(), reader["Leiras"].ToString());
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }
            return t.Id;
        }
        //Az adott ID-hez tartozó érték vissza adása
        public string Search(int id)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Tarifacsomagok WHERE Id = @id";
            SqlParameter Id = new SqlParameter();
            Id.SqlDbType = System.Data.SqlDbType.NVarChar;
            Id.ParameterName = "@id";
            Id.Value = id;
            command.Parameters.Add(Id);
            Tarifacsomag t = null;

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
                            t = new Tarifacsomag(int.Parse(reader["Id"].ToString()),
                                reader["Nev"].ToString(), reader["Leiras"].ToString());
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }
            return t.Nev;
        }
    }
}
