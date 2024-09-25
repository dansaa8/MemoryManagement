namespace SkalProj_Datastrukturer_Minne;

public static class Util
{
    public static string AskForString(string prompt)
    {
        Console.Write($"{prompt}: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.WriteLine($"Please enter a valid {prompt}");
        }
    }

    public static string ConvertQueueToString(Queue<string> queue)
    {
        string result = "";
        foreach (string s in queue)
        {
            result += s + " "; // Append each element to the result string
        }

        return result.Trim(); // Return the final concatenated string
    }
}