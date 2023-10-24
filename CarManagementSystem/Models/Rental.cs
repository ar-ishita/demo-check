using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.Models
{
    public partial class Rental
    {
        public Rental()
        {
            
        }

        public int RentId { get; set; }
        public string carReg { get; set; }
        public string CustName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int RentFee { get; set; }

      
    }
}
