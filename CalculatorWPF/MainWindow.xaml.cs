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

namespace CalculatorWPF
{
    public partial class MainWindow : Window
    {
        double number1, number2;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            getValues();
            // MessageBox.Show("Result: " + (number1 + number2), "Calculation Result", MessageBoxButton.OK, MessageBoxImage.Information);
            Result r = new Result("Result: " + (number1 + number2));
            r.ShowDialog();
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            getValues();
            // MessageBox.Show("Result: " + (number1 - number2), "Calculation Result", MessageBoxButton.OK, MessageBoxImage.Information);
            Result r = new Result("Result: " + (number1 - number2));
            r.ShowDialog();
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            getValues();
            MessageBox.Show("Result: " + (number1 * number2), "Calculation Result", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            getValues();
            if (number2 != 0)
                MessageBox.Show("Result: " + (number1 / number2), "Calculation Result", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }

        public void getValues()
        {
            if (((TabItem)LayoutTabControl.SelectedItem).Header.Equals("Stack"))
            {
                double.TryParse(txtNumber1.Text, out number1);
                double.TryParse(txtNumber2.Text, out number2);
            }
            else if (((TabItem)LayoutTabControl.SelectedItem).Header.Equals("Grid"))
            {
                double.TryParse(txtNumber1Grid.Text, out number1);
                double.TryParse(txtNumber2Grid.Text, out number2);
            }
        }        
    }
}
