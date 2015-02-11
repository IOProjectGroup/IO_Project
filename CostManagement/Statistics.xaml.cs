using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DatabaseSupport;
using DatabaseSupport.TableClasses;
using Calculating;
using ExcelSupport;

namespace CostManagement
{
    /// <summary>
    /// Interaction logic for okno_ubez.xaml
    /// </summary>
    public partial class Statistics : Window
    {
        List<CalcCost> costList = new List<CalcCost>();

        public Statistics()
        {
            InitializeComponent();
            Save.Click += Save_Click;
            DatabaseReader myReader = new DatabaseReader();
            List<Cars> list = (List<Cars>)myReader.GetListOf<Cars>();
            if(list != null)
            {
                foreach(Cars item in list)
                {
                    costList.Add(new CalcCost(item));
                }
            }
            data.ItemsSource = costList;
        }

        void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "Excel files (*.xls; *.xlsx)|*.xls; *.xlsx|All files (*.*)|*.*";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;

                ExcelWriter myWriter = new ExcelWriter(filename);

                myWriter.SaveToExcelFile(costList);

                myWriter.CloseWorkbook();
                //FileNameTextBox.Text = filename;
            }
        }
    }
}
