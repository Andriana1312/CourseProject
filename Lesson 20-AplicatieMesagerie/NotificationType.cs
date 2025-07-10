using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.AplicatieMesagerie_Lesson_20
{
    class EmailNotification : Notification
    {
        public EmailNotification(string recipient, string message) : base(recipient, message)
        {
        }
        public override void Send()
        {
            Console.WriteLine($"Expedierea email către: {Recipient} cu mesajul: {Message}");
        }

        public override string Preview()
        {
           return $"[EMAIL] Către: {Recipient}: {Message}";
        }

        
    }

    class SMSNotification : Notification
    {
        public SMSNotification(string recipient, string message) : base(recipient, message)
        {
        }
        public override void Send()
        {
            Console.WriteLine($"Expedierea SMS către: {Recipient} cu mesajul: {Message}");
        }

        public override string Preview()
        {
            return $"[SMS] Către: {Recipient}: {Message}";
        }

    }

    class PushNotification : Notification
    {
        public PushNotification(string recipient, string message) : base(recipient, message)
        {
        }
        public override void Send()
        {
            Console.WriteLine($"Expedierea push către: {Recipient} cu mesajul: {Message}");
        }

        public override string Preview()
        {
            return $"[Push] Către: {Recipient}: {Message}";
        }
    }

    class InAppNotification : Notification
    {
        public InAppNotification(string recipient, string message) : base(recipient, message)
        {
        }
        public override void Send()
        {
            Console.WriteLine($"Notificare a fost salvata pentru: {Recipient} cu mesajul: {Message}");
        }

        public override string Preview()
        {
            return $"[In-App] Către: {Recipient}: {Message}";
        }
    }

   
}
