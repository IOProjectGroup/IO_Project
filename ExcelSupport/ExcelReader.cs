using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using DatabaseSupport.TableClasses;
using DatabaseSupport;

namespace ExcelSupport
{
    public class ExcelReader
    {
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;

        public ExcelReader(String DB_PATH)
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1];
        }

        public void ReadFromExcelFile(string startColumn, string endColumn)
        {
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            int cellsNumber = Encoding.ASCII.GetBytes(endColumn)[0] - Encoding.ASCII.GetBytes(startColumn)[0];

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range(startColumn + index.ToString(), endColumn + index.ToString()).Cells.Value;

                for (int i = 1; i <= cellsNumber + 1; i++)
                {
                    Console.WriteLine(String.Format("{0,50}", MyValues.GetValue(1, i).ToString()));
                }
                String str = MyValues.GetValue(1, 2).ToString().Replace('.', '/');
                Console.WriteLine(String.Format("{0,50}", str));
            }
        }

        public List<Cars> ReadCarFromExcelFile()
        {
            List<Cars> list = new List<Cars>();
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range('A' + index.ToString(), 'F' + index.ToString()).Cells.Value;
                list.Add(new Cars
                {
                    Brand = MyValues.GetValue(1, 1).ToString(),
                    Model = MyValues.GetValue(1, 2).ToString(),
                    Cost = Convert.ToDecimal(MyValues.GetValue(1, 3)),
                    DateOfProduction = MyValues.GetValue(1, 4).ToString(),
                    DateOfPurchase = MyValues.GetValue(1, 5).ToString(),
                    RegistrationNumber = MyValues.GetValue(1, 6).ToString(),
                });
            }
            return list;
        }
        public List<Drivers> ReadDriverFromExcelFile()
        {
            List<Drivers> list = new List<Drivers>();
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range('A' + index.ToString(), 'C' + index.ToString()).Cells.Value;
                list.Add(new Drivers
                {
                    FirstName = MyValues.GetValue(1, 1).ToString(),
                    LastName = MyValues.GetValue(1, 2).ToString(),
                    Pesel = MyValues.GetValue(1, 3).ToString()
                });
            }
            return list;
        }

        public List<AdditionalCosts> ReadAdditionalCostsFromExcelFile()
        {
            List<AdditionalCosts> list = new List<AdditionalCosts>();
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            DatabaseReader reader = new DatabaseReader();

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range('A' + index.ToString(), 'D' + index.ToString()).Cells.Value;
                list.Add(new AdditionalCosts
                {
                    Cars = reader.GetCar(new Cars { RegistrationNumber = MyValues.GetValue(1, 3).ToString() }),
                    Drivers = reader.GetDriver(new Drivers { Pesel = MyValues.GetValue(1, 4).ToString() }),
                    Specification = MyValues.GetValue(1, 2).ToString(),
                    Cost = Convert.ToDouble(MyValues.GetValue(1, 1))
                });
            }
            return list;
        }

        public List<Insurance> ReadInsuranceFromExcelFile()
        {
            List<Insurance> list = new List<Insurance>();
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            DatabaseReader reader = new DatabaseReader();

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range('A' + index.ToString(), 'D' + index.ToString()).Cells.Value;
                list.Add(new Insurance
                {
                    Cost = Convert.ToDouble(MyValues.GetValue(1, 1)),
                    DateOfPurchase = MyValues.GetValue(1, 2).ToString(),
                    DateOfExpiry = MyValues.GetValue(1, 3).ToString(),
                    Cars = reader.GetCar(new Cars { RegistrationNumber = MyValues.GetValue(1, 4).ToString() })
                });
            }
            return list;
        }

        public List<Refuels> ReadRefuelsFromExcelFile()
        {
            List<Refuels> list = new List<Refuels>();
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            DatabaseReader reader = new DatabaseReader();

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range('A' + index.ToString(), 'C' + index.ToString()).Cells.Value;
                list.Add(new Refuels
                {
                    Cost = Convert.ToDouble(MyValues.GetValue(1, 1)),
                    Fuel = Convert.ToDouble(MyValues.GetValue(1, 2)),
                    Cars = reader.GetCar(new Cars { RegistrationNumber = MyValues.GetValue(1, 3).ToString() })
                });
            }
            return list;
        }

        public List<Repairs> ReadRepairsFromExcelFile()
        {
            List<Repairs> list = new List<Repairs>();
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            DatabaseReader reader = new DatabaseReader();

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range('A' + index.ToString(), 'D' + index.ToString()).Cells.Value;
                list.Add(new Repairs
                {
                    Cost = Convert.ToDouble(MyValues.GetValue(1, 1)),
                    DateOfRepair = MyValues.GetValue(1, 2).ToString(),
                    Specification = MyValues.GetValue(1, 3).ToString(),
                    Cars = reader.GetCar(new Cars { RegistrationNumber = MyValues.GetValue(1, 4).ToString() })
                });
            }
            return list;
        }

        public List<Routes> ReadRoutesFromExcelFile()
        {
            List<Routes> list = new List<Routes>();
            int fullRow = MySheet.Rows.Count;
            int lastRow = MySheet.Cells[fullRow, 1].End(Excel.XlDirection.xlUp).Row;

            DatabaseReader reader = new DatabaseReader();

            for (int index = 3; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range('A' + index.ToString(), 'F' + index.ToString()).Cells.Value;
                List<Towns> townsList = new List<Towns>();
                townsList.Add(new Towns { TownName = MyValues.GetValue(1, 5).ToString() });
                townsList.Add(new Towns { TownName = MyValues.GetValue(1, 6).ToString() });
                list.Add(new Routes
                {
                    MileageCounterStart = Convert.ToDouble(MyValues.GetValue(1, 1)),
                    MileageCounterEnd = Convert.ToDouble(MyValues.GetValue(1, 2)),
                    Cars = reader.GetCar(new Cars { RegistrationNumber = MyValues.GetValue(1, 3).ToString() }),
                    Drivers = reader.GetDriver(new Drivers { Pesel = MyValues.GetValue(1, 4).ToString() }),
                    Towns = townsList
                });
            }
            return list;
        }
    }
}
