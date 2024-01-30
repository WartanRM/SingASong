using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManager
{
    public class Email : Notification, INotificationSender
    {
        public override void PrintNotification()
        {
            Console.WriteLine($"-- Email Notification --");
            base.PrintNotification();
            Console.WriteLine("Sent via Email");
        }

        public bool SendNotification(Notification notification)
        {

            Console.WriteLine($"Sending email to {notification.To} with subject: {notification.Title}");

            return true;
        }
    }
}
