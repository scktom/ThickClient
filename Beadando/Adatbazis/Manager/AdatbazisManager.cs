using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Adatbazis.Manager
{
    class AdatbazisManager
    {
        protected AdatbazisManager() { }
        //Kapcsolódás az adatbázishoz
        protected SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Kapcsolat"].ConnectionString;
            return connection;
        }
        //Elküldés az adatbázisnak a command-ot
        protected int ExecuteDML(SqlCommand command)
        {
            int rowCount = 0;
            try
            {
                SqlConnection connection = getConnection();
                connection.Open();
                try
                {
                    command.Connection = connection;
                    rowCount = command.ExecuteNonQuery();
                }
                catch { }
                finally { connection.Close(); }
            }
            catch
            {
                throw new Exception("Kapcsolódás sikertelen!");
            }
            return rowCount;
        }
    }
}
