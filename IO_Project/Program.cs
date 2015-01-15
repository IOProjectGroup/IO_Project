using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseSupport;
using System.Data;
using DatabaseSupport.TableClasses;

namespace IO_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabaseWriter writer = new DatabaseWriter();
            //Console.WriteLine(writer.AddDriverToDatabase("Michał", "Gołąb", "91010515375"));
            //Console.WriteLine(writer.AddCarToDatabase("Audi", "A3", 35000, DateTime.Now, DateTime.Now, "Kr-0000p"));
            //Console.WriteLine(writer.AddRefuelToDatabase("kR-0000P", 100, 15));
            //Console.WriteLine(writer.AddAdditionalCostsToDatabase("91010515477","Kr-0000P",1200,"mandat"));
            //Console.WriteLine(writer.AddInsuranceToDatabase("Kr-0000p", 1500, DateTime.Now, DateTime.Now));
            //Console.WriteLine(writer.AddRepairsToDatabase("Kr-0000p", 1500, DateTime.Now, "sprzęgło"));
            //Console.WriteLine(writer.AddRouteToDatabase("91010515477", "KR-0000P", 1200, 1459, "Kraków", "PoZnań"));
            //Console.WriteLine(writer.AddRouteToDatabase("91010515477", "KR-0000P", 1685, 1847, "kraków", "warSzawa"));

            DatabaseReader reader = new DatabaseReader();
            IList<Drivers> list = reader.GetListOfDrivers();

            if (list != null)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            

            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
