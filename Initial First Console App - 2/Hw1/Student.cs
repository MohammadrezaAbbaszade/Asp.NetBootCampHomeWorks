namespace Initial_First_Console_App___2.Hw1;

public class Student
{

    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }

    public void Introduce()
    {
        Console.WriteLine($"Hello My name is {name} and I am {age} years old.");
    }


    public static void Run()
    {
        Student student = new Student("Mohammadreza", 24);
        student.Introduce();
    }
}


