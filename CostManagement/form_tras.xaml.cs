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
    /// Interaction logic for form_tras.xaml
    /// </summary>
    public partial class form_tras : Window
    {
        public form_tras()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*  musi byc zaznczony samochod i kierowca
             * 
             * pola : psl, ksl
             */
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
