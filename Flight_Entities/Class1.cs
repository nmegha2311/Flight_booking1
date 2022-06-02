using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flight_Entities
{
    public class Flight
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string Flightno { get; set; }
        public string Airline { get; set; }
        public string isActive { get; set; }
    }
}
