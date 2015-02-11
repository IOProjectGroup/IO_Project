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
    /// Interaction logic for form_sam.xaml
    /// </summary>
    public partial class form_sam : Window
    {
        Cars car = new Cars();
        public form_sam()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (marka.Text != "" && model.Text != "" && rejestr.Text != "" && data_prod.Text != "" && data_zak.Text != "" && koszt.Text != "")
            {
                car.Brand = marka.Text;
                car.Model = model.Text;
                car.RegistrationNumber = rejestr.Text;
                car.DateOfProduction = Convert.ToDateTime(data_prod.Text);
                car.DateOfPurchase = Convert.ToDateTime(data_zak.Text);
                car.Cost = Convert.ToDecimal(koszt.Text);

                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(car);
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
