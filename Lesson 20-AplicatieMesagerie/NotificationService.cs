using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.AplicatieMesagerie_Lesson_20
{
    public class NotificationService
    {
        public static void SendAll(List<Notification> notifications)
        {
            foreach (var notification in notifications)
            {
                notification.Send();
            }
        }
        public static void GenerateReport(List<Notification> notifications)
        {
            foreach (var notification in notifications)
            {
                Console.WriteLine(notification.Preview());
            }
        }
    }
}
