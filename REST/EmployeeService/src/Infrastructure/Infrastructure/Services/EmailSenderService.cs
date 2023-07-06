using Application.Abstractions.Services;

namespace Infrastructure.Services
{
    internal class EmailSenderService : IEmailSenderService
    {
        public void SendEmail(string email, string text)
        {
            Console.WriteLine($"{text} is sent to {email}");
        }
    }
}
