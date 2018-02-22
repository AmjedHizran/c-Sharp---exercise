using System;
using System.Threading;

namespace hWEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailReceiver EmailReceiverEvent = new EmailReceiver();
            EmailReceiverEvent.EmailArrivedEvent += Print;
            EmailReceiverEvent.ListenForNewEmails();
        }

        static void Print(string subject, string body)
        {
            Console.WriteLine("You've got new email!");
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Body: " + body+"\n\n");
        }
    }
}
