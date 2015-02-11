using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using DatabaseSupport.TableClasses;
using DatabaseSupport;
using Calculating;

namespace ExcelSupport
{
    public class ExcelWriter
    {
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;

        public ExcelWriter(String DB_PATH)
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1];
        }

        public void SaveToExcelFile(List<CalcCost> list)
        {
            int lastRow = 1;

            MySheet.Cells[lastRow, 1] = "Marka";
            MySheet.Cells[lastRow, 2] = "Model";
            MySheet.Cells[lastRow, 3] = "Numer rejestracyjny";
            MySheet.Cells[lastRow, 4] = "Wiek samochodu";
            MySheet.Cells[lastRow, 5] = "Stan licznika";
            MySheet.Cells[lastRow, 6] = "Koszt całkowity";

            foreach (CalcCost item in list)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 1] = item.Car.Brand;
                MySheet.Cells[lastRow, 2] = item.Car.Model;
                MySheet.Cells[lastRow, 3] = item.Car.RegistrationNumber;
                MySheet.Cells[lastRow, 4] = item.CarAge;
                MySheet.Cells[lastRow, 5] = item.Mileage;
                MySheet.Cells[lastRow, 6] = item.TotalCost;
            }
            MyBook.Save();
        }

        public void SaveCarRaportToExcelFile(Cars car)
        {
            int lastRow = 1;

            MySheet.Cells[lastRow, 1] = "Marka";
            MySheet.Cells[lastRow, 2] = "Model";
            MySheet.Cells[lastRow, 3] = "Numer rejestracyjny";
            MySheet.Cells[lastRow, 4] = "Rok produkcji";
            MySheet.Cells[lastRow, 5] = "Stan licznika";
            MySheet.Cells[lastRow, 6] = "Koszt całkowity";

            CalcCost item = new CalcCost(car);

            lastRow += 1;
            MySheet.Cells[lastRow, 1] = item.Car.Brand;
            MySheet.Cells[lastRow, 2] = item.Car.Model;
            MySheet.Cells[lastRow, 3] = item.Car.RegistrationNumber;
            MySheet.Cells[lastRow, 4] = item.Car.DateOfProduction;
            MySheet.Cells[lastRow, 5] = item.Mileage;
            MySheet.Cells[lastRow, 6] = item.TotalCost;

            lastRow += 2;

            MySheet.Range[MySheet.Cells[lastRow, 1], MySheet.Cells[lastRow, 6]].Merge();

            MySheet.Cells[lastRow, 1] = "Trasy";

            lastRow += 1;
            MySheet.Cells[lastRow, 2] = "Stan licznika przed";
            MySheet.Cells[lastRow, 3] = "Stan licznika po";
            MySheet.Cells[lastRow, 4] = "Miasto początkowe";
            MySheet.Cells[lastRow, 5] = "Miasto końcowe";

            foreach(Routes variable in car.Routes)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 2] = variable.MileageCounterStart;
                MySheet.Cells[lastRow, 3] = variable.MileageCounterEnd;
                MySheet.Cells[lastRow, 4] = variable.Towns[0].TownName;
                MySheet.Cells[lastRow, 5] = variable.Towns[1].TownName;
            }

            lastRow += 2;

            MySheet.Range[MySheet.Cells[lastRow, 1], MySheet.Cells[lastRow, 6]].Merge();

            MySheet.Cells[lastRow, 1] = "Tankowania";

            lastRow += 1;
            MySheet.Cells[lastRow, 2] = "Koszt";
            MySheet.Cells[lastRow, 3] = "Ilość paliwa";

            foreach (Refuels variable in car.Refuels)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 2] = variable.Cost;
                MySheet.Cells[lastRow, 3] = variable.Fuel;
            }
            
            lastRow += 2;

            MySheet.Range[MySheet.Cells[lastRow, 1], MySheet.Cells[lastRow, 6]].Merge();

            MySheet.Cells[lastRow, 1] = "Ubezpieczenie";

            lastRow += 1;
            MySheet.Cells[lastRow, 2] = "Data zakupu";
            MySheet.Cells[lastRow, 3] = "Data wygaśnięcia";
            MySheet.Cells[lastRow, 4] = "Koszt";

            foreach (Insurance variable in car.Insurance)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 2] = variable.DateOfPurchase;
                MySheet.Cells[lastRow, 3] = variable.DateOfExpiry;
                MySheet.Cells[lastRow, 4] = variable.Cost;
            }

            lastRow += 2;

            MySheet.Range[MySheet.Cells[lastRow, 1], MySheet.Cells[lastRow, 6]].Merge();

            MySheet.Cells[lastRow, 1] = "Naprawy";

            lastRow += 1;
            MySheet.Cells[lastRow, 2] = "Data naprawy";
            MySheet.Cells[lastRow, 3] = "Koszt";
            MySheet.Cells[lastRow, 4] = "Opis";

            foreach (Repairs variable in car.Repairs)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 2] = variable.DateOfRepair;
                MySheet.Cells[lastRow, 3] = variable.Cost;
                MySheet.Cells[lastRow, 4] = variable.Specification;
            }

            lastRow += 2;

            MySheet.Range[MySheet.Cells[lastRow, 1], MySheet.Cells[lastRow, 6]].Merge();

            MySheet.Cells[lastRow, 1] = "Koszty dodatkowe";

            lastRow += 1;
            MySheet.Cells[lastRow, 2] = "Koszt";
            MySheet.Cells[lastRow, 3] = "Opis";

            foreach (AdditionalCosts variable in car.AdditionalCosts)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 2] = variable.Cost;
                MySheet.Cells[lastRow, 3] = variable.Specification;
            }
            
            MyBook.Save();
        }

        public void SaveDriverRaportToExcelFile(Drivers driver)
        {
            int lastRow = 1;

            MySheet.Cells[lastRow, 1] = "Imię";
            MySheet.Cells[lastRow, 2] = "Nazwisko";
            MySheet.Cells[lastRow, 3] = "Pesel";

            lastRow += 1;
            MySheet.Cells[lastRow, 1] = driver.FirstName;
            MySheet.Cells[lastRow, 2] = driver.LastName;
            MySheet.Cells[lastRow, 3] = driver.Pesel;

            lastRow += 2;

            MySheet.Range[MySheet.Cells[lastRow, 1], MySheet.Cells[lastRow, 4]].Merge();

            MySheet.Cells[lastRow, 1] = "Trasy";

            lastRow += 1;
            MySheet.Cells[lastRow, 1] = "Stan licznika przed";
            MySheet.Cells[lastRow, 2] = "Stan licznika po";
            MySheet.Cells[lastRow, 3] = "Miasto początkowe";
            MySheet.Cells[lastRow, 4] = "Miasto końcowe";

            foreach (Routes variable in driver.Routes)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 1] = variable.MileageCounterStart;
                MySheet.Cells[lastRow, 2] = variable.MileageCounterEnd;
                MySheet.Cells[lastRow, 3] = variable.Towns[0].TownName;
                MySheet.Cells[lastRow, 4] = variable.Towns[1].TownName;
            }

            lastRow += 2;

            MySheet.Range[MySheet.Cells[lastRow, 1], MySheet.Cells[lastRow, 6]].Merge();

            MySheet.Cells[lastRow, 1] = "Koszty dodatkowe";

            lastRow += 1;
            MySheet.Cells[lastRow, 2] = "Koszt";
            MySheet.Cells[lastRow, 3] = "Opis";

            foreach (AdditionalCosts variable in driver.AdditionalCosts)
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 2] = variable.Cost;
                MySheet.Cells[lastRow, 3] = variable.Specification;
            }

            MyBook.Save();
        }

        public void CloseWorkbook()
        {
            MyApp.Workbooks.Close();
        }
    }
}
