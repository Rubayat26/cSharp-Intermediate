using System;

namespace Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            Console.WriteLine("Sending mail...");
        }
    }
}