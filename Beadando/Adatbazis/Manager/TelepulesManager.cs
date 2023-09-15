using Beadando.Adatbazis.Rekordok;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Manager
{
    class TelepulesManager : AdatbazisManager
    {
        //Hozzáadás
        public int TelepulesAdd(Telepules t)
        {

            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "TelepulesAdd";
            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@iranyitoszam", t.Iranyitoszam);
            command.Parameters.AddWithValue("@telepules", t.Telepulesnev);
            command.Parameters.AddWithValue("@orszag", t.Orszag);
            command.Parameters.AddWithValue("@kozpontE", t.KozpontE);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Törlés
        public int TelepulesTorles(Telepules t)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "TelepulesTorles";
            command.Parameters.AddWithValue("@id", t.Id);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Szerkesztés
        public int TelepulesSzerkeszt(Telepules t)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "TelepulesSzerkeszt";
            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@iranyitoszam", t.Iranyitoszam);
            command.Parameters.AddWithValue("@telepules", t.Telepulesnev);
            command.Parameters.AddWithValue("@orszag", t.Orszag);
            command.Parameters.AddWithValue("@kozpontE", t.KozpontE);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Listázás
        public List<Telepules> Select()
        {
            List<Telepules> rekordok = new List<Telepules>();
            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Telepulesek";

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
                            Telepules t = new Telepules(int.Parse(reader["Id"].ToString()),
                                reader["Iranyitoszam"].ToString(), reader["Telepules"].ToString(), int.Parse(reader["Orszag"].ToString()),
                                (bool)reader["KozpontE"]);
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
        //Az adott értékhez tartozó ID visszadása
        public int Search(string telepulesnev)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Telepulesek WHERE Telepules = @telepulesnev";
            SqlParameter Telepulesnev = new SqlParameter();
            Telepulesnev.SqlDbType = System.Data.SqlDbType.NVarChar;
            Telepulesnev.ParameterName = "@telepulesnev";
            Telepulesnev.Value = telepulesnev;
            command.Parameters.Add(Telepulesnev);
            Telepules t = null;

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
                            t = new Telepules(int.Parse(reader["Id"].ToString()),
                               reader["Iranyitoszam"].ToString(), reader["Telepules"].ToString(), int.Parse(reader["Orszag"].ToString()), 
                               (bool)reader["KozpontE"]);
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }
            return t.Id;
        }
        //Az ID hez tartozó érték vissza adása
        public string Search(int id)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Telepulesek WHERE Id = @id";
            SqlParameter Id = new SqlParameter();
            Id.SqlDbType = System.Data.SqlDbType.NVarChar;
            Id.ParameterName = "@id";
            Id.Value = id;
            command.Parameters.Add(Id);
            Telepules t = null;

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
                            t = new Telepules(int.Parse(reader["Id"].ToString()),
                              reader["Iranyitoszam"].ToString(), reader["Telepules"].ToString(), int.Parse(reader["Orszag"].ToString()),
                              (bool)reader["KozpontE"]);
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }
            return t.Telepulesnev;
        }
    }
}
