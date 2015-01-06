using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseSupport;


namespace IO_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabaseConnection myConnection = DatabaseConnection.Instance;
            //try
            //{
            //    myConnection.Connect.Open();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            //try
            //{
            //    SqlDataReader myReader = null;
            //    SqlCommand myCommand = new SqlCommand();
            //    myCommand.Connection = myConnection.Connect;
            //    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //    myCommand.CommandText = "AddTown";
            //    myCommand.Parameters.Add(new SqlParameter("nazwa", "Kraków"));
            //    myCommand.CommandTimeout = 15;
                
            //    myCommand.ExecuteNonQuery();

            //    //myReader = myCommand.ExecuteReader();

            //    //while (myReader.Read())
            //    //{
            //    //    //Console.WriteLine(myReader["marka"].ToString());
            //    //    //Console.WriteLine(myReader["model"].ToString());
            //    //    Console.WriteLine("{0,10} {1,10}",myReader["marka"].ToString(),myReader["model"].ToString());
            //    //}
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            //try
            //{
            //    myConnection.Connect.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            DatabaseWriter writer = new DatabaseWriter();
            writer.addTownToDatabase("Warszawa");

            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
