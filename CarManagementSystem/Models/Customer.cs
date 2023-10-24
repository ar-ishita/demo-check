using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.Models
{
    public partial class Customer
    {
        public Customer()
        {
        }

        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAdd { get; set; }
        public string Phone { get; set; }
       
    }
}
