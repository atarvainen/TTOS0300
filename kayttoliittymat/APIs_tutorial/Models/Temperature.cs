using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIs_tutorial.Models
{
    public class Weather
    {
        public int id { get; set; }

        public string City { get; set; }

        public string Temperature { get; set; }

        public string Precipitation { get; set; }

        public string Humidity { get; set; }

        public string Wind { get; set; }
    }
}