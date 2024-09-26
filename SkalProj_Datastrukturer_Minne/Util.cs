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

    public static string ConvertCollectionToString<T>(IEnumerable<T> collection)
    {
        string result = "";
        foreach (T item in collection)
        {
            result += item + " "; // Append each element to the result string
        }

        return result.Trim(); // Return the final concatenated string
    }

    public static string ReverseStringWithStackClass(string baseString)
    {
        Stack<char> theStack = new Stack<char>();

        char[] charArray = baseString.ToCharArray();
        foreach (Char c in charArray)
        {
            theStack.Push(c);
        }

        string reversedString = "";

        while (theStack.Count > 0)
        {
            reversedString += theStack.Pop();
        }

        return reversedString;
    }

    public static string ReverseStringRecursively(string input)
    {
        // Kommer köras sålänge det finns mer än en bokstav i input.
        while (input.Length > 1)
        {
            // Plockar ut första bokstaven ur ordet
            char firstChar = input[0];

            // Plockar ut alla bokstäver efter första bokstaven
            string stringWithoutFirstChar = input.Substring(1);

            // Returnerar ett metodkall som måste utvärderas innan metoden kan returnera,
            // samt första bokstaven. Så det byggs en trave med stacks av samma metod,
            // där ett metodkall först måste utvärderas innan den kan returnera.
            // Slutligen så nås ett utfall där endast en bokstav finns kvar. Då avslutas
            // rekursionen och varje metodkall från tidigare metod kan slutligen utvärderas.
            // På så sätt uppnås sist in, först ut - principen. Där den översta stacken som
            // endast har en bokstav kvar kommer att returneras först då den är högst på stacken
            // sedan så returneras den näst sästa bokstaven osv... tills den når det allra första metodkallet
            // och vi kan slutligen returnera en omvänd string input till en kallande metod.
            return ReverseStringRecursively(stringWithoutFirstChar) + firstChar;
        }

        return input;
    }
}