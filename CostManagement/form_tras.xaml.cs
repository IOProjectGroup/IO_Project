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
    /// Interaction logic for form_tras.xaml
    /// </summary>
    public partial class form_tras : Window
    {
        Routes route = new Routes();
        public form_tras(Cars car, Drivers driver)
        {
            InitializeComponent();
            route.Cars = car;
            route.Drivers = driver;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (psl.Text != "" && ksl.Text != "" && town1.Text != "" && town2.Text != "")
            {
                List<Towns> list = new List<Towns>();
                list.Add(new Towns { TownName = town1.Text });
                list.Add(new Towns { TownName = town2.Text });

                route.Towns = list;
                route.MileageCounterStart = Convert.ToDouble(psl.Text);
                route.MileageCounterEnd = Convert.ToDouble(ksl.Text);

                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(route);
                Close();
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
