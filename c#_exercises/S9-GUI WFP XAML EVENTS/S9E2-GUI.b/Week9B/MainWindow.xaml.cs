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

namespace Week9B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int counter = 0;

        public MainWindow()
        {
            InitializeComponent(); //This builds the UI. Do not use the UI components before this is finished.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string outputText = "";
            outputText = TextBoxRight.Text;
            LabelOutput.Content = outputText;
        }

        private void ButtonCounter_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            LabelCounterOutput.Content = $"The button has been clicked {counter} times.";
        }
    }
}
