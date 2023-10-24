using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.ViewModel
{
    public class ReturnDTO
    {
        public ReturnDTO()
        {
        }

        public int ReturnId { get; set; }
        public string CarReg { get; set; }
        public string CustName { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Delay { get; set; }
        public string Fine { get; set; }

    }
}
