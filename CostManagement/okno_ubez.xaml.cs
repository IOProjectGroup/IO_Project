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
    /// Interaction logic for okno_ubez.xaml
    /// </summary>
    public partial class okno_ubez : Window
    {
        public okno_ubez(Cars car)
        {
            InitializeComponent();
            DatabaseReader myReader = new DatabaseReader();
            dg_ubez.ItemsSource = myReader.GetCar(car).Insurance;
            Edit.Click += Edit_Click;
        }

        void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dg_ubez.SelectedItem != null)
            {
                mod_ubez m = new mod_ubez((Insurance)dg_ubez.SelectedItem);
                m.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano samochodu");
            }
        }
    }
}
