using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows;

namespace Car_Rental_App.Services
{
  public  class SendMail
    {
        public void Send(string address,string mailSubject,string mailBody)
        {
            try
            {
                using(MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("carrentalapp.mailsystem@gmail.com");
                    mail.To.Add(address);
                    mail.Subject = mailSubject;
                    mail.Body = $"<h1>{mailBody}</h1>";
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("carrentalapp.mailsystem@gmail.com", "Riko1234");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
