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
            DatabaseWriter writer = new DatabaseWriter();
            Console.WriteLine(writer.addAdditionalCostsToDatabase("91010515477","KR-0000P",1200,"mandat"));

            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
