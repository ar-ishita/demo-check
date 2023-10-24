using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.Models
{
    public partial class Car
    {
        public Car()
        {
            
        }

        public string RegNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Available { get; set; }
        public string Price { get; set; }
      
    }
}
