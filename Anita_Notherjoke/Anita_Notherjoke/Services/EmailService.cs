using Anita_Notherjoke.DataAccess.Context;
using System.Net.Mail;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Anita_Notherjoke.Services
{
    public class EmailService
    {
        private readonly Anita_NotherjokeDbContext _dbContext;

        public EmailService(Anita_NotherjokeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SendEmail(int userId, string subject, string content, string recipient)
        {
            var user = _dbContext.Users.Include(u => u.UserEmails).FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            var smtpClient = new SmtpClient("smtp.example.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your_username", "your_password"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("your_email@example.com"),
                Subject = subject,
                Body = content,
            };

            mailMessage.To.Add(recipient);

            smtpClient.Send(mailMessage);

            Console.WriteLine("Email sent successfully!");
        }
    }
}
