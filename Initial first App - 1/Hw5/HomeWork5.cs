namespace Initial_first_App___1.Hw5;

public class HomeWork5
{
    public static void Run()
    {
        int sentinelValue = 0;
        int sum = 0;
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
                    if (result < 1)
                    {
                        Console.WriteLine("Please enter a valid number  or -1 to quit ");
                    }
                    else
                    {
                        for (int i = 1; i <= result; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sum += i;
                            }
                        }

                        sentinelValue = -1;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number  or -1 to quit ");
            }
        }
        
        
        Console.WriteLine($"Sum result is: {sum}");
    }
}