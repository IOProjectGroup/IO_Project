using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseSupport.TableClasses;

namespace DatabaseSupport
{
    public class DatabaseReader
    {
        public List<DriverClass> GetListOfDrivers()
        {
            List<DriverClass> driverList = new List<DriverClass>();

            DatabaseConnection myConnection = DatabaseConnection.Instance;
            myConnection.OpenConnection();

            try
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection.Connect;
                myCommand.CommandType = System.Data.CommandType.Text;
                myCommand.CommandText = "SELECT * FROM DisplayDrivers";

                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(1);  
                    string surname = myReader.GetString(2); 
                    string pesel = myReader.GetString(3);
                    driverList.Add(new DriverClass() { Name = name, Surname = surname, Pesel = pesel });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                driverList = null;
            }

            myConnection.CloseConnection();

            return driverList;
        }
    }
}
