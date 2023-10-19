namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu() {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. ArrayList Operations");
                Console.WriteLine("2. SortedList Operations");
                Console.WriteLine("3. Dictionary Operations");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PerformArrayListOperations();
                        break;
                    case 2:
                        PerformSortedListOperations();
                        break;
                    case 3:
                        PerformDictionaryOperations();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void PerformArrayListOperations()
        {
            ArrayListProgram arrayCRUD = new ArrayListProgram();

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Go To Main Menu");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        arrayCRUD.Create();
                        break;
                    case 2:
                        arrayCRUD.Read();
                        break;
                    case 3:
                        Console.Write("Enter the index to update: ");
                        int updateIndex = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the new value: ");
                        string updateValue = Console.ReadLine();
                        arrayCRUD.Update(updateIndex, updateValue);
                        break;
                    case 4:
                        Console.Write("Enter the index to delete: ");
                        int deleteIndex = Convert.ToInt32(Console.ReadLine());
                        arrayCRUD.Delete(deleteIndex);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    case 6:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void PerformSortedListOperations()
        {
            SortedListProgram sortedListProgram = new SortedListProgram();
            sortedListProgram.CreateSortedList();
            sortedListProgram.ReadSortedList();
            sortedListProgram.UpdateSortedList(2, "Nashik");
            sortedListProgram.ReadSortedList();
            sortedListProgram.DeleteFromSortedList(2);
            sortedListProgram.ReadSortedList();
        }

        static void PerformDictionaryOperations()
        {
            DictionaryProgram dictionaryProgram = new DictionaryProgram();
            dictionaryProgram.CreateDictionary();
            dictionaryProgram.ReadDictionary();
            dictionaryProgram.UpdateDictionary(2, "Nashik");
            dictionaryProgram.ReadDictionary();
            dictionaryProgram.DeleteFromDictionary(2);
            dictionaryProgram.ReadDictionary();
        }
    }
}