using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightSearch.Model
{
    public class ModelEntity
    {
        public string Flightno { get; set; }        
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


    }
}
