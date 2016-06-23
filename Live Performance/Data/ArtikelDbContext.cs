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
    public class ArtikelDbContext : DbContext
    {
        public static void GetAll()
        {
            string query = "SELECT * " +
                           "FROM TBL_ARTIKEL";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Artikel.Artikelen.Add(GetArtikelFromDataRecord(reader));
                }
            }
        }

        public static List<Artikel> GetAllArtikelenInHc(int id)
        {
            List<Artikel> artikelen = new List<Artikel>();

            string query = "SELECT A.* " +
                           "FROM TBL_ARTIKEL A " +
                           "INNER JOIN TBL_HUUR_ARTIKEL HA ON A.ID = HA.ARTIKEL_ID " +
                           "INNER JOIN TBL_HUURCONTRACT HC ON HC.ID = HA.HUURCONTRACT_ID " +
                           "WHERE HC.ID=:id";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("id", id));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        artikelen.Add(GetArtikelFromDataRecord(reader));
                    }
                }
            }
            return artikelen;
        }

        private static Artikel GetArtikelFromDataRecord(IDataRecord record)
        {
            return new Artikel(
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["NAAM"]),
                PrijsDbContext.FindById(Convert.ToInt32(record["PRIJS_ID"])));
        }
    }
}
