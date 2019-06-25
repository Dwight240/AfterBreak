using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AfterBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromAddress = new MailAddress("wieja.d@gmail.com","From Denis");
            var toAddress = new MailAddress("wiemar93@gmail.com", "To Denver");
            const string fromPassword = "Rcrusoe023s";
            const string subject = "Robota";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address,fromPassword),
                Timeout = 2000
            };

            var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };
            
                smtp.Send(message);
            int x = 2;
            x.

        }
    }
}
