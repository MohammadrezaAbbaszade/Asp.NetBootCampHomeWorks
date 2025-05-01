namespace Initial_First_Console_App___2.Hw3;

public class Statistics
{
    public static void Run()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        string thirdNumber = Console.ReadLine();
        int[] inputs = { int.Parse(firstNumber), int.Parse(secondNumber), int.Parse(thirdNumber) };
        Console.WriteLine($"Initial values: {firstNumber}_{secondNumber}_{thirdNumber}");
        Statistics statistics = new Statistics();
        statistics.analyzeNumbers(inputs[0], ref inputs[1], out inputs[2]);
        Console.WriteLine($"Initial values After Modifying: {inputs[0]}_{inputs[1]}_{inputs[2]}");
    }

    public void analyzeNumbers(int firstNumber, ref int secondNumber, out int thirdNumber)
    {
        thirdNumber = firstNumber + secondNumber;
        secondNumber = secondNumber * secondNumber;
        Console.WriteLine($"First Input is: {firstNumber}");
    }
}