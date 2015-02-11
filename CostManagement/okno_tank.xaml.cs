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
    /// Interaction logic for okno_tank.xaml
    /// </summary>
    public partial class okno_tank : Window
    {
        public okno_tank(Cars car)
        {
            InitializeComponent();
            DatabaseReader myReader = new DatabaseReader();
            dg_tank.ItemsSource = myReader.GetCar(car).Refuels;
            Edit.Click += Edit_Click;
        }

        void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dg_tank.SelectedItem != null)
            {
                mod_tank m = new mod_tank((Refuels)dg_tank.SelectedItem);
                m.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano samochodu");
            }
        }
    }
}
