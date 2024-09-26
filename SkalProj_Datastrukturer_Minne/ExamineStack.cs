using System.Collections;

namespace SkalProj_Datastrukturer_Minne;

/// <summary>
/// Examines the datastructure Stack
/// </summary>
public static class ExamineStack
{
    public static void Run()
    {
        /*
         * Loop this method until the user inputs something to exit to main menue.
         * Create a switch with cases to push or pop items
         * Make sure to look at the stack after pushing and and poping to see how it behaves
         */

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Available Actions:" +
                              "\ne: enter a string that will be reversed" +
                              "\n0 : Exit to main menu");

            string input = Console.ReadLine().ToLower();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter valid input.");
            }
            else
            {
                switch (input)
                {
                    case "e":
                    {
                        string baseString = Util.AskForString("string to stack");

                        // Simulate a how a stack works with Stack Class:
                        Console.WriteLine("With Stack Class: " + Util.ReverseStringWithStackClass(baseString));

                        // Actual stack with recursive method:
                        Console.WriteLine("With real recursion: " + Util.ReverseStringRecursively(baseString));
                    }

                        break;
                    case "0":
                        isRunning = false;
                        break;
                }
            }
        }
    }
}