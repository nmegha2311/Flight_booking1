using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airline.Model
{
    public class ModelEntities1
    {
        public string Flightno { get; set; }

        public string Airline { get; set; }
        public DateTime Enddate { get; set; }

        public DateTime startdate { get; set; }

        public string Name { get; set; }

        public string Instrument { get; set; }

        public int business { get; set; }
        public int non_business { get; set; }

        public int cost { get; set; }

        public int rows { get; set; }

        public string meal { get; set; }

        public string scheduledays { get; set; }

        public string PNR_number { get; set; }

        public string from_place { get; set; }

        public string to_place { get; set; }

        public string isActive { get; set; }
    }
}
