using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.AplicatieMesagerie_Lesson_20
{
    public abstract class Notification
    {
        protected string Recipient { get; set; }
        protected string Message { get; set; }
        public Notification(string recipient, string message) 
        {
            Recipient = recipient;
            Message = message;
        }

        public abstract void Send();

        public abstract string Preview();

        public void SendUrgent(string message)
        { Console.WriteLine($"[URGENT] {message}"); }

        public void SendUrgent(string message, int retryCount)
        { Console.WriteLine($"[URGENT] {message} (Retry: {retryCount} ori)"); }

        public void SendUrgent(string message, bool notifyAdmin)
        {
            Console.WriteLine($"[URGENT] {message}");
            if (notifyAdmin)
            {
                Console.WriteLine("Adminul a fost notificat!");
            }
        }
    }
}
