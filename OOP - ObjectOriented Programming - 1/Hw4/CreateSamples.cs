using OOP___ObjectOriented_Programming___1.Hw4.person;
using OOP___ObjectOriented_Programming___1.Hw4.room;

namespace OOP___ObjectOriented_Programming___1.Hw4;


public class CreateSamples
{
    public static void Run()
    {
        //create hostpital
        Hospital hospital = Hospital.getInstance();
        
        
        //create patients 
        List<Person> persons = new List<Person>();
        for (int i = 1; i <= 10; i++)
        {
            Person patient = new Patient();
            patient.Name = $"Name {i}";
            patient.Age = i;
            patient.NationalId = new Random().NextInt64();

            Person doctor = new Doctor();
            doctor.Name = $"Doctor {i}";
            doctor.Age = i;
            doctor.NationalId = new Random().NextInt64();

            persons.Add(patient.createPerson(patient));
            persons.Add(doctor.createPerson(doctor));
        }
        
        
        
        //create rooms
        List<Room> rooms = new List<Room>();
        for (int i = 1; i <= 10; i++)
        {
            Room room = new Room();
            room.RoomNumber = i;
            room.Capacity = i;
            rooms.Add(room);
            if (persons[i] is Patient)
            {
                room.AssignPatient((Patient)persons[i]); 
            }
        
        }
        hospital.Rooms = rooms;
        
        
        //test assingPatient in hospital
        Patient patient2 = new Patient();
        patient2.Name = $"Patient 2000";
        patient2.Age = 2000;
        patient2.NationalId = new Random().NextInt64();
        hospital.AdmitPatient(patient2);
        
        
    }
}