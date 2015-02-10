using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseSupport;
using System.Data;
using DatabaseSupport.TableClasses;
using ExcelSupport;

namespace IO_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DatabaseWriter writer = new DatabaseWriter();

            DatabaseReader reader = new DatabaseReader();

            Drivers driver = new Drivers { FirstName = "John", LastName = "Doe", Pesel = "12345678911" };

            Cars car = new Cars { RegistrationNumber = "KR-0250P" };

            //car = reader.GetCar(car);
            driver = reader.GetDriver(driver);

            Insurance ins = new Insurance { Cost = 1250, DateOfExpiry = DateTime.Now.Date, DateOfPurchase = DateTime.Now.Date, Cars = car };
            Refuels refuel = new Refuels { Cost = 200, Fuel = 27, Cars = car };
            Repairs repair = new Repairs { Cost = 1500, DateOfRepair = DateTime.Now.Date, Specification = "Naprawa sprzęgła i wymiana oleju", Cars = car };
            AdditionalCosts cost = new AdditionalCosts { Cost=500, Specification="mandat za prędkość", Cars=car, Drivers=driver};

            //Console.WriteLine(writer.AddToDatabase(cost));  


            //IList<Insurance> list = reader.GetListOf<Insurance>();
            IList<Cars> list = reader.GetListOf<Cars>();
            //IList<Drivers> list = reader.GetListOf<Drivers>();
            //IList<AdditionalCosts> list = reader.GetListOf<AdditionalCosts>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            */

            ExcelReader myreader = new ExcelReader("E:\\Torrent\\Seriale\\Seriale.xls");

            //myreader.ReadFromExcelFile("A","D");

            Console.WriteLine("end of the program".FullyCapitalize());
            Console.ReadLine();
        }
    }
}
