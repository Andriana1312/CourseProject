using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo
{
    public interface IDeliveryMethod
    {
        void DeliverPackage(Colet colet);
        void ShowDeliveryDetails(Colet colet);
    }

    public class DroneDelivery : IDeliveryMethod
    {
        public void DeliverPackage(Colet colet)
        {
            Console.WriteLine($"Coletul: {colet.ID} a fost livrat prin drona catre {colet.Destinatar}.");

        }

        public void ShowDeliveryDetails(Colet colet) 
        {
            Console.WriteLine($"Detalii colet: id {colet.ID},");
            Console.WriteLine($"Greutatea:{colet.Greutatea} kg,");
            Console.WriteLine($"Destinatar:{colet.Destinatar},");
            Console.WriteLine($"Adresa:{colet.Adresa},");
        }
    }

    public class HumanDelivery : IDeliveryMethod
    {
        public void DeliverPackage(Colet colet)
        {
            Console.WriteLine($"Coletul: {colet.ID} a fost livrat personal către {colet.Destinatar}.");
        }

        public void ShowDeliveryDetails(Colet colet)
        {
            Console.WriteLine($"Detalii colet: id {colet.ID},");
            Console.WriteLine($"Greutatea:{colet.Greutatea} kg,");
            Console.WriteLine($"Destinatar:{colet.Destinatar},");
            Console.WriteLine($"Adresa:{colet.Adresa},");
        }
    }
}
