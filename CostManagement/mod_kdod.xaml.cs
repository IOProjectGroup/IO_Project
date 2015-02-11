﻿using System;
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
    /// Interaction logic for mod_kdod.xaml
    /// </summary>
    public partial class mod_kdod : Window
    {
        AdditionalCosts acost = new AdditionalCosts();
        public mod_kdod(AdditionalCosts acost)
        {
            InitializeComponent();
            this.acost = acost;

            koszt4.Text = acost.Cost.ToString();
            spec1.Text = acost.Specification;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*  musi byc zaznczony samochod i kierowca
             * w polach sa wpisane obecne dane, zmiana danych, zapisanie i zamkniecie okna
             * 
             * pola : spec1, koszt4
             */
            if (spec1.Text != "" && koszt4.Text != "")
            {
                acost.Cost = Convert.ToDouble(koszt4.Text);
                acost.Specification = spec1.Text;

                DatabaseWriter myWriter = new DatabaseWriter();
                myWriter.AddToDatabase(acost);
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
