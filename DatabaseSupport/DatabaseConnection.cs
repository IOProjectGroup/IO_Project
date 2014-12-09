using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseSupport
{
    public class DatabaseConnection
    {
        private static readonly object syncLock = new object();

        private static DatabaseConnection instance;

        private SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            //set { connect = value; }
        }

        protected DatabaseConnection()
        {
            connect = new SqlConnection("Data Source=(localdb)\\Projects;"
                                            +"Initial Catalog=Database;"
                                            +"Integrated Security=True;"
                                            +"Connect Timeout=30;"
                                            +"Encrypt=False;"
                                            +"TrustServerCertificate=False");
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new DatabaseConnection();
                        }
                    }
                }
                return instance;
            }
        }
        

    }
}
