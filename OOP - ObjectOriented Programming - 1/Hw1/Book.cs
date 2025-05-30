namespace OOP___ObjectOriented_Programming___1.Hw1;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsAvailable { get; set; }


    public Book(string title = "empty title", string author = "empty title", string isbn = "empty isbn",
        bool isAvailable = false)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
        this.IsAvailable = isAvailable;
    }

}