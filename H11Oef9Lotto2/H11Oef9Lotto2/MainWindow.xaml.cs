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

        int[] numbers = new int[6];

        int count = 1;

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
            resultTextBox.Clear();
            count = 1;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                int temporaryNumber;
                
                do
                {
                    temporaryNumber = rnd.Next(1, 46);
                }
                while (Array.Exists(numbers, element => element == temporaryNumber));

                numbers[i] = temporaryNumber;
            }

            foreach (int number in numbers)
            {
                resultTextBox.Text += $"Getal {count}: {number} \n";
                count++;
            }
        }
    }
}