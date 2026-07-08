using System.Net;
using System.Net.Mail;

namespace CustomerCommunicationLibrary
{
    /// <summary>
    /// Concrete implementation that talks to a real SMTP server.
    /// This class CANNOT be unit tested directly because it requires
    /// an actual SMTP connection — that is why we use the IEmailService
    /// interface and Moq to replace it during tests.
    /// </summary>
    public class EmailService : IEmailService
    {
        public bool SendMail(string toAddress, string message)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("your_email_address@gmail.com");
            mail.To.Add(toAddress);
            mail.Subject = "Test Mail";
            mail.Body = message;

            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential("username", "password");
            smtpServer.EnableSsl = true;

            // In production this actually connects to Gmail.
            // In tests we NEVER reach this line — the mock intercepts the call.
            smtpServer.Send(mail);

            return true;
        }
    }
}
