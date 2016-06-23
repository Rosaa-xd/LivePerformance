using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models;
using Oracle.ManagedDataAccess.Client;

namespace Live_Performance.Data
{
    public class UserDbContext : DbContext
    {
        public static User Save(User u)
        {
            using (OracleCommand command = new OracleCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GETIDHUURDER";

                command.BindByName = true;
                command.Parameters.Add("naam", u.Naam);
                command.Parameters.Add("emailadres", u.EmailAdres);
                command.Parameters.Add("wachtwoord", u.Wachtwoord);
                command.Parameters.Add("huurder_id", OracleDbType.Int32, ParameterDirection.ReturnValue);

                command.Connection = CreateConnection();
                command.ExecuteNonQuery();

                u.Id = Convert.ToInt32(command.Parameters["HUURDER_ID"].Value.ToString());
            }
            return u;
        }

        public static User GetUserInHc(int id)
        {
            string query = "SELECT H.* " +
                           "FROM TBL_HUURDER H " +
                           "INNER JOIN TBL_HUURDER_CONTRACT HHC ON H.ID = HC.HUURDER_ID " +
                           "INNER JOIN TBL_HUURCONTRACT HC ON HC.ID = HHC.HUURCONTRACT_ID " +
                           "WHERE HC.ID=:id";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("id", id));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return GetUserFromDataRecord(reader);
                    }
                }
            }
            return null;
        }

        private static User GetUserFromDataRecord(IDataRecord record)
        {
            return new User(
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["NAAM"]),
                Convert.ToString(record["EMAILADRES"]),
                Convert.ToString(record["WACHTWOORD"]));
        }
    }
}
