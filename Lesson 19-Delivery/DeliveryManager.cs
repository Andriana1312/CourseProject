using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.Delivery
{
    public class DeliveryManager
    {
        private readonly IDeliveryMethod _deliveryMethod;

        public DeliveryManager(IDeliveryMethod deliveryMethod)
            {
                _deliveryMethod = deliveryMethod;
            }

        public void ProcessDelivery(Colet colet)
           {
            _deliveryMethod.ShowDeliveryDetails(colet);
            Console.WriteLine();
            _deliveryMethod.DeliverPackage(colet);
            Console.WriteLine();
           }
    }
}
