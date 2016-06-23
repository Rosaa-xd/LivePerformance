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
    public class BoottypeDbContext : DbContext
    {
        public static Boottype FindById(int id)
        {
            string query = "SELECT * " +
                           "FROM TBL_BOOTTYPE " +
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
                        return GetBoottypeFromDataRecord(reader);
                    }
                }
            }
            return null;
        }

        private static Boottype GetBoottypeFromDataRecord(IDataRecord record)
        {
            return new Boottype(
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["NAAM"]));
        }
    }
}
