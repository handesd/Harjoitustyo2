using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Harjoitustyo2.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        // Foreign Key
        public int OwnerId { get; set; }
        // Navigation property
        public Owner Owner { get; set; }
    }
}