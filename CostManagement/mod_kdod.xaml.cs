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

namespace CostManagement
{
    /// <summary>
    /// Interaction logic for mod_kdod.xaml
    /// </summary>
    public partial class mod_kdod : Window
    {
        public mod_kdod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*  musi byc zaznczony samochod i kierowca
             * w polach sa wpisane obecne dane, zmiana danych, zapisanie i zamkniecie okna
             * 
             * pola : spec1, koszt4
             */
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
