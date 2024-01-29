using System;

namespace Polymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}