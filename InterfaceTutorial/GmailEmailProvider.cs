using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTutorial;

internal class GmailEmailProvider : IEmailSender
{
    public void SendEmail(string email)
    {
        var id = $"{email}@gmail.com";
        Console.WriteLine($"Sending email to {id}");
    }
}
