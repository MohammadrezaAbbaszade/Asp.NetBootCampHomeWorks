namespace OOP___ObjectOriented_Programming___1.Hw4.person;

public  abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public long NationalId { get; set; }
    
    //this is abstract factory method to impolement factoryPattern
    public abstract Person createPerson(Person person);
}