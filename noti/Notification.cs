using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace NotificationManager
{
    public class Notification
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public virtual void PrintNotification()
        {
            Console.WriteLine($"-- Notification --");
            Console.WriteLine($"To: {To}");
            Console.WriteLine($"From: {From}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Message: {Message}");
        }
    }
    public interface INotificationSender
    {
        bool SendNotification(Notification notification);
    }
    
}