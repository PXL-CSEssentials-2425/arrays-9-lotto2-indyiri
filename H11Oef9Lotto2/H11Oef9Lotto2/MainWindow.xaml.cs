using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H11Oef9Lotto2
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

        Random rnd = new Random();

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            int number1 = rnd.Next(1, 46);
            int number2 = rnd.Next(1, 46);
            int number3 = rnd.Next(1, 46);
            int number4 = rnd.Next(1, 46);
            int number5 = rnd.Next(1, 46);
            int number6 = rnd.Next(1, 46);

            resultTextBox.Text = $"Getal 1: {number1} \nGetal 2: {number2} \nGetal 3: {number3} \nGetal 4: {number4} \nGetal 5: {number5} \nGetal 6: {number6}";
        }
    }
}