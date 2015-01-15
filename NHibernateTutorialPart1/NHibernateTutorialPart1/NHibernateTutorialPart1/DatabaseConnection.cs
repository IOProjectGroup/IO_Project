using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace NHibernateTutorialPart1
{
    public class DatabaseConnection
    {
        private static readonly object syncLock = new object();

        private static DatabaseConnection instance;

        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        protected DatabaseConnection()
        {
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
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
        
        public ISession OpenConnection()
        {
            if (mySession == null)
            {
                mySession = mySessionFactory.OpenSession();
            }

            return mySession;
        }
        public void CloseConnection()
        {
            if (mySession == null)
            {
                // No current session
                return;
            }

            mySession.Close();
        }
        public void CloseSessionFactory()
        {
            if (mySessionFactory != null)
            {
                mySessionFactory.Close();
            }
        }
    }
}
