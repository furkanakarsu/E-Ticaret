using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace COMMON
{
    public class MailSender
    {
        public static void SendEmail(string email, string subject, string message)
        {
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("mvcemail62@gmail.com", "YMS3102");
            sender.To.Add(email);
            sender.Subject = subject;
            sender.Body = message;

            //smtp
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("mvcemail62@gmail.com", "Bilgeadam62");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(sender);


        }
    }
}
