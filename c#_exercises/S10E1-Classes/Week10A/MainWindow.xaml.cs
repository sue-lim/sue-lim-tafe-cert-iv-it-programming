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

namespace Week10A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Car> Cars = new List<Car>()
        {
            new Car()
            {
                Registration = "jsh73hb",
                Year = 2007,
                Color = "Red",
                Make = "Toyota",
                Model = "Corolla",
                RentalCost = 78,
                Type = CarTypes.Sedan,
            },
            new Car("jsgh7dbg", 2028, "Lamborghini", "Sian", "Orange", CarTypes.Sports, 250),
        };

        public MainWindow()
        {
            InitializeComponent();
            foreach (CarTypes type in Enum.GetValues(typeof(CarTypes)))
            {
                ComboCarTypes.Items.Add(type);
            }
            
        }

        private void SliderCost_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            LabelRentalCostAmount.Content = $"{e.NewValue.ToString("C")}";

        }

        private void ButtonRefreshCars_Click(object sender, RoutedEventArgs e)
        {
            RefreshCarList();
        }

        private void ButtonAddCar_Click(object sender, RoutedEventArgs e)
        {

            if(ComboCarTypes.SelectedItem is not CarTypes || ComboCarTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select a car type!");
                return;
            }

            if(!int.TryParse(TextboxYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year!");
                return;
            }


            Car newCar = new Car()
            {
                Registration = TextboxRegistration.Text,
                Make = TextboxMake.Text,
                Model = TextboxModel.Text,
                Year = year,
                RentalCost = SliderCost.Value,
                Type = (CarTypes)ComboCarTypes.SelectedItem,
                Color = TextboxColor.Text,
            };

            Cars.Add(newCar);

            RefreshCarList();

        }

        private void RefreshCarList()
        {
            ListviewCars.ItemsSource = null;
            ListviewCars.ItemsSource = Cars;
        }

        private void ListviewCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car? selectedCar = ListviewCars.SelectedItem as Car;
            if (selectedCar == null) return;


            TextboxRegistration.Text = selectedCar.Registration;
            TextboxMake.Text = selectedCar.Make;
            TextboxModel.Text = selectedCar.Model;
            TextboxColor.Text = selectedCar.Color;
            TextboxYear.Text = selectedCar.Year.ToString();
            SliderCost.Value = selectedCar.RentalCost;
            ComboCarTypes.SelectedItem = selectedCar.Type;

        }
    }
}
