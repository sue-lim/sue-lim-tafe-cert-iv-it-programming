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

namespace introPrgWpfGui
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

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "You clicked click me!";
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "You also clicked the other button!";
        }

        private void buttonThree_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "You shouldnt have clicked me!";
        }

        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "You said: " + textBox_input.Text;
        }
    }
}
