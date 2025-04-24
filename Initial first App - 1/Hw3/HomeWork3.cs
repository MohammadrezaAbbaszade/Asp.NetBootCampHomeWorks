namespace Initial_first_App___1.Hw3;

public class HomeWork3
{
    public static void Run()
    {
        const int guessNumber = 5;
        Console.WriteLine("Please enter a number between (1-10):");
        bool isGuessTrue = false;
        while (!isGuessTrue)
        {
            string userGuess = Console.ReadLine();
            
            if (int.TryParse(userGuess, out int result))
            {
                if (result == guessNumber)
                {
                    Console.WriteLine("Great!.Your guess is correct.");
                    isGuessTrue = true;
                }
                else if (result < 1 || result > 10)
                {
                    Console.WriteLine("Your guess is outOfRange!. Try again:");
                }
                else
                {
                    Console.WriteLine("Your guess is incorrect!. Try again:");
                }
            }
            else
            {
                Console.WriteLine("Error");
                break;
            }
        }

        Console.WriteLine("End of Program");
    }
}