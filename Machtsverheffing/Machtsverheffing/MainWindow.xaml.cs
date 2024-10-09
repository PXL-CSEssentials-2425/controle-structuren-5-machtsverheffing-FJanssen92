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

namespace Machtsverheffing
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

        double number;

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = double.TryParse(numberTextBox.Text, out number);
            if (number > 84)
            {
                resultTextBox.Text = "Geef een getal kleiner of gelijk aan 84";
            }
            else 
            {
            StringBuilder sb = new StringBuilder();

                for (int i = 1; i < 11; i++)
                {
                    sb.Append($"Macht {i} van {number} is {Convert.ToString(Math.Pow(number, i))}\r\n");
                    string result = sb.ToString();
                    resultTextBox.Text = result;
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            numberTextBox.Text = "1";

        }
    }
}