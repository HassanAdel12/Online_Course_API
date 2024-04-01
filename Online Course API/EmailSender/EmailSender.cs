using System.Net.Mail;
using System.Net;
using System.Text;

namespace Online_Course_API.EmailSender
{
    public class EmailSender
    {
        public void SendEmail(string toEmail, string subject)
        {
            // Set up SMTP client
            SmtpClient client = new SmtpClient("smtp.ethereal.email", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("hassan.adel.hussein@gmail.com", "djgwPz8DPss78aakBv");

            // Create email message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("hassan.adel.hussein@gmail.com");
            mailMessage.To.Add(toEmail);
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            StringBuilder mailBody = new StringBuilder();
            mailBody.AppendFormat("<h1>Student Eroll</h1>");
            mailBody.AppendFormat("<br />");
            mailBody.AppendFormat("<p>Thank you For teach his student</p>");
            mailMessage.Body = mailBody.ToString();

            // Send email
            client.Send(mailMessage);
        }
    }
}
