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
    /// Interaction logic for mod_kier.xaml
    /// </summary>
    public partial class mod_kier : Window
    {
        public mod_kier()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*  musi byc zaznczony kierowca
             * w polach sa wpisane obecne dane, zmiana danych, zapisanie i zamkniecie okna
             * 
             * pola : imie, nazwisko, pesel
             */
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
