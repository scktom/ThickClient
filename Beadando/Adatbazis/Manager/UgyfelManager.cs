using Beadando.Adatbazis.Rekordok;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Manager
{
    class UgyfelManager : AdatbazisManager
    {
        //Hozzáadás
        public int UgyfelAdd(Ugyfel u)
        {

            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "UgyfelAdd";
            command.Parameters.AddWithValue("@id", u.Id);
            command.Parameters.AddWithValue("@nev", u.Nev);
            command.Parameters.AddWithValue("@szulhely", u.Szulhely);
            command.Parameters.AddWithValue("@szulido", u.Szulido);
            command.Parameters.AddWithValue("@lakhely", u.Lakhely);
            command.Parameters.AddWithValue("@cim", u.Cim);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Törlés
        public int UgyfelTorles(Ugyfel u)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "UgyfelTorol";
            command.Parameters.AddWithValue("@id", u.Id);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Szerkesztés
        public int UgyfelSzerkeszt(Ugyfel u)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "UgyfelSzerkeszt";
            command.Parameters.AddWithValue("@id", u.Id);
            command.Parameters.AddWithValue("@nev", u.Nev);
            command.Parameters.AddWithValue("@szulhely", u.Szulhely);
            command.Parameters.AddWithValue("@szulido", u.Szulido);
            command.Parameters.AddWithValue("@lakhely", u.Lakhely);
            command.Parameters.AddWithValue("@cim", u.Cim);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Listázás
        public List<Ugyfel> Select()
        {
            List<Ugyfel> rekordok = new List<Ugyfel>();
            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Ugyfelek";

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
                            Ugyfel u = new Ugyfel(int.Parse(reader["Id"].ToString()), reader["Nev"].ToString(),
                                int.Parse(reader["Szulhely"].ToString()), reader["Szulido"].ToString(),
                                int.Parse(reader["Lakhely"].ToString()), reader["Cim"].ToString());
                            rekordok.Add(u);
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }

            return rekordok;
        }
        //Értékhez tartozó ID-vissza adása
        public int Search(string ugyfelnev)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Ugyfelek WHERE Nev = @ugyfelnev";
            SqlParameter Ugyfelnev = new SqlParameter();
            Ugyfelnev.SqlDbType = System.Data.SqlDbType.NVarChar;
            Ugyfelnev.ParameterName = "@ugyfelnev";
            Ugyfelnev.Value = ugyfelnev;
            command.Parameters.Add(Ugyfelnev);
            Ugyfel u = null;

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
                            u = new Ugyfel(int.Parse(reader["Id"].ToString()),
                               reader["Nev"].ToString(), int.Parse(reader["Szulhely"].ToString()), reader["Szulido"].ToString(),
                               int.Parse(reader["Lakhely"].ToString()), reader["Cim"].ToString());
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }
            return u.Id;
        }
        //Id-hoz tartozó érték visszaadása
        public string Search(int id)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Ugyfelek WHERE Id = @id";
            SqlParameter Id = new SqlParameter();
            Id.SqlDbType = System.Data.SqlDbType.NVarChar;
            Id.ParameterName = "@id";
            Id.Value = id;
            command.Parameters.Add(Id);
            Ugyfel u = null;

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
                            u = new Ugyfel(int.Parse(reader["Id"].ToString()),
                              reader["Nev"].ToString(), int.Parse(reader["Szulhely"].ToString()), reader["Szulido"].ToString(),
                              int.Parse(reader["Lakhely"].ToString()), reader["Cim"].ToString());
                        }
                        catch { }
                    }
                }
                finally { connection.Close(); }

            }
            catch { }
            return u.Nev;
        }
    }
}
