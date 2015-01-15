using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernateTutorialPart1.Model;

namespace NHibernateTutorialPart1
{
    public class DatabaseReader
    {
        public IList<Drivers> GetListOfDrivers()
        {
            DatabaseConnection myConnection = DatabaseConnection.Instance;

            ISession mySession = myConnection.OpenConnection();

            IList<Drivers> list = null;

            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<Drivers>();
                list = criteria.List<Drivers>();

                mySession.Transaction.Commit();
            }

            myConnection.CloseConnection();

            return list;
        }
    }
}
