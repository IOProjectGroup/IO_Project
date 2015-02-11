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
    /// Interaction logic for form_tank.xaml
    /// </summary>
    public partial class form_tank : Window
    {
        Refuels refuel = new Refuels();
        public form_tank(Cars car)
        {
            InitializeComponent();
            this.refuel.Cars = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (koszt2.Text != "" && paliwo.Text != "")
            {
                refuel.Fuel = Convert.ToDouble(paliwo.Text);
                refuel.Cost = Convert.ToDouble(koszt2.Text);
                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(refuel);
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
