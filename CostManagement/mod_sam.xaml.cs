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
    /// Interaction logic for mod_sam.xaml
    /// </summary>
    public partial class mod_sam : Window
    {
        Cars car = null;

        public mod_sam(Cars car)
        {
            InitializeComponent();
            this.car = car;

            Brand.Text = car.Brand;
            Model.Text = car.Model;
            RegNumber.Text = car.RegistrationNumber;
            DateOfProduction.Text = car.DateOfProduction;
            DateOfPurchase.Text = car.DateOfPurchase;
            Cost.Text = car.Cost.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Brand.Text != "" && Model.Text != "" && RegNumber.Text != "" && DateOfProduction.Text != "" && DateOfPurchase.Text != "" && Cost.Text != "")
            {
                car.Brand = Brand.Text;
                car.Model = Model.Text;
                car.RegistrationNumber = RegNumber.Text;
                car.DateOfProduction = DateOfProduction.Text;
                car.DateOfPurchase = DateOfPurchase.Text;
                car.Cost = Convert.ToDecimal(Cost.Text);

                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(car);
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
