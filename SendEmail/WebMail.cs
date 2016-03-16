using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SendEmail
{
    public static class WebMail
    {
        public static void SendMail(string Body, string Subject, string SmtpServer, string FromEmail, string Password, string ToEmail)
        {
            try
            {
                MailMessage mailMessage=new MailMessage(FromEmail,ToEmail,Subject,Body);
                mailMessage.IsBodyHtml = true;
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = SmtpServer;
                    smtp.Port = 25;
                    
                    smtp.EnableSsl = false;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(FromEmail, Password);
                    smtp.Timeout = 20000;
                }
                smtp.Send(mailMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}