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
    public class HuurContractDbContext : DbContext
    {
        public static void GetAll()
        {
            string query = "SELECT * " +
                           "FROM TBL_HUURCONTRACT";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    HuurContract.HuurContracten.Add(GetHuurContractFromDataRecord(reader));
                }
            }
        }

        public static HuurContract Save(HuurContract hc, User huurder)
        {
            using (OracleCommand command = new OracleCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GETIDHUURCONTRACT";

                command.BindByName = true;
                string startDatum = hc.StartDatum.ToString("dd-MM-yyyy");
                command.Parameters.Add("datum_start", startDatum);
                string eindDatum = hc.EindDatum.ToString("dd-MM-yyyy");
                command.Parameters.Add("datum_eind", eindDatum);
                command.Parameters.Add("huurcontract_id", OracleDbType.Int32, ParameterDirection.ReturnValue);

                command.Connection = CreateConnection();
                command.ExecuteNonQuery();

                hc.Id = Convert.ToInt32(command.Parameters["HUURCONTRACT_ID"].Value.ToString());
            }

            foreach (var b in hc.Boten)
            {
                string query = "INSERT INTO TBL_HUUR_BOOT (HUURCONTRACT_ID, BOOT_ID) VALUES (:id, :boot_id)";

                using (OracleConnection connection = CreateConnection())
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.BindByName = true;
                    command.Parameters.Add(new OracleParameter("id", hc.Id));
                    command.Parameters.Add(new OracleParameter("boot_id", b.Id));

                    command.ExecuteNonQuery();
                }
            }

            foreach (var a in hc.Artikelen)
            {
                string query = "INSERT INTO TBL_HUUR_ARTIKEL (HUURCONTRACT_ID, ARTIKEL_ID) VALUES (:id, :artikel_id)";

                using (OracleConnection connection = CreateConnection())
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.BindByName = true;
                    command.Parameters.Add(new OracleParameter("id", hc.Id));
                    command.Parameters.Add(new OracleParameter("artikel_id", a.Id));

                    command.ExecuteNonQuery();
                }
            }

            foreach (var v in hc.Vaarwateren)
            {
                string query =
                    "INSERT INTO TBL_HUUR_VAARWATER (HUURCONTRACT_ID, VAARWATER_ID) VALUES (:id, :vaarwater_id)";

                using (OracleConnection connection = CreateConnection())
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.BindByName = true;
                    command.Parameters.Add(new OracleParameter("id", hc.Id));
                    command.Parameters.Add(new OracleParameter("vaarwater_id", v.Id));

                    command.ExecuteNonQuery();
                }
            }

            string userQuery = "INSERT INTO TBL_HUURDER_CONTRACT (HUURDER_ID, HUURCONTRACT_ID) VALUES (:user_id, :id)";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(userQuery, connection))
            {
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("user_id", huurder.Id));
                command.Parameters.Add(new OracleParameter("id", hc.Id));

                command.ExecuteNonQuery();
            }
            return hc;
        }

        private static HuurContract GetHuurContractFromDataRecord(IDataRecord record)
        {
            return new HuurContract(
                Convert.ToInt32(record["ID"]),
                Convert.ToDateTime(record["DATUM_START"]),
                Convert.ToDateTime(record["DATUM_EIND"]),
                BootDbContext.GetAllBotenInHc(Convert.ToInt32(record["ID"])),
                ArtikelDbContext.GetAllArtikelenInHc(Convert.ToInt32(record["ID"])),
                VaarwaterDbContext.GetAllVaarwaterenInHc(Convert.ToInt32(record["ID"])),
                UserDbContext.GetUserInHc(Convert.ToInt32(record["ID"])));
        }
    }
}
