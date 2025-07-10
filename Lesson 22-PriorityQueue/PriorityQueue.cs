using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace CoursePartTwo.Lesson_22_PriorityQueue
{
    public class PriorityQueue<T>
    {
        private List<PriorityQueueItem> items = new List<PriorityQueueItem>();

        internal class PriorityQueueItem
        {  
            public T Item { get; set; }
            public int Priority { get; set; }

            public PriorityQueueItem(T item, int priority)
            {
                Item = item;
                Priority = priority;
            }
        }

        public void Enqueue(T item, int priority)
        {
            var newItem = new PriorityQueueItem(item, priority);
            items.Add(newItem);
            Console.WriteLine($"Item added: {item}, priority: {priority}");
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Queue content:");

            foreach (var i in items.OrderByDescending(i => i.Priority))
            {
                Console.WriteLine($" {i.Item} (Priority: {i.Priority})");
            }
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Peek: Queue is empty!");

            int maxPriority = items.Max(i => i.Priority);
            var item = items.First(i => i.Priority == maxPriority);

            return item.Item;
        }

        public T Dequeue()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Dequeue: Impossible dequeue from empty queue!");

            int maxPriority = items.Max(i => i.Priority);
            var item = items.First(i => i.Priority == maxPriority);
            
            items.Remove(item);
            
            return item.Item;
        }
       
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

    }
}
