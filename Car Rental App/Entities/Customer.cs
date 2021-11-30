using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_App.Entities
{
  public  class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LicsenseId { get; set; }
        public BankCard BankCard { get; set; }
    }
}
