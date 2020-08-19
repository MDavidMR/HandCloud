using System;
using System.Collections.Generic;
using System.Text;

namespace HandCloud.Domain
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public int Kilometers { get; set; }
        public decimal Price { get; set; }
    }
}
