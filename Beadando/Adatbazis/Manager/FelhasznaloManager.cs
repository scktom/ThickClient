using Beadando.Adatbazis.Rekordok;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Manager
{
    class FelhasznaloManager: AdatbazisManager
    {
        //Hozzáadd
        public int FelhasznaloAdd(Felhasznalo f)
        {
            
            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandTimeout = 0;
            command.CommandText = "FelhasznaloHozzaad";
            command.Parameters.AddWithValue("@id", f.Id);
            command.Parameters.AddWithValue("@user", f.User);
            command.Parameters.AddWithValue("@password", f.Password);

            int succes = ExecuteDML(command);
            return succes;
        }
        //Listázás
        public List<Felhasznalo> Select()
        {
            List<Felhasznalo> rekordok = new List<Felhasznalo>();
            // command pld készítése
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 0;
            command.CommandText = @"SELECT * FROM Felhasznalok";

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
                            Felhasznalo f = new Felhasznalo(int.Parse(reader["Id"].ToString()),
                                reader["Username"].ToString(), reader["Password"].ToString());
                            rekordok.Add(f);
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
