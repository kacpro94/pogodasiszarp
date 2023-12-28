using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class WeatherForecast
    {
        public double dt { get; set; }
        public class weather
        { 
            public string main { get;set; }
            public string description { get; set; }
            public string icon { get; set; }

        }
        public class main
        {
            public double temp;
        }
        public class list
        {
            public main temp;
            public long dt { get; set; }
            public List<weather> weather { get; set;}

        }
        public class ForecastInfo
        {
            public List<list> list { get; set; }
        }
    }
}
