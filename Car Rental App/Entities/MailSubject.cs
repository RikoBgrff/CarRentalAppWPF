using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_App.Entities
{
   public static class MailSubject
    {
        public static string VerificationMail { get; set; } = "Verification Email from Car Rental App";
        public static string LoginInfoMail { get; set; } = "Login Information Email from Car Rental App";
    }
}
