namespace SkalProj_Datastrukturer_Minne;

public static class ExamineList
{
    internal static void Run()
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
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Available Actions:" +
                              "\n+<Value> : Add the value to the list" +
                              "\n-<Value> : Remove the value from the list" +
                              "\n0 : Exit to main menu");

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

                    case '0':
                        isRunning = false; // Exit the loop
                        Console.WriteLine("Exiting to main menu.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}