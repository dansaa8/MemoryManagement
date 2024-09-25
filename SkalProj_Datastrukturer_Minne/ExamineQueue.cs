namespace SkalProj_Datastrukturer_Minne;

public static class ExamineQueue
{
    public static void Run()
    {
        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch with cases to enqueue items or dequeue items
         * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
         */

        bool isRunning = true;

        Queue<string> theQueue = new Queue<string>();

        while (isRunning)
        {
            Console.WriteLine("Available Actions:" +
                              "\ne : Enqueue a string" +
                              "\nd : Dequeue the first string" +
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
                        string queueString = Util.AskForString("string to queue");
                        Console.WriteLine($"The queue before Enqueue: {Util.ConvertQueueToString(theQueue)}");

                        theQueue.Enqueue(queueString);
                        Console.WriteLine($"The queue after Enqueue: {Util.ConvertQueueToString(theQueue)}");
                    }
                        break;
                    case "d":
                    {
                        if (theQueue.Count > 0)
                        {
                            Console.WriteLine($"The queue before Dequeue: {Util.ConvertQueueToString(theQueue)}");

                            theQueue.Dequeue();
                            Console.WriteLine($"The queue after Dequeue: {Util.ConvertQueueToString(theQueue)}");
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty. Nothing to dequeue");
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