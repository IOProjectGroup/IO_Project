using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseConnection;


namespace IO_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection myConnection = Connection.Instance;
            try
            {
                myConnection.Connect.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection.Connect;
                myCommand.CommandText = "SELECT * FROM Samochody";
                myCommand.CommandTimeout = 15;
                myCommand.CommandType = System.Data.CommandType.Text;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Console.WriteLine(myReader["marka"].ToString());
                    Console.WriteLine(myReader["model"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                myConnection.Connect.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
