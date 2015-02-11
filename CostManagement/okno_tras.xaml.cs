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

namespace CostManagement
{
    /// <summary>
    /// Interaction logic for okno_tras.xaml
    /// </summary>
    public partial class okno_tras : Window
    {
        public okno_tras(Cars car, Drivers driver)
        {
            InitializeComponent();
            DatabaseReader myReader = new DatabaseReader();
            if (driver == null)
            {
                dg_tras.ItemsSource = myReader.GetCar(car).Routes;
            }
            else if(car == null)
            {
                dg_tras.ItemsSource = myReader.GetDriver(driver).Routes;
            }
            else
            {
                dg_tras.ItemsSource = myReader.GetListOf<Routes>().Where<Routes>(route => route.Cars.Equals(car) && route.Drivers.Equals(driver));
            }
            Edit.Click += Edit_Click;
        }

        void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dg_tras.SelectedItem != null)
            {
                mod_tras m = new mod_tras((Routes)dg_tras.SelectedItem);
                m.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano trasy");
            }
        }
    }
}
