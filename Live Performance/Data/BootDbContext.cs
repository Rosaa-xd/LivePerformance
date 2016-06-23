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
    public class BootDbContext : DbContext
    {
        public static void GetAll()
        {
            string query = "SELECT * " +
                           "FROM TBL_BOOT";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Boot.Boten.Add(GetBootFromDataRecord(reader));
                }
            }
        }

        public static List<Boot> GetAllBotenInHc(int id)
        {
            List<Boot> boten = new List<Boot>();

            string query = "SELECT B.* " +
                           "FROM TBL_BOOT B " +
                           "INNER JOIN TBL_HUUR_BOOT HB ON B.ID = HB.BOOT_ID " +
                           "INNER JOIN TBL_HUURCONTRACT HC ON HC.ID = HB.HUURCONTRACT_ID " +
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
                        boten.Add(GetBootFromDataRecord(reader));
                    }
                }
            }
            return boten;
        }

        private static Boot GetBootFromDataRecord(IDataRecord record)
        {
            int id = Convert.ToInt32(record["ID"]);
            string naam = Convert.ToString(record["NAAM"]);
            string soort = Convert.ToString(record["SOORT"]);
            string aandrijving = Convert.ToString(record["AANDRIJVING"]);
            Boottype boottype = record.IsDBNull(1)
                ? null
                : BoottypeDbContext.FindById(Convert.ToInt32(record["BOOTTYPE_ID"]));
            Prijs prijs = PrijsDbContext.FindById(Convert.ToInt32(record["PRIJS_ID"]));

            if (!Convert.IsDBNull(record["TANKINHOUD"]))
            {
                return new Boot(id, naam, soort, aandrijving, Convert.ToInt32(record["TANKINHOUD"]), boottype, prijs);
            }
            return new Boot(id, naam, soort, aandrijving, boottype, prijs);
        }
    }
}
