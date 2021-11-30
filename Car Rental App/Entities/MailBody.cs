using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Car_Rental_App.Entities
{
    public static class MailBody
    {
        public static string VerificationMail { get; set; } = "This mail send by Car Rental App for mail verification";
        public static string LoginInfoMail { get; set; } = $"You logged in Car Rental App at {DateTime.Now.ToLongDateString()} from {RegionInfo.CurrentRegion.NativeName}";

    }
}
