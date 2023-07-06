using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Abstractions.Services
{
    internal interface IEmailSenderService
    {
        void SendEmail(string email,string text);
    }
}
