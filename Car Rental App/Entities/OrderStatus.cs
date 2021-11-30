using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_App.Entities
{
    public class OrderStatus
    {
        public string Suspended { get; set; } = "Suspended";
        public string Active { get; set; } = "Active";
        public string InActive { get; set; } = "InActive";
        public string Expired { get; set; } = "Expired";
        public string Completed { get; set; } = "Completed";
    }
}
