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

namespace PwDemo
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
        private void PwBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            int[] statistics = new int[5];

            statistics[0] = PwBox.Password.Length;

            statistics[1] = PwBox.Password.Count(char.IsUpper);
            statistics[2] = PwBox.Password.Count(char.IsLower);
            statistics[3] = PwBox.Password.Count(char.IsNumber);

            statistics[4] = PwBox.Password.Length - (statistics[1] + statistics[2] + statistics[3]);

            CharCount.Text = "Char count: " + statistics[0];
            Upper.Text = "Capital letters: " + statistics[1];
            Lower.Text = "Lower case letters: " + statistics[2];
            Numbers.Text = "Numbers: " + statistics[3];
            Specials.Text = "Specials: " + statistics[4];

            int categoryCount = 0;

            for (int i = 1; i < 5; i++)
            {
                if (statistics[i] > 0)
                {
                    categoryCount++;
                }
            }

            if (statistics[0] > 15 && categoryCount > 3)
            {
                PwStrength.Content = "Good";
                PwStrength.Background = Brushes.Green;
            }

            else if (statistics[0] < 16 && categoryCount > 2)
            {
                PwStrength.Content = "Moderate";
                PwStrength.Background = Brushes.LawnGreen;
            }

            else if (statistics[0] < 12 && categoryCount > 1)
            {
                PwStrength.Content = "Fair";
                PwStrength.Background = Brushes.Yellow;
            }

            else if (statistics[0] < 8 || categoryCount == 1)
            {
                PwStrength.Content = "Bad";
                PwStrength.Background = Brushes.Red;
            }
        }
    }
}
