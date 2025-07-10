using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.Lesson_25_SOLID_IWorker
{
    public interface IWorker
    {
        void Work();
    }
    public interface IEater
    {
        void Eat();
    }

    public class HumanWorker : IWorker, IEater
    {
        public void Work()
        {
            Console.WriteLine("Human working...");
        }

        public void Eat()
        {
            Console.WriteLine("Human eating...");
        }
    }

    public class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot working...");
        }

    }
}
