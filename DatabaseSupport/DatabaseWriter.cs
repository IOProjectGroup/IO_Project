using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using DatabaseSupport.TableClasses;

namespace DatabaseSupport
{
    public class DatabaseWriter
    {
        public String AddToDatabase(Object tableClass)
        {
            DatabaseConnection myConnection = DatabaseConnection.Instance;

            ISession mySession = myConnection.OpenConnection();

            using (mySession.BeginTransaction())
            {
                try
                {
                    mySession.SaveOrUpdate(tableClass);
                }
                catch (Exception e)
                {
                    mySession.Transaction.Rollback();
                    return e.Message;
                }

                mySession.Transaction.Commit();
            }

            myConnection.CloseConnection();

            return null;
        }
    }
}
