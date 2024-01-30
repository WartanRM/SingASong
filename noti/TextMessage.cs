using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManager
{
    public class TextMessage : Notification, INotificationSender
    {
        public override void PrintNotification()
        {
            Console.WriteLine($"-- Text Message Notification --");
            base.PrintNotification();
            Console.WriteLine("Sent via Text Message");
        }

        public bool SendNotification(Notification notification)
        {

            Console.WriteLine($"Sending SMS to {notification.To} with message: {notification.Message}");
            return true;
        }
    }
}
