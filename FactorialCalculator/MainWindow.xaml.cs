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

namespace FactorialCalculator
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                double inputNum = double.Parse(InputBox.Text); 
                double calcNum = inputNum; 

                for (double x = calcNum - 1; x >= 1; x--) 
                {
                    calcNum *= x; 
                }
                
                if (inputNum < 15) 
                {
                    ResBox.Text = calcNum.ToString("###,###");
                }
                else
                {
                    ResBox.Text = calcNum.ToString("e3");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Valid Number", "Error: Wrong Input");
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
