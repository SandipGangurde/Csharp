using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DictionaryProgram
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        public void CreateDictionary()
        {
            dictionary.Add(1, "Akanksha");
            dictionary.Add(3, "Sandip");
            dictionary.Add(2, "Pranav");
        }

        public void ReadDictionary()
        {
            Console.WriteLine("Dictionary Contents:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.WriteLine();
        }

        public void UpdateDictionary(int key, string newValue)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = newValue;
                Console.WriteLine($"Item with key {key} updated.");
            }
            else
            {
                Console.WriteLine($"Item with key {key} not found.");
            }
        }

        public void DeleteFromDictionary(int key)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary.Remove(key);
                Console.WriteLine($"Item with key {key} deleted.");
            }
            else
            {
                Console.WriteLine($"Item with key {key} not found.");
            }
        }
    }
}
