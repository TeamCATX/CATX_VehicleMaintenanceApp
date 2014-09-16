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

namespace CarMaintenanceApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Add New Car";
        }

        private void Button_AddCar(object sender, RoutedEventArgs e)
        {
            addCarView.Visibility = Visibility.Visible;
            garageView.Visibility = Visibility.Hidden;
            reportsView.Visibility = Visibility.Hidden;
           this.Title = "Add New Car";

        }

        private void Button_Garage(object sender, RoutedEventArgs e)
        {
            addCarView.Visibility = Visibility.Hidden;
            garageView.Visibility = Visibility.Visible;
            reportsView.Visibility = Visibility.Hidden;
            this.Title = "My Garage";
        }

        private void Button_Reports(object sender, RoutedEventArgs e)
        {
            addCarView.Visibility = Visibility.Hidden;
            garageView.Visibility = Visibility.Hidden;
            reportsView.Visibility = Visibility.Visible;
            this.Title = "Vehicle Reports";
        }
    }
}
