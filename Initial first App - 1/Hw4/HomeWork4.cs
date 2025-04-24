namespace Initial_first_App___1.Hw4;

public class HomeWork4
{
    public static void Run()
    {
        const string guessString = "cSharp";
        Console.WriteLine("Please guess the word or -1 to quit :");
        int sentinelValue = 0;
        int guessCounter = 0;
        while (sentinelValue != -1)
        {
            string userGuess = Console.ReadLine();

            if (int.TryParse(userGuess, out int result))
            {
                if (result == -1)
                {
                    sentinelValue = -1;
                }
                else
                {
                    Console.WriteLine("Please enter a string to guess or -1 to quit ");
                }
            }
            else
            {
                guessCounter++;
                if (userGuess == guessString)
                {
                    Console.WriteLine("Great!.Your guess is correct.");
                    sentinelValue = -1;
                }
                else
                {
                    Console.WriteLine("Your guess is incorrect!. Try again:");
                }
            }
        }

        Console.WriteLine($"Your Retry Count is:{guessCounter}");
        Console.WriteLine("End of Program");
    }
}