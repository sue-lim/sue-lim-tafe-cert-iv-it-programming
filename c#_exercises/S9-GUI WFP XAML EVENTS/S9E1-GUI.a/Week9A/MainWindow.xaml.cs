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

namespace Week9A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int counter = 0;

        public MainWindow()
        {
            InitializeComponent(); //This builds the UI, do not interact with the window until it has completed.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBoxLeft.Text = "Hello world!";
        }

        private void ButtonCounter_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            if (counter > 10)
            {
                TextBoxRight.Text = "YOU WIN!";
            }
            else
            {
                
                TextBoxRight.Text = $"Clicked the button {counter} time(s).";
            }

        }

        private void TextBoxLeft_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBoxLeft.Background = new SolidColorBrush(Colors.LightCyan);
            
        }

        private void TextBoxLeft_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBoxLeft.Background = new SolidColorBrush(Colors.White);
        }
    }
}
