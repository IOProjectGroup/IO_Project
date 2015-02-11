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
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;   

namespace CostManagement
{
    /// <summary>
    /// Interaction logic for bup_z_pliku.xaml
    /// </summary>
    public partial class bup_z_pliku : Window
    {
        public bup_z_pliku()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(FileNameTextBox.Text != "")
            {
                ServerConnection con = new ServerConnection("(localdb)\\Projects");
                Server server = new Server(con);
                Restore destination = new Restore();
                destination.Action = RestoreActionType.Database;
                destination.Database = "Database";
                BackupDeviceItem source = new BackupDeviceItem(FileNameTextBox.Text, DeviceType.File);
                destination.Devices.Add(source);
                destination.ReplaceDatabase = true;
                destination.SqlRestore(server);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "Backup files (*.sql)|*.sql;|All files (*.*)|*.*";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {

                string filename = dlg.FileName;

                FileNameTextBox.Text = filename;

            }
        }
    }
}
