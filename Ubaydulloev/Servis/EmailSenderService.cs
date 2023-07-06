using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubaydulloev.Abstractions.Serves;

namespace Ubaydulloev.Servis
{
    internal class EmailSenderService : IEmailSenderService
    {
        public void SendEmail(string email, string message)
        {
              Console.WriteLine( message + email);
        }
    }
}
