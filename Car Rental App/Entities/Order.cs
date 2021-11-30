using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_App.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
    }
}
