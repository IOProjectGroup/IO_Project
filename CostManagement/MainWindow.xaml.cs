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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CostManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Dodaj_z_pliku dod1 = new Dodaj_z_pliku();
            dod1.Show();
            //to samo okieno dla samochodow i kierocow
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            form_kier f = new form_kier();
            f.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            mod_kier m = new mod_kier();
            m.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            /*
             * usuwa zaznaczone pozycje
             */
        }


        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            form_sam f = new form_sam();
            f.Show();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            mod_sam m = new mod_sam();
            m.Show();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            /*
             * usuwa zaznaczone pozycje
             */
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            form_ubez f = new form_ubez();
            f.Show();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            mod_ubez m = new mod_ubez();
            m.Show();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            form_tank f = new form_tank();
            f.Show();
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            mod_tank m = new mod_tank();
            m.Show();
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            form_napr f = new form_napr();
            f.Show();
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            mod_napr m = new mod_napr();
            m.Show();
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            form_tras f = new form_tras();
            f.Show();
        }

        private void MenuItem_Click_15(object sender, RoutedEventArgs e)
        {
            mod_tras m = new mod_tras();
            m.Show();
        }

        private void MenuItem_Click_16(object sender, RoutedEventArgs e)
        {
            form_kdod f = new form_kdod();
            f.Show();
        }

        private void MenuItem_Click_17(object sender, RoutedEventArgs e)
        {
            mod_kdod m = new mod_kdod();
            m.Show();
        }

        private void MenuItem_Click_18(object sender, RoutedEventArgs e)
        {
            /*
             *  back up baz ydanych
             */
        }

        private void MenuItem_Click_19(object sender, RoutedEventArgs e)
        {
            bup_z_pliku b = new bup_z_pliku();
            b.Show();
        }

        private void MenuItem_Click_20(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_21(object sender, RoutedEventArgs e)
        {
            okno_ubez o = new okno_ubez();
            o.Show();
        }

        private void MenuItem_Click_22(object sender, RoutedEventArgs e)
        {
            okno_tank o = new okno_tank();
            o.Show();
        }

        private void MenuItem_Click_23(object sender, RoutedEventArgs e)
        {
            okno_napr o = new okno_napr();
            o.Show();
        }

        private void MenuItem_Click_24(object sender, RoutedEventArgs e)
        {
            okno_tras o = new okno_tras();
            o.Show();
        }

        private void MenuItem_Click_25(object sender, RoutedEventArgs e)
        {
            okno_kdod o = new okno_kdod();
            o.Show();
        }

        


       
    }
}
