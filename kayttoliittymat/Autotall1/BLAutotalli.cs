using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VM { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }
    }

    public static class Autotalli
    {
        public static List<Auto> HaeAutot()
        {
            //GUI testaamista varten dummy dataa
            List<Auto> autot = new List<Auto>();
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 2007;
            a.KM = 300000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.PNG";

            autot.Add(a);

            //toinen auto
            Auto b = new Auto() { Merkki = "Audi", Malli = "A4", VM = 2010, KM = 100000, Hinta = 20000F, URL = "AudiA4.png" };

            autot.Add(b);

            //kolmas auto
            autot.Add(new Auto() { Merkki = "Saab", Malli = "99", VM = 2000, KM = 500000, Hinta = 2000F, URL = "Saab99.jpg" });

            autot.Add(new Auto() { Merkki = "Cadillac", Malli = "2017", VM = 2017, KM = 1000, Hinta = 150000, URL = "Cadillac.jpg" });
            //palauta

            return autot;
        }
    }
}
