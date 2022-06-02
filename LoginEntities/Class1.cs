using System;
using System.ComponentModel.DataAnnotations;

namespace LoginEntities
{
    public class Class1
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Admin { get; set; }

    }
}
