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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            ColorAnimation blackToWhite = new ColorAnimation(Colors.White, Colors.Black, new Duration(new TimeSpan(100000)));
            blackToWhite.AutoReverse = true;
            blackToWhite.RepeatBehavior = RepeatBehavior.Forever;
            SolidColorBrush scb = new SolidColorBrush(Colors.Black);
            scb.BeginAnimation(SolidColorBrush.ColorProperty, blackToWhite);

            InfoTextBlock.Foreground = scb;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ColorAnimation blackToWhite = new ColorAnimation(Colors.White, Colors.Black, new Duration(new TimeSpan(100000)));
            blackToWhite.AutoReverse = true;
            blackToWhite.RepeatBehavior = RepeatBehavior.Forever;
            SolidColorBrush scb = new SolidColorBrush(Colors.Black);
            scb.BeginAnimation(SolidColorBrush.ColorProperty, blackToWhite);
            InfoTextBlock.Foreground = scb;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            InfoTextBlock.Foreground = Brushes.Black;
        }
        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            lblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }

        private void txtEditor_KeyUp(object sender, KeyEventArgs e)
        {
            int length = txtEditor.Text.Length;
            int asdf = length * 100 / txtEditor.MaxLength;
            ProgressBar.Value = asdf;
            TextBlockCapacity.Text = ProgressBar.Value + "%";
        }
    }
}
