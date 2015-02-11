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
    /// Interaction logic for mod_kier.xaml
    /// </summary>
    public partial class mod_kier : Window
    {
        Drivers driver = null;
        public mod_kier(Drivers driver)
        {
            InitializeComponent();
            this.driver = driver;

            imie.Text = driver.FirstName;
            nazwisko.Text = driver.LastName;
            pesel.Text = driver.Pesel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (imie.Text != "" && nazwisko.Text != "" && pesel.Text != "")
            {
                driver.FirstName = imie.Text;
                driver.LastName = nazwisko.Text;
                driver.Pesel = pesel.Text;

                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(driver);
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
