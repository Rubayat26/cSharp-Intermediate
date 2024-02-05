
namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.Encode(new Video());  //Here we are not using the video 
                                          //Just to show how it works
                                          //the Encode method needs a video beacuase in
                                          //its blueprint it is defined like that 
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            
            encoder.Encode(new Video());
        }
    }
}


// Here we wnated to create intefaces to achieve Polymorphism  
// Here the idea is to create an Polymorphic Interface of Notifcations
// We created a IList of INotificationChannels
// then created class MailNotioficationChannel which points to INotificationChannel
// then created class SmsNotificationChannel which points to INotificationChannel
// Now we added the NotificationChannels to the INotificationList
// So based on the NotificationChannel the program would behave different or send 
//different notification, so the send method is polymorphyc here


// Now if we want to add a VoiceNotificationChannel to the Ilist we dont need to 
//Change the whole code and recompile
// We will just need a new class VoiceNotificationChannel which will be
//pointing to the INotificationChannel and we will add to the IList 
//The will create a new notification channel so easily 




//OCP - Open Close Principle 
        //Open for Extension and Closed for Modification







