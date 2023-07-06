using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubaydulloev.Abstractions.Serves
{
    public interface IEmailSenderService
    {
        void SendEmail(string email, string message);
    }
}
