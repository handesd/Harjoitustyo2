using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Harjoitustyo2.Models
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
    }
}

namespace Harjoitustyo2.Models
{
    public class CarDetailDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string OwnerName { get; set; }
    }
}