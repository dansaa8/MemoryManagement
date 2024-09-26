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

        Stack<string> theStack = new Stack<string>();

        while (isRunning)
        {
            Console.WriteLine("Available Actions:" +
                              "\npush: Insert a string at the top of the Stack." +
                              "\npop: Remove and return the string at the top of the Stack." +
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
                    case "push":
                    {
                        string stackString = Util.AskForString("string to stack");
                        Console.WriteLine($"The stack before push: {Util.ConvertCollectionToString(theStack)}");

                        theStack.Push(stackString);
                        Console.WriteLine($"The stack after push: {Util.ConvertCollectionToString(theStack)}");
                    }
                        break;
                    case "pop":
                    {
                        if (theStack.Count > 0)
                        {
                            Console.WriteLine($"The stack before pop: {Util.ConvertCollectionToString(theStack)}");

                            theStack.Pop();
                            Console.WriteLine($"The stack after pop: {Util.ConvertCollectionToString(theStack)}");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty. Nothing to pop");
                        }
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