using System;
using System.Threading;

namespace hWEvents
{
    public delegate void DelegateEmail(string subject,string body);


    class EmailReceiver
    {
        public event DelegateEmail EmailArrivedEvent;
        private static  Random rnd = new Random();

        public void ListenForNewEmails()
        {
            while (true)
            {
                Thread.Sleep(rnd.Next(3000, 7000));

                if (IsEmailArrived())
                {
                    string subject = GetEmailSubject();
                    string body = GetEmailBody();
                    EmailArrivedEvent?.Invoke(subject, body);
                }
               
            }
        }

        private bool IsEmailArrived()
        {
            return rnd.Next(2) == 0;
        }

        private string GetEmailSubject()
        {
            switch (rnd.Next(4))
            {
                case 0: return "Good week";
                case 1: return "Good morning";
                case 2: return "Good Day";
                default: return "Hi";
            }
        }

        private string GetEmailBody()
        {
            switch (rnd.Next(4))
            {
                case 0: return "please send the required project";
                case 1: return "you got the job!!!";
                case 2: return "how are you";
                default: return "Where are you these days?";
            }
        }
    }

}
