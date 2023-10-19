using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SortedListProgram
    {
        SortedList<int, string> sortedList = new SortedList<int, string>();

        public void CreateSortedList()
        {
            sortedList.Add(1, "Akanksha");
            sortedList.Add(3, "Sandip");
            sortedList.Add(2, "Pranav");
        }

        public void ReadSortedList()
        {
            Console.WriteLine("Sorted List Contents:");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.WriteLine();
        }

        public void UpdateSortedList(int key, string newValue)
        {
            if (sortedList.ContainsKey(key))
            {
                sortedList[key] = newValue;
                Console.WriteLine($"Item with key {key} updated.");
            }
            else
            {
                Console.WriteLine($"Item with key {key} not found.");
            }
        }

        public void DeleteFromSortedList(int key)
        {
            if (sortedList.ContainsKey(key))
            {
                sortedList.Remove(key);
                Console.WriteLine($"Item with key {key} deleted.");
            }
            else
            {
                Console.WriteLine($"Item with key {key} not found.");
            }
        }
    }
}
