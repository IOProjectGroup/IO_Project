using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using DatabaseSupport.TableClasses;
using DatabaseSupport;

namespace DatabaseSupport
{
    public class DatabaseReader
    {
        public IList<T> GetListOf<T>() where T : TableClass
        {
            DatabaseConnection myConnection = DatabaseConnection.Instance;

            ISession mySession = myConnection.OpenConnection();

            IList<T> list = null;

            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<T>();
                list = criteria.List<T>();

                mySession.Transaction.Commit();
            }

            myConnection.CloseConnection();

            return list;
        }
    }
}
