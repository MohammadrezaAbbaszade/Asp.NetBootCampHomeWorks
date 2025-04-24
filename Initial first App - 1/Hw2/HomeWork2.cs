namespace Initial_first_App___1.Hw2;

public class HomeWork2
{
    public static void Run()
    {
        Console.WriteLine("Please enter your Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your Age:");
        string age = Console.ReadLine();
        if (int.TryParse(age, out int result))
        {
            Console.WriteLine($"Hello {name},You are {result} years old.");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}