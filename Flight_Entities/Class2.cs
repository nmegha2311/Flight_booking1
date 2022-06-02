using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Flight_Entities
{
   public class Class2
    {
        [Key]
        public string id { get; set; }

        public string From_Place { get; set; }
        public string To_Place { get; set; }
        public DateTime Startdatetime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Scheduledays { get; set; }
        public string Instrumentused { get; set; }
        public int Business { get; set; }

        public int non_business { get; set; }

        public int cost { get; set; }
        public int rows { get; set; }
        public string meal { get; set; }

    


     

        [ForeignKey("Flight_number"),Required]
        public virtual Flight Fligt_no { get; set; }
        public string Flight_number { get; set; }

    }
}
