using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class QueueExample
    {
        Queue<string> queue = new Queue<string>();

        public void AddToQueue(string item) {
            queue.Enqueue(item);
            Console.WriteLine($"Item '{item}' added to the queue.");
        }

        public void ViewQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }
            else
            {
                Console.WriteLine("Items in the queue:");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void UpdateQueueItem()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("The queue is empty. Cannot update an item.");
            }
            else
            {
                Console.Write("Enter the item to update: ");
                string oldItem = Console.ReadLine();

                if (queue.Contains(oldItem))
                {
                    Console.Write("Enter the new item: ");
                    string newItem = Console.ReadLine();

                    var updatedQueue = new Queue<string>();

                    while (queue.Count > 0)
                    {
                        string currentItem = queue.Dequeue();
                        if (currentItem == oldItem)
                        {
                            updatedQueue.Enqueue(newItem);
                            Console.WriteLine($"Item '{oldItem}' updated to '{newItem}'.");
                        }
                        else
                        {
                            updatedQueue.Enqueue(currentItem);
                        }
                    }

                    queue = updatedQueue;
                }
                else
                {
                    Console.WriteLine($"Item '{oldItem}' not found in the queue.");
                }
            }
        }

        public void RemoveFromQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("The queue is empty. Cannot remove an item.");
            }
            else
            {
                Console.Write("Enter the item to remove: ");
                string item = Console.ReadLine();

                if (queue.Contains(item))
                {
                    var updatedQueue = new Queue<string>();

                    while (queue.Count > 0)
                    {
                        string currentItem = queue.Dequeue();
                        if (currentItem == item)
                        {
                            Console.WriteLine($"Item '{item}' removed from the queue.");
                        }
                        else
                        {
                            updatedQueue.Enqueue(currentItem);
                        }
                    }

                    queue = updatedQueue;
                }
                else
                {
                    Console.WriteLine($"Item '{item}' not found in the queue.");
                }
            }
        }

    }
}
