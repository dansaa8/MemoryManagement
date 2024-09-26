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

    public static bool CheckParenthesis(string baseString)
    {
        Stack<char> stack = new();

        // Loopa över varje bokstav i inskickade strängen
        foreach (char c in baseString)
        {
            // Om bokstaven innehåller en öppnande parentes, pushar vi in den överst i stacken
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            // Om vi får en stängande parentes, så kommer det här else if statement att exekvera 
            else if (c == ')' || c == '}' || c == ']')
            {
                // Vi kollar om det för närvarande finns några element i stacken.
                // Om det inte gör det så betyder det att vi har en stängande
                // parentes som inte har en startande motsvarighet.
                if (stack.Count == 0) return false;

                // Vi plockar ut den senast tillagda öppnande parentesen ur stacken.
                char top = stack.Pop();

                // Om den senast tillagda öppnande parentesen i stacken inte motsvarar
                // den stängande parentesen, så betyder det att det finns
                // en öppnande parentes av en annan typ som inte är stängd.
                // Är så fallet, så är strängen som vi evaluerar inte "välformad"
                // och vi returnerar false från metoden.
                if (c == ')' && top != '(') return false;
                if (c == '}' && top != '{') return false;
                if (c == ']' && top != '[') return false;
            }
        }

        // Om stacken är tom så betyder det att alla öppnande parenteser har stängts
        // Finns det öppnande parenteser kvar, så betyder det att inte alla har stängts.
        // Nedanstående return uttryck nedanför kommer att resultera i ett bool-värde.
        // Om det uttrycket stämmer så returnerar metoden true, annars false.
        return stack.Count == 0;
    }

    public static int RecursiveOdd(int n)
    {
        if (n == 1) return 1;
        return (RecursiveOdd(n - 1) + 2);
    }
}