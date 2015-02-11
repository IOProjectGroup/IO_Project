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
    /// Interaction logic for form_ubez.xaml
    /// </summary>
    public partial class form_ubez : Window
    {
        Insurance insurance = new Insurance();
        public form_ubez(Cars car)
        {
            InitializeComponent();
            this.insurance.Cars = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (koszt1.Text != "" && data_rozp.Text != "" && data_zako.Text != "")
            {
                insurance.DateOfPurchase = Convert.ToDateTime(data_rozp.Text);
                insurance.DateOfExpiry = Convert.ToDateTime(data_zako.Text);
                insurance.Cost = Convert.ToDouble(koszt1.Text);
                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(insurance);
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
