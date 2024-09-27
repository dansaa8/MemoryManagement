namespace SkalProj_Datastrukturer_Minne;

/// <summary>
/// Examines a string to see if it's well formated 
/// </summary>
public static class CheckParenthesis
{
    public static void Run()
    {
        /*
         * Use this method to check if the paranthesis in a string is Correct or incorrect.
         * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
         * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
         */

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Available Actions:" +
                              "\ne: enter a string that will be format checked" +
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
                        string baseString = Util.AskForString("string to be checked");
                        bool isOkFormat = Util.IsWellFormated(baseString);
                        
                        if (isOkFormat) Console.WriteLine("The string is well formated");
                        else Console.WriteLine("The string is NOT well formated");
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