using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Customer_Entities
{
    public class Discount
    {
        [Key]
        public int id { get; set; } 
        public string discount { get; set; }

    }
}
