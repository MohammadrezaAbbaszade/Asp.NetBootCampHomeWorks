namespace OOP___ObjectOriented_Programming___1.Hw2;

public class Professor : Person
{
    public long ProfessorId { get; set; }
    public string Subject { get; set; }

    public string GetDetails()
    {
        return $"ProfessorId: {ProfessorId}, Subject: {Subject}";
    }
}