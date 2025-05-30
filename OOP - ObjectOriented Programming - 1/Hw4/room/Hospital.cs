using OOP___ObjectOriented_Programming___1.Hw4.person;

namespace OOP___ObjectOriented_Programming___1.Hw4.room;

public class Hospital
{
    public List<Room> Rooms { get; set; }
    public List<Doctor> Doctors { get; set; }

    private static Hospital hospital = null;

    //implement singleton pattern to have single instanse of hospital
    public static Hospital getInstance()
    {
        if (hospital == null)
        {
            return hospital = new Hospital();
        }

        return hospital;
    }

    private Hospital()
    {
        
    }
    public void AdmitPatient(Patient patient)
    {
        
        int counterForReception = 0;
        foreach (var room in Rooms)
        {
            try
            {
                room.AssignPatient(patient);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                counterForReception++;
            }
        }

        if (counterForReception == Rooms.Count)
        {
            Console.WriteLine("Sorry, there are no empty room for reception");
        } 
    }

    public void DischargePatient(Patient patient)
    {
        foreach (var room in Rooms)
        {
            if (room.IsInRoom(patient)!= null)
            {
                room.RemovePatient(patient);
            }
        }
        
    }
}