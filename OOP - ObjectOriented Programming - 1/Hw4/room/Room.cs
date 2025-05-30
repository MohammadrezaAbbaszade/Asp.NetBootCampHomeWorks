using OOP___ObjectOriented_Programming___1.Hw4.exception;
using OOP___ObjectOriented_Programming___1.Hw4.person;

namespace OOP___ObjectOriented_Programming___1.Hw4.room;

public class Room
{
    public int RoomNumber { get; set; }
    public int Capacity { get; set; }

    private List<Patient> _patients = new List<Patient>();

    public void AssignPatient(Patient patient)
    {
        if (_patients.Count < Capacity)
        {
            _patients.Add(patient);
        }
        else
        {
            throw new RoomFullException($"There is not enough capacity for Room {RoomNumber} and Patient {patient.Name}");
        }
    }

    public Patient? IsInRoom(Patient inputPatient)
    {
        foreach (var patient in _patients)
        {
            if (patient.PatientId == inputPatient.PatientId)
            {
                return patient;
            }
        }

        return null;
    }

    public void RemovePatient(Patient inputPatient)
    {
        for (int i = 0; i < _patients.Count; i++)
        {
            if (_patients[i].PatientId == inputPatient.PatientId)
            {
                _patients.RemoveAt(i);
                break;
            }
        }
    }
}