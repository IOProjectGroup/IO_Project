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
        public IList<T> GetListOf<T>()
        {
            DatabaseConnection myConnection = DatabaseConnection.Instance;

            ISession mySession = myConnection.OpenConnection();

            IList<T> list = null;

            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria(typeof(T));
                list = criteria.List<T>();

                mySession.Transaction.Commit();
            }

            myConnection.CloseConnection();

            return list;
        }

        public Cars GetCar(Cars input)
        {
            return this.GetListOf<Cars>().Where<Cars>(c => c.Equals(input)).First<Cars>();
        }

        public Drivers GetDriver(Drivers input)
        {
            return this.GetListOf<Drivers>().Where<Drivers>(c => c.Equals(input)).First<Drivers>();
        }
    }
}
