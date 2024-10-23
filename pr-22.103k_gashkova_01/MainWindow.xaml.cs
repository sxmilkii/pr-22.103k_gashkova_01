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

namespace pr_22._103k_gashkova_01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            string input = InputNumber.Text;
            if (input.Length != 12 || !long.TryParse(input, out _))
            {
                OutputText.Text = "Введите корректное 12-значное число.";
                return;
            }
            
            int[] digits = Array.ConvertAll(input.ToCharArray(), c => (int)char.GetNumericValue(c));

            int product = digits[0] * digits[1] * digits[2];

            int sum = digits[3] + digits[4] + digits[5] + digits[6] + digits[7] + digits[8] + digits[9] + digits[10] + digits[11];

            if (product == sum)
            {
                OutputText.Text = "Произведение первых 3 цифр равно сумме последних 9 цифр.";
            }
            else
            {
                OutputText.Text = "Произведение первых 3 цифр не равно сумме последних 9 цифр.";
            }
        }
    }
}