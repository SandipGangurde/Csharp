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
                Console.WriteLine("4. Queue");
                Console.WriteLine("5. Tuple");
                Console.WriteLine("6. Delegate");
                Console.WriteLine("7. Exit");

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
                        PerformQueueOperations();
                        break;
                    case 5:
                        PerformTupleOperations();
                        break;
                    case 6:
                        PerformDelegateMathOperation();
                        break;
                    case 7:
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

        static void PerformQueueOperations() {
            QueueExample queueExample = new QueueExample();
            while (true)
            {
                Console.WriteLine("Queue CRUD Operations:");
                Console.WriteLine("1. Add an item to the queue");
                Console.WriteLine("2. View the queue");
                Console.WriteLine("3. Update an item in the queue");
                Console.WriteLine("4. Remove an item from the queue");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter an item to add to the queue: ");
                            string item = Console.ReadLine();
                            queueExample.AddToQueue(item);
                            break;
                        case 2:
                            queueExample.ViewQueue();
                            break;
                        case 3:                
                            queueExample.UpdateQueueItem();
                            break;
                        case 4:
                            queueExample.RemoveFromQueue();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static void PerformTupleOperations() {
            TupleProgram tupleProgram = new TupleProgram();
            while (true)
            {
                Console.WriteLine("Tuple CRUD Operations Menu:");
                Console.WriteLine("1. Create a new person");
                Console.WriteLine("2. Read person details");
                Console.WriteLine("3. Update person details");
                Console.WriteLine("4. Delete a field");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Go To Main Menu");
                Console.Write("Select an option (1-6): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            tupleProgram.CreatePerson();
                            break;
                        case 2:
                            tupleProgram.ReadPerson();
                            break;
                        case 3:
                            tupleProgram.UpdatePerson();
                            break;
                        case 4:
                            tupleProgram.DeleteField();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        case 6:
                            MainMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        delegate int MathOperation(int a, int b);

        static void PerformDelegateMathOperation()
        {
            MathDelegateProgram program = new MathDelegateProgram();

            while (true)
            {
                Console.WriteLine("Math Operations Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Go To Main Menu");
                Console.Write("Select an option (1-6): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            program.PerformMathOperation("Addition", program.Add);
                            break;
                        case 2:
                            program.PerformMathOperation("Subtraction", program.Subtract);
                            break;
                        case 3:
                            program.PerformMathOperation("Multiplication", program.Multiply);
                            break;
                        case 4:
                            program.PerformMathOperation("Division", program.Divide);
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        case 6:
                            MainMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}