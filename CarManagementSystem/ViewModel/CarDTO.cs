using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.ViewModel
{
    public class CarDTO
    {
        public CarDTO()
        {
            
        }

        public string RegNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Available { get; set; }
        public string Price { get; set; }
       
    }
}
