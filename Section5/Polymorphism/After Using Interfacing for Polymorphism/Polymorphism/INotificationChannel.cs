namespace Polymorphism
{
    public interface INotificationChannel
    {
        void Send(Message message);  //Here Message class has no significance
                                     // Beacause here we are not using the me
    }
}