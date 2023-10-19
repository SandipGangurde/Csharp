using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayListProgram
    {
        private ArrayList arrayList = new ArrayList();

        public void Create()
        {
            Console.WriteLine("Enter values to add to the ArrayList (type 'done' to finish):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;

                arrayList.Add(input);
            }
            Console.WriteLine("Items added to the ArrayList.");
        }

        public void Read()
        {
            Console.WriteLine("Items in the ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        public void Update(int index, string newValue)
        {
            if (index >= 1 && index <= arrayList.Count)
            {
                arrayList[index - 1] = newValue;
                Console.WriteLine($"Item at index {index} updated.");
            }
            else
            {
                Console.WriteLine("Index is out of range.");
            }
        }

        public void Delete(int index)
        {
            if (index >= 1 && index <= arrayList.Count)
            {
                arrayList.RemoveAt(index - 1);
                Console.WriteLine($"Item at index {index} deleted.");
            }
            else
            {
                Console.WriteLine("Index is out of range.");
            }
        }
    }
}
