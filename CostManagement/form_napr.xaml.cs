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
    /// Interaction logic for form_napr.xaml
    /// </summary>
    public partial class form_napr : Window
    {
        Repairs repair = new Repairs();
        public form_napr(Cars car)
        {
            InitializeComponent();
            this.repair.Cars = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (koszt3.Text != "" && data_napr.Text != "" && spec.Text != "")
            {
                repair.DateOfRepair = data_napr.Text;
                repair.Specification = spec.Text;
                repair.Cost = Convert.ToDouble(koszt3.Text);
                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(repair);
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
