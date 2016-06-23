using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Live_Performance.Data
{
    /// <summary>
    /// Base database class where the database connection will be created.
    /// </summary>
    public abstract class DbContext
    {
        /// <summary>
        /// Connectionstring for VPN
        /// </summary>
        public static string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                                               "(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA=(SERVER=DEDICATED)" +
                                               "(SERVICE_NAME=fhictora)));User ID = dbi334051; PASSWORD=a112358aB";

        /// <summary>
        /// Connectionstring for Local
        /// </summary>
        //public static string ConnectionString = "User ID=lp;Password=lp;Data Source=localhost";

        /// <summary>
        /// Method that creates the database connection.
        /// </summary>
        /// <returns>connection</returns>
        public static OracleConnection CreateConnection()
        {
            OracleConnection connection = new OracleConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
