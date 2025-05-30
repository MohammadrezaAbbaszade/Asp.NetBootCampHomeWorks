namespace OOP___ObjectOriented_Programming___1.Hw1;

public interface IBookBuilder
{
    IBookBuilder setTitle(string title);
    IBookBuilder setAuthor(string author);
   
    IBookBuilder setISBN(string isbn);
    Book Build();
    
    
}