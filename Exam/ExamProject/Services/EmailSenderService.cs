using ExamProject.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Services
{
    internal class EmailSenderService : IEmailSenderService
    {
        public void SendEmail(string email, string text)
        {
            Console.WriteLine($"{text} is sent to {email}");
        }
    }
}
