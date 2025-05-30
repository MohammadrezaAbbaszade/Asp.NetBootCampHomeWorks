namespace OOP___ObjectOriented_Programming___1.Hw2;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string GetDetails()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}