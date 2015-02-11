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
    /// Interaction logic for okno_napr.xaml
    /// </summary>
    public partial class okno_napr : Window
    {
        public okno_napr(Cars car)
        {           
            InitializeComponent();
            DatabaseReader myReader = new DatabaseReader();
            dg_napr.ItemsSource = myReader.GetCar(car).Repairs;
            Edit.Click += Edit_Click;
        }

        void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dg_napr.SelectedItem != null)
            {
                mod_napr m = new mod_napr((Repairs)dg_napr.SelectedItem);
                m.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano naprawy");
            }
        }
    }
}
