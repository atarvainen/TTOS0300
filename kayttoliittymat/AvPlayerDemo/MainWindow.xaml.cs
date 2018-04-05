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

namespace AvPlayerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IsPlaying(false);
        }

        private void IsPlaying(bool flag)
        {
            PlayButton.IsEnabled = flag;
            StopButton.IsEnabled = flag;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            //dlg.DefaultExt = ".WMV";
            //dlg.Filter = "WMV file (.wm)|*.wmv";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                MediaPlayer.Source = new Uri(dlg.FileName);
                PlayButton.IsEnabled = true;
            }

            if (result == true)
            {
                string filename = dlg.FileName;
                AvPath.Text = filename;
            }

        }
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Play();
            IsPlaying(true);
            PlayButton.IsEnabled = false;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Pause();
            IsPlaying(false);
            PlayButton.IsEnabled = true;
        }
    }
}
