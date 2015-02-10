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
using DatabaseSupport;
using DatabaseSupport.TableClasses;

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
            DatabaseReader myReader = new DatabaseReader();
            dg_samochody.ItemsSource = myReader.GetListOf<Cars>();
            dg_kierowcy.ItemsSource = myReader.GetListOf<Drivers>();
        }

        private void AddDriverFromExcelFile(object sender, RoutedEventArgs e)
        {
            Dodaj_z_pliku dod1 = new Dodaj_z_pliku(new Drivers());
            dod1.Show();
        }

        private void AddDriverFromWindow(object sender, RoutedEventArgs e)
        {
            form_kier f = new form_kier();
            f.Show();
        }

        private void ModifyDrivers(object sender, RoutedEventArgs e)
        {
            mod_kier m = new mod_kier();
            m.Show();
        }

        private void DeleteDriver(object sender, RoutedEventArgs e)
        {
            /*
             * usuwa zaznaczone pozycje
             */
        }

        private void AddCarFromExcelFile(object sender, RoutedEventArgs e)
        {
            Dodaj_z_pliku dod1 = new Dodaj_z_pliku(new Cars());
            dod1.Show();
            //to samo okieno dla samochodow i kierocow
        }

        private void AddCarFromWindow(object sender, RoutedEventArgs e)
        {
            form_sam f = new form_sam();
            f.Show();
        }

        private void ModifyCar(object sender, RoutedEventArgs e)
        {
            mod_sam m = new mod_sam();
            m.Show();
        }

        private void DeleteCar(object sender, RoutedEventArgs e)
        {
            /*
             * usuwa zaznaczone pozycje
             */
        }

        private void AddInsurance(object sender, RoutedEventArgs e)
        {
            form_ubez f = new form_ubez();
            f.Show();
        }

        private void ModifyInsurance(object sender, RoutedEventArgs e)
        {
            mod_ubez m = new mod_ubez();
            m.Show();
        }

        private void AddRefuel(object sender, RoutedEventArgs e)
        {
            form_tank f = new form_tank();
            f.Show();
        }

        private void ModifyRefuel(object sender, RoutedEventArgs e)
        {
            mod_tank m = new mod_tank();
            m.Show();
        }

        private void AddRepairs(object sender, RoutedEventArgs e)
        {
            form_napr f = new form_napr();
            f.Show();
        }

        private void ModifyRepairs(object sender, RoutedEventArgs e)
        {
            mod_napr m = new mod_napr();
            m.Show();
        }

        private void AddRoutes(object sender, RoutedEventArgs e)
        {
            form_tras f = new form_tras();
            f.Show();
        }

        private void ModifyRoutes(object sender, RoutedEventArgs e)
        {
            mod_tras m = new mod_tras();
            m.Show();
        }

        private void AddAdditionalCosts(object sender, RoutedEventArgs e)
        {
            form_kdod f = new form_kdod();
            f.Show();
        }

        private void ModifyAdditionalCosts(object sender, RoutedEventArgs e)
        {
            mod_kdod m = new mod_kdod();
            m.Show();
        }

        private void BackUpDatabase(object sender, RoutedEventArgs e)
        {
            /*
             *  back up baz ydanych
             */
        }

        private void RestoreDatabase(object sender, RoutedEventArgs e)
        {
            bup_z_pliku b = new bup_z_pliku();
            b.Show();
        }

        private void ShowInsurance(object sender, RoutedEventArgs e)
        {
            okno_ubez o = new okno_ubez();
            o.Show();
        }

        private void ShowRefuel(object sender, RoutedEventArgs e)
        {
            okno_tank o = new okno_tank();
            o.Show();
        }

        private void ShowRepairs(object sender, RoutedEventArgs e)
        {
            okno_napr o = new okno_napr();
            o.Show();
        }

        private void ShowRoutes(object sender, RoutedEventArgs e)
        {
            okno_tras o = new okno_tras();
            o.Show();
        }

        private void ShowAdditionalCosts(object sender, RoutedEventArgs e)
        {
            okno_kdod o = new okno_kdod();
            o.Show();
        }

    }
}
