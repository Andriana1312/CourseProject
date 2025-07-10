using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.Lesson_24_SOLID_ClasaOrder
{
    public class OrderManager
    {
        public void SaveToDatabase(Order order)
        {
            Console.WriteLine($"Saving order {order.Id} to database...");
        }

        public void LoadFromDatabase(int orderId)
        {
            Console.WriteLine($"Loading order {orderId} from database...");
        }
    }
}
