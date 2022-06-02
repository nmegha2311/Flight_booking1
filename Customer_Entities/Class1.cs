using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer_Entities
{
    public class Customer_Header
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string Emailid { get; set; }

        public string Name { get; set; }

        public int Nos { get; set; }
        
    }
}
