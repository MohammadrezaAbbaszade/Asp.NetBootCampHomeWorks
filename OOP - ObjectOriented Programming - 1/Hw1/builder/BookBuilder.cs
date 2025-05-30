namespace OOP___ObjectOriented_Programming___1.Hw1.builder;

//Implement Builder pattern
public class BookBuilder: IBookBuilder
{
    private Book book = new Book();

    public IBookBuilder setTitle(string title)
    {
        this.book.Title = title;
        return this;
    }

    public IBookBuilder setAuthor(string author)
    {
        this.book.Author = author;
        return this;
    }


    public IBookBuilder setISBN(string isbn)
    {
        this.book.ISBN = isbn;
        return this;
    }

    public Book Build()
    {
        return this.book;
    }
}


