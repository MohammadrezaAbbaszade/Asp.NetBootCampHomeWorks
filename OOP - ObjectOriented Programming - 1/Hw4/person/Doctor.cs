namespace OOP___ObjectOriented_Programming___1.Hw4.person;

public class Doctor : Person
{
    public long DoctorId { get; set; }
    public string Specialization { get; set; }

    private Sickness _sickness = new Sickness();

    public string Diagnose(Patient patient)
    {
        foreach (var medical in patient.MedicalHistory)
        {
            if (medical == Sickness.COLD.ToString())
            {
                Console.WriteLine("You get Cold");
                return _sickness.ToString();
            }
            else if (medical == Sickness.HEARTACHE.ToString())
            {
                Console.WriteLine("You get Heartache");
                return _sickness.ToString();
            }
            else if (medical == Sickness.NAUSEA.ToString())
            {
                Console.WriteLine("You get Nausea");
                return _sickness.ToString();
            }
        }

        return "You don't have any medical";
    }


    public override Person createPerson(Person person)
    {
        this.NationalId = person.NationalId;
        this.Name = person.Name;
        this.Age = person.Age;
        this.DoctorId = ((Doctor)person).DoctorId;
        return this;
    }
}