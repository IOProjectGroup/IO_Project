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
            DatabaseWriter writer = new DatabaseWriter();

            Drivers loDrivers = new Drivers { FirstName = "John", LastName = "Doe", Pesel = "12345678911" };

            Cars car = new Cars { Brand="Audi",Model="A3", Cost=35000, DateOfProduction=DateTime.Now.Date, DateOfPurchase=DateTime.Now.Date,RegistrationNumber="KR-0000P"};
            
            //Console.WriteLine(writer.AddToDatabase(car));  

            DatabaseReader reader = new DatabaseReader();
            IList<Cars> list = reader.GetListOf<Cars>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            

            Console.WriteLine("end of the program".FullyCapitalize());
            Console.ReadLine();
        }
    }
}
