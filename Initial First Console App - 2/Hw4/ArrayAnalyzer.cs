namespace Initial_First_Console_App___2.Hw4;

public class ArrayAnalyzer
{
    public static void Run()
    {
        Console.WriteLine("Please enter the size of Array:");
        string arraySize = Console.ReadLine();
        if (int.TryParse(arraySize, out int result))
        {
            int[] inputs = new int[result];
            Console.WriteLine("Input your values for array:");
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Next");
            }

            int max = 0;
            double average = 0.0;
            ArrayAnalyzer analyzer = new ArrayAnalyzer();
            analyzer.arrayAnalyzer(inputs, ref max, out average);
            Console.WriteLine($"Max: {max}, Average: {average}");
        }
        else
        {
            Console.WriteLine("Your input is not valid!");
        }
    }
    public void arrayAnalyzer(int[] numbers, ref int max, out double average)
    {
        double counter = 0;
        if (numbers.Length == 0)
        {
            max = 0;
            average = 0.0;
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                counter += numbers[i];
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
        }

        average = counter / numbers.Length;
    }
}