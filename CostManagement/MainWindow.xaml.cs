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
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;   

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
            reloadDatagrids();
        }
        
        private void ReloadDrivers(object sender, RoutedEventArgs e)
        {
            DatabaseReader myReader = new DatabaseReader();
            dg_kierowcy.ItemsSource = myReader.GetListOf<Drivers>();
        }

        private void ReloadCars(object sender, RoutedEventArgs e)
        {
            DatabaseReader myReader = new DatabaseReader();
            dg_samochody.ItemsSource = myReader.GetListOf<Cars>();
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
            if (dg_kierowcy.SelectedItem != null)
            {
                mod_kier m = new mod_kier((Drivers)dg_kierowcy.SelectedItem);
                m.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano kierowcy");
            }
        }

        private void DeleteDriver(object sender, RoutedEventArgs e)
        {
            if (dg_kierowcy.SelectedItem != null)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Jesteś pewien, że chcesz usunąć zaznaczoną pozycję z bazy?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DatabaseWriter myWriter = new DatabaseWriter();
                    myWriter.DeleteFromDatabase((Drivers)dg_kierowcy.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano kierowcy");
            }
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
            if (dg_samochody.SelectedItem != null)
            {
                mod_sam m = new mod_sam((Cars)dg_samochody.SelectedItem);
                m.Show();
            }
            else
            {
                MessageBox.Show("Nie wybrano samochodu");
            }
        }

        private void DeleteCar(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem != null)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Jesteś pewien, że chcesz usunąć zaznaczoną pozycję z bazy?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DatabaseWriter myWriter = new DatabaseWriter();
                    myWriter.DeleteFromDatabase((Cars)dg_samochody.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano samochodu");
            }
        }

        private void AddInsurance(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem != null)
            {
                form_ubez f = new form_ubez((Cars)dg_samochody.SelectedItem);
                f.Show();
            }
            else
            {
                MessageBox.Show("Wybierz samochód");
            }
        }

        private void AddRefuel(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem != null)
            {
                form_tank f = new form_tank((Cars)dg_samochody.SelectedItem);
                f.Show();
            }
            else
            {
                MessageBox.Show("Wybierz samochód");
            }
        }

        private void AddRepairs(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem != null)
            {
                form_napr f = new form_napr((Cars)dg_samochody.SelectedItem);
                f.Show();
            }
            else
            {
                MessageBox.Show("Wybierz samochód");
            }
        }

        private void AddRoutes(object sender, RoutedEventArgs e)
        {
            if (dg_kierowcy.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano kierowcy");
            }
            else if (dg_samochody.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano samochodu");
            }
            else
            {
                form_tras f = new form_tras((Cars)dg_samochody.SelectedItem, (Drivers)dg_kierowcy.SelectedItem);
                f.Show();
            }
        }

        private void AddAdditionalCosts(object sender, RoutedEventArgs e)
        {
            if (dg_kierowcy.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano kierowcy");
            }
            else if (dg_samochody.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano samochodu");
            }
            else
            {
                form_kdod f = new form_kdod((Cars)dg_samochody.SelectedItem, (Drivers)dg_kierowcy.SelectedItem);
                f.Show();
            }
        }

        private void BackUpDatabase(object sender, RoutedEventArgs e)
        {
            ServerConnection con = new ServerConnection("(localdb)\\Projects");
            Server server = new Server(con);
            Backup source = new Backup();
            source.Action = BackupActionType.Database;
            source.Database = "Database";
            BackupDeviceItem destination = new BackupDeviceItem("D:\\Studia\\V semestr\\IO\\Backup.sql", DeviceType.File);
            source.Devices.Add(destination);
            source.SqlBackup(server);
            con.Disconnect();
        }

        private void RestoreDatabase(object sender, RoutedEventArgs e)
        {
            bup_z_pliku b = new bup_z_pliku();
            b.Show();
        }

        private void ShowInsurance(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem != null)
            {
                okno_ubez o = new okno_ubez((Cars)dg_samochody.SelectedItem);
                o.Show();
            }
            else
            {
                MessageBox.Show("Wybierz samochód");
            }
        }

        private void ShowRefuel(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem != null)
            {
                okno_tank o = new okno_tank((Cars)dg_samochody.SelectedItem);
                o.Show();
            }
            else
            {
                MessageBox.Show("Wybierz samochód");
            }
        }

        private void ShowRepairs(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem != null)
            {
                okno_napr o = new okno_napr((Cars)dg_samochody.SelectedItem);
                o.Show();
            }
            else
            {
                MessageBox.Show("Wybierz samochód");
            }
        }

        private void ShowRoutes(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem == null && dg_kierowcy.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano samochodu ani kierowcy");
                return;
            }
            if (dg_samochody.SelectedItem == null)
            {
                okno_tras o = new okno_tras(null, (Drivers)dg_kierowcy.SelectedItem);
                o.Show();
            }
            else if (dg_kierowcy.SelectedItem == null)
            {
                okno_tras o = new okno_tras((Cars)dg_samochody.SelectedItem, null);
                o.Show();
            }
            else
            {
                okno_tras o = new okno_tras((Cars)dg_samochody.SelectedItem, (Drivers)dg_kierowcy.SelectedItem);
                o.Show();
            }
        }

        private void ShowAdditionalCosts(object sender, RoutedEventArgs e)
        {
            if (dg_samochody.SelectedItem == null && dg_kierowcy.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano samochodu ani kierowcy");
                return;
            }
            if (dg_samochody.SelectedItem == null)
            {
                okno_kdod o = new okno_kdod(null, (Drivers)dg_kierowcy.SelectedItem);
                o.Show();
            }
            else if (dg_kierowcy.SelectedItem == null)
            {
                okno_kdod o = new okno_kdod((Cars)dg_samochody.SelectedItem, null);
                o.Show();
            }
            else
            {
                okno_kdod o = new okno_kdod((Cars)dg_samochody.SelectedItem, (Drivers)dg_kierowcy.SelectedItem);
                o.Show();
            }
        }
        
        public void reloadDatagrids()
        {
            DatabaseReader myReader = new DatabaseReader();
            dg_samochody.ItemsSource = myReader.GetListOf<Cars>();
            dg_kierowcy.ItemsSource = myReader.GetListOf<Drivers>();
        }

    }
}
