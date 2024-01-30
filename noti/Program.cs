using extension;
using NotificationManager;

namespace NotificationManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*string[] numbers = new string[] { "1", "3", "5", "7" };
            numbers.Shuffle();
            foreach (int num in numbers)
                Console.WriteLine(num);*/


            Email email = new Email
            {
                To = "person1@example.com",
                From = "sender@example.com",
                Title = "Important Update",
                Message = "Please check the latest information."
            };
            email.PrintNotification();
            if (email.SendNotification(email))
            {
                Console.WriteLine("Email sent successfully!");
            }
            else
            {
                Console.WriteLine("Error sending email!");
            }

            TextMessage text = new TextMessage
            {
                To = "1234567890",
                From = "5551234567",
                Title = "Reminder",
                Message = "Don't forget the meeting at 3pm."
            };
            text.PrintNotification();
            if (text.SendNotification(text))
            {
                Console.WriteLine("Email sent successfully!");
            }
            else
            {
                Console.WriteLine("Error sending email!");
            }

        }
    }
}

