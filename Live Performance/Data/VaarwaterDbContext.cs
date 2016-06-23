using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models;
using Oracle.ManagedDataAccess.Client;

namespace Live_Performance.Data
{
    public class VaarwaterDbContext : DbContext
    {
        public static void GetAll()
        {
            string query = "SELECT * " +
                           "FROM TBL_VAARWATER";

            using (OracleConnection connection = CreateConnection())
            using (OracleCommand command = new OracleCommand(query, connection))
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Vaarwater.Vaarwateren.Add(GetVaarwaterFromDataRecord(reader));
                }
            }
        }

        public static List<Vaarwater> GetAllVaarwaterenInHc(int id)
        {
            List<Vaarwater> vaarwateren = new List<Vaarwater>();

            string query = "SELECT V.* " +
                           "FROM TBL_VAARWATER V " +
                           "INNER JOIN TBL_HUUR_VAARWATER HV ON V.ID = HV.VAARWATER_ID " +
                           "INNER JOIN TBL_HUURCONTRACT HC ON HC.ID = HV.HUURCONTRACT_ID " +
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
                        vaarwateren.Add(GetVaarwaterFromDataRecord(reader));
                    }
                }
            }
            return vaarwateren;
        }

        public static Vaarwater Save(Vaarwater v)
        {
            using (OracleCommand command = new OracleCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GETIDVAARWATER";

                command.BindByName = true;
                command.Parameters.Add("naam", v.Naam);
                command.Parameters.Add("prijs_id", v.Prijs.Id);
                command.Parameters.Add("vaarwater_id", OracleDbType.Int32, ParameterDirection.ReturnValue);

                command.Connection = CreateConnection();
                command.ExecuteNonQuery();

                v.Id = Convert.ToInt32(command.Parameters["VAARWATER_ID"].Value.ToString());
            }
            return v;
        }

        private static Vaarwater GetVaarwaterFromDataRecord(IDataRecord record)
        {
            if (!Convert.IsDBNull(record["AANTAL"]))
            {
                return new Vaarwater(
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["NAAM"]),
                Convert.ToInt32(record["AANTAL"]),
                PrijsDbContext.FindById(Convert.ToInt32(record["PRIJS_ID"])));
            }
            return new Vaarwater(
                Convert.ToInt32(record["ID"]),
                Convert.ToString(record["Naam"]),
                PrijsDbContext.FindById(Convert.ToInt32(record["PRIJS_ID"])));
        }
    }
}
    