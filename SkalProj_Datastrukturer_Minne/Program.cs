using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine(
                    "Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            // Fråga: När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
            // Svar: När man utgår från en tom lista, så ökar kapaticteten när antalet element i arrayen
            // överskrider 4. 
            
            // Fråga: Med hur mycket ökar kapaciteten?
            // Svar: Kapaciteten ökar dubbelt när varje kapacitets gräns är nådd.
            // När antalet element i kommer upp i 5, så blir kapaticteten 8. 
            // När antalet element kommer upp i 9, så blir kapaciteten 16. 
            // Sen så blir det 32, 64 osv...
            
            // Fråga: Varför ökar inte listans kapacitet i samma takt som element läggs till?
            // Svar: Anledningen till att en listas kapacitet inte ökar i samma takt som ett element
            // läggs till är pga. prestandaskäl. Istället för att en ny array behöver skapas samt kopiera
            // över referenserna till strängarna(från gamla arrayen)
            // varje gång en ny sträng läggs till i Listan, så behöver denna operation endast
            // göras när kapacitetsgränsen överskrids.
            
            // Fråga: Minskar kapaciteten när element tas bort ur listan?
            // Nej, kapaciten tycks inte minska när ett element tas bort ur listan, vilket kan demonstreras
            // med denna metod
            
            // Fråga: När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
            // När vi på förhand vet exakt hur många element som arrayen kommer behöva. T.ex om man skapar
            // ett schackspel eller liknande, där antalet rektanglar som man kan röra sig på alltid är densamma.
            // Kanske även om man skapar en DTO eller liknande, efter att ha hämtat ut en lista från en databas
            // och sedan ska transportera den listan till en Endpoint.
            // Men även när en lista skapas dynamiskt i koden och där vi inte förväntar oss att arrayen
            // kommer att öka under körningens gång.
            
            
            
            List<string> theList = new List<string>();
            bool subMenuRunning = true;

            while (subMenuRunning)
            {
                Console.WriteLine("Available Actions:" +
                                  "\n+<Value> : Add the value to the list" +
                                  "\n-<Value> : Remove the value from the list" +
                                  "\ne : Exit to main menu");

                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter valid input.");
                }
                else
                {
                    switch (input[0])
                    {
                        case '+':
                            if (input.Length > 1)
                            {
                                string trimmedInput = input.Substring(1).Trim();
                                if (trimmedInput.Length == 0)
                                {
                                    Console.WriteLine("Please enter a valid value after the + sign.");
                                }
                                else
                                {
                                    if (theList.Contains(trimmedInput))
                                    {
                                        Console.WriteLine(
                                            "The input already exists in the list, please add a unique value.");
                                    }
                                    else
                                    {
                                        theList.Add(trimmedInput);
                                        Console.WriteLine($"\"{trimmedInput}\" added to the list.");
                                        Console.WriteLine($"Current List capacity: {theList.Capacity}");
                                        Console.WriteLine($"Current List count: {theList.Count}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a value to add.");
                            }

                            break;

                        case '-':
                            if (input.Length > 1)
                            {
                                string trimmedInput = input.Substring(1).Trim();
                                if (trimmedInput.Length == 0)
                                {
                                    Console.WriteLine("Please enter a valid value after the - sign.");
                                }
                                else
                                {
                                    if (theList.Remove(trimmedInput))
                                    {
                                        Console.WriteLine($"\"{trimmedInput}\" removed from the list.");
                                        Console.WriteLine($"Current List capacity: {theList.Capacity}");
                                        Console.WriteLine($"Current List count: {theList.Count}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Input not found in the list, nothing was removed.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a value to remove.");
                            }

                            break;

                        case 'e':
                            subMenuRunning = false; // Exit the loop
                            Console.WriteLine("Exiting to main menu.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
             */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
             */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
        }
    }
}