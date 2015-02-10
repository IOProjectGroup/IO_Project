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
using ExcelSupport;

namespace CostManagement
{
    /// <summary>
    /// Interaction logic for Dodaj_z_pliku.xaml
    /// </summary>
    public partial class Dodaj_z_pliku : Window
    {
        Object obj = null;

        public Dodaj_z_pliku(Object obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "Excel files (*.xls; *.xlsx)|*.xls; *.xlsx|All files (*.*)|*.*";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {

                string filename = dlg.FileName;

                FileNameTextBox.Text = filename;

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String path = FileNameTextBox.Text;

            ExcelReader myReader = new ExcelReader(path); 

            if(obj is Drivers)
            {

            }
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
