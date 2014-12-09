using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public class Connection
    {
        private static readonly object syncLock = new object();

        private static Connection instance;

        private SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            //set { connect = value; }
        }

        protected Connection()
        {
            connect = new SqlConnection("Data Source=(localdb)\\Projects;"
                                            +"Initial Catalog=Database;"
                                            +"Integrated Security=True;"
                                            +"Connect Timeout=30;"
                                            +"Encrypt=False;"
                                            +"TrustServerCertificate=False");
        }

        public static Connection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new Connection();
                        }
                    }
                }
                return instance;
            }
        }
        

    }
}
