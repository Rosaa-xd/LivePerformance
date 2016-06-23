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
    public class PrijsDbContext : DbContext
    {
        public static Prijs FindById(int id)
        {
            string query = "SELECT * " +
                           "FROM TBL_PRIJS " +
                           "WHERE ID=:id";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("id", id));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return GetPrijsFromDataRecord(reader);
                    }
                }
            }
            return null;
        }

        private static Prijs GetPrijsFromDataRecord(IDataRecord record)
        {
            return new Prijs(
                Convert.ToInt32(record["ID"]),
                Convert.ToDouble(record["PRIJS"]));
        }
    }
}
