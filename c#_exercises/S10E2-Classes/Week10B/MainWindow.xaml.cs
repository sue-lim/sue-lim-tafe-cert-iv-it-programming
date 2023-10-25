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

namespace Week10B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Car> Cars = new List<Car>()
        {
            new Car("skd7hd",180,"Toyota","Prius", 5, CarTypes.Hatchback),
            new Car()
            {
                Registration = "82bhfhjga",
                RentalCost = 270,
                Make = "Lamborghini",
                Model = "Sian",
                Seats = 2,
                CarType = CarTypes.Sports,
            },
        };

        public MainWindow()
        {
            InitializeComponent();

            //Initialise ComboBox
            foreach(CarTypes type in Enum.GetValues(typeof(CarTypes))){
                ComboCarType.Items.Add(type);
            }
        }

        private void SliderSeats_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (LabelSeatValue == null || SliderSeats == null) return;

            LabelSeatValue.Content = $"({SliderSeats.Value})";
        }

        private void ButtonRefreshCars_Click(object sender, RoutedEventArgs e)
        {
            UpdateCarList();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(TextboxRentalCost.Text, out double cost))
            {
                MessageBox.Show("Please enter a valid cost!");
                return;
            }


            Car newCar = new Car()
            {
                Registration = TextboxRegistration.Text,
                Make = TextboxMake.Text,
                Model = TextboxModel.Text,
                RentalCost = cost,
                Seats = (int)SliderSeats.Value,
                CarType = (CarTypes)ComboCarType.SelectedItem,
            };

            Cars.Add(newCar);
            UpdateCarList();
        }

        private void UpdateCarList()
        {
            ListCars.ItemsSource = null;
            ListCars.ItemsSource = Cars;
        }

        private void ListCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ListCars == null || ListCars.SelectedItem == null) return;

            Car? selectedCar = ListCars.SelectedItem as Car;

            if(selectedCar != null)
            {
                TextboxRegistration.Text = selectedCar.Registration;
                TextboxMake.Text = selectedCar.Make; 
                TextboxModel.Text = selectedCar.Model;
                TextboxRentalCost.Text = selectedCar.RentalCost.ToString();
                SliderSeats.Value = selectedCar.Seats;
                ComboCarType.SelectedItem = selectedCar.CarType;
            }


        }
    }
}
