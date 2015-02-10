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

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "Excel files (*.xls; *.xlsx)|*.xls; *.xlsx|All files (*.*)|*.*";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {

                string filename = dlg.FileName;

                FileNameTextBox.Text = filename;

            }
        }
    }
}
