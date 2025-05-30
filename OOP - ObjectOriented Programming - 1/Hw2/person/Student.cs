namespace OOP___ObjectOriented_Programming___1.Hw2;

public class Student : Person
{
    public long StudentID { get; set; }

    public string Major { get; set; }

    public string GetDetails()
    {
        return $"StudentID: {StudentID}, Major: {Major}";
    }
}