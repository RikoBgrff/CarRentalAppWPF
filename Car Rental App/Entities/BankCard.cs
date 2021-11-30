using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_App.Entities
{
    public class BankCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CardHoldersName { get; set; }
        public int SecurityCode { get; set; }

    }
}
