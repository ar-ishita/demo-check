using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.ViewModel
{
    public class CustomerDTO
    {
        public CustomerDTO()
        {
        }

        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAdd { get; set; }
        public string Phone { get; set; }
    }
}
