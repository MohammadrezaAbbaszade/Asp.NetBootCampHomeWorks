namespace OOP___ObjectOriented_Programming___1.Hw4.person;

public class Patient : Person
{
    public long PatientId { get; set; }
    public List<string> MedicalHistory { get; private set; }
    
    

    public void AddToMedicalHistory(string medicalHistory)
    {
        MedicalHistory.Add(medicalHistory);
    }

    public override Person createPerson(Person person)
    {
        this.NationalId = person.NationalId;
        this.Name = person.Name;
        this.Age = person.Age;
        this.PatientId = ((Patient)person).PatientId;
        return this;
    }
}