using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagementSystem.Models
{
    public partial class Admin
    {
        public Admin()
        {
            
        }

        public int Id { get; set; }
        public string Aname { get; set; }
        public string Apass { get; set; }
       
    }
}
