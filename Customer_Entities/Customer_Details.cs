using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Customer_Entities
{
   public class Customer_Details
    {
       [Key]
        public int Id { get; set; }
        public string RName { get; set; }
        public int age { get; set; }
        public string meal { get; set; }
        public string SeatNumbers { get; set; }

        public string PNR_number { get; set; }

        public string Flight_Number { get; set; }

        [ForeignKey("Emailid")]
        public virtual Customer_Header Email_id { get; set; }
        public string Emailid { get; set; }

    }
}
