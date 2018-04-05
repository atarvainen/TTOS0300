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

namespace Autotall1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string polku = "d:/L4623/";

        List<JAMK.IT.Auto> autot = new List<JAMK.IT.Auto>();
        public MainWindow()
        {
            InitializeComponent();

            //aloituskuva
            NaytaKuva("autotalli.png");

            autot = JAMK.IT.Autotalli.HaeAutot();

            //täytetään combobox autojen merkeillä
            //VE1: manuaalisesti
            /*
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Volvo");
            merkit.Add("Saab");
            cmbMerkit.ItemsSource = merkit;
            */

            //VE:2
            //automaagisesti LINQulla datasta
            var result = autot.Select(m => m.Merkki).Distinct();
            cmbMerkit.ItemsSource = result;


        }

        private void NaytaKuva(string url)
        {
            try
            {
                if (url != "")
                {
                    //lisätään vakopolku kuvatiedostoon
                    url = polku + url;

                    //Kuvan näyttö
                    if (System.IO.File.Exists(url))
                    {
                        BitmapImage bi = new BitmapImage();
                        bi.BeginInit();
                        bi.UriSource = new Uri(url);
                        bi.EndInit();
                        imgAuto.Stretch = Stretch.Fill;
                        imgAuto.Source = bi;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            //dgAutot.ItemsSource = JAMK.IT.Autotalli.HaeAutot();
            dgAutot.ItemsSource = autot;
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //olemme itse populoineet datagridin auto-olioilla joten kukin
            //datagridin rivi eli alkio on itseasiassa auto-olio
            /*
            object obj = dgAutot.SelectedItem;
            if (obj != null)
            {
                JAMK.IT.Auto valittu = (JAMK.IT.Auto)obj;
                NaytaKuva(valittu.URL);
            }
            */
            JAMK.IT.Auto valittu = dgAutot.SelectedItem as JAMK.IT.Auto;
            if (valittu != null)
            {
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //näkyviin pelkästään audi merkkiset -> suodatetaan auto listasta audit
            //LINQ
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void cmbMerkit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string merkki = cmbMerkit.SelectedItem.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki)).ToList();
            dgAutot.ItemsSource = result;
            NaytaKuva("autotalli.png");
        }
    }
}
