namespace OOP___ObjectOriented_Programming___1.Hw2;

public class CreateList
{
    public static void Run()
    {
        List<Person> persons = new List<Person>();
        
        for (int i = 1; i <= 10; i++)
        {
            Person student = new Student();
            student.Name = $"Sutdent {i}";
            student.Age = i;

            Person professor = new Professor();
            professor.Name = $"Professor {i}";
            professor.Age = i;
            
            persons.Add(student);
            persons.Add(professor);
            
        }

        foreach (var person in persons)
        {
            Console.WriteLine($"person name: {person.Name}   age: {person.Age}");
        }
        
    }
}