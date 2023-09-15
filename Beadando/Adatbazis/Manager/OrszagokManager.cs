using Beadando.Adatbazis.Rekordok;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Manager
{
    class OrszagokManager : AdatbazisManager
    {
        //Hozáadás
        public int OrszagAdd(Orszagok o)
        {

            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "OrszagAdd";
            command.Parameters.AddWithValue("@id", o.Id);
            command.Parameters.AddWithValue("@orszagnev", o.Orszagnev);
            command.Parameters.AddWithValue("@orszagkod", o.Orszagkod);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Törlés
        public int OrszagTorles(Orszagok o)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "OrszagTorles";
            command.Parameters.AddWithValue("@id", o.Id);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Szerkesztés
        public int OrszagSzerkeszt(Orszagok o)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "OrszagSzerkeszt";
            command.Parameters.AddWithValue("@id", o.Id);
            command.Parameters.AddWithValue("@orszagnev", o.Orszagnev);
            command.Parameters.AddWithValue("@orszagkod", o.Orszagkod);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Listázás
        public List<Orszagok> Select()
        {
            List<Orszagok> rekordok = new List<Orszagok>();
            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Orszagok";

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
                            Orszagok o = new Orszagok(int.Parse(reader["Id"].ToString()),
                                reader["Orszagnev"].ToString(), reader["Orszagkod"].ToString());
                            rekordok.Add(o);
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }

            return rekordok;
        }
        //Az adott értékhez tartozó ID visszaadása
        public int Search(string orszagnev)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Orszagok WHERE Orszagnev = @orszagnev";
            SqlParameter Orszagnev = new SqlParameter();
            Orszagnev.SqlDbType = System.Data.SqlDbType.NVarChar;
            Orszagnev.ParameterName = "@orszagnev";
            Orszagnev.Value = orszagnev;
            command.Parameters.Add(Orszagnev);
            Orszagok o = null;

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
                             o = new Orszagok(int.Parse(reader["Id"].ToString()),
                                reader["Orszagnev"].ToString(), reader["Orszagkod"].ToString());
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch {  }
            return o.Id;
        }
        //Az adott ID-hez tartozó érték visszaadása
        public string Search(int id)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Orszagok WHERE Id = @id";
            SqlParameter Id = new SqlParameter();
            Id.SqlDbType = System.Data.SqlDbType.NVarChar;
            Id.ParameterName = "@id";
            Id.Value = id;
            command.Parameters.Add(Id);
            Orszagok o = null;

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
                            o = new Orszagok(int.Parse(reader["Id"].ToString()),
                               reader["Orszagnev"].ToString(), reader["Orszagkod"].ToString());
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }
            return o.Orszagnev;
        }
    }
}
