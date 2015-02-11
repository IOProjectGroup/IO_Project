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
    /// Interaction logic for okno_kdod.xaml
    /// </summary>
    public partial class okno_kdod : Window
    {
        public okno_kdod(Cars car, Drivers driver)
        {
            InitializeComponent();
            DatabaseReader myReader = new DatabaseReader();
            if (driver == null)
            {
                dg_kdod.ItemsSource = myReader.GetCar(car).AdditionalCosts;
            }
            else if (car == null)
            {
                dg_kdod.ItemsSource = myReader.GetDriver(driver).AdditionalCosts;
            }
            else
            {
                dg_kdod.ItemsSource = myReader.GetListOf<AdditionalCosts>().Where<AdditionalCosts>(addcst => addcst.Cars.Equals(car) && addcst.Drivers.Equals(driver));
            }
            Edit.Click += Edit_Click;
        }

        void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dg_kdod.SelectedItem != null)
            {
                mod_kdod m = new mod_kdod((AdditionalCosts)dg_kdod.SelectedItem);
                m.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano trasy");
            }
        }
    }
}
