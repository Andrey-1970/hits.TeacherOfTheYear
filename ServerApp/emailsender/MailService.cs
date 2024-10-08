using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace ServerApp.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailConfig;

        public MailService(IOptions<MailSettings> mailConfig)
        {
            _mailConfig = mailConfig.Value;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string htmlBody)
        {

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_mailConfig.FromEmail));
            email.To.Add(MailboxAddress.Parse(toEmail));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlBody };

            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                Console.Write(email.From);
                await smtp.ConnectAsync(_mailConfig.Host, _mailConfig.Port, SecureSocketOptions.None);
                await smtp.AuthenticateAsync(_mailConfig.Username, _mailConfig.Password);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
        }
    }

}
public class MailSettings
{
    public int Port { get; set; }
    public string? FromEmail { get; set; }
    public string? Host { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}