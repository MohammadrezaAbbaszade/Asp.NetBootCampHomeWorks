using OOP___ObjectOriented_Programming___1.Hw1.builder;

namespace OOP___ObjectOriented_Programming___1.Hw1;

public class Library
{
    public List<Book> Books { get; private set; }


    public Library(List<Book> books)
    {
        Books = books;
    }

    public Library()
    {
    }


    public void AddBook(Book book)
    {
        if (Books == null)
        {
            Books = new List<Book>();
        }

        Books.Add(book);
    }

    public void BorrowBook(Book book)
    {
        bool isAvailable = false;
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].Title == book.Title)
            {
                isAvailable = true;
                break;
            }
        }

        if (!isAvailable)
        {
            Console.WriteLine($"The {book.Title}  is not available");
        }
        else
        {
            Console.WriteLine(
                $"The {book.Title} is  available \n info= Title={book.Title},Author={book.Author},ISBM:{book.ISBN}");
        }
    }

    public Book? ReturnBook(string title)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].Title == title)
            {
                Book bookToReturn = Books[i];
                Books.RemoveAt(i);
                return bookToReturn;
            }
        }

        return null;
    }

    public static void Run()
    {
        Library library = new Library();
        for (int i = 1; i <= 10; i++)
        {
            //using builder pattern
            Book book = new BookBuilder()
                .setTitle($"Book {i}")
                .setAuthor($"Author {i}").Build();
            library.AddBook(book);
        }


        //Test Availability in list
        Book? book1 = library.ReturnBook(title: "Book 1");
        if (book1 == null)
        {
            Console.WriteLine("Book 1 is not Available");
        }
        else
        {
            Console.WriteLine($"Book 1 is Available. title={book1.Title}");
        }

        //Test unavailablity in list
        Book? book20 = library.ReturnBook(title: "Book 20");
        if (book20 == null)
        {
            Console.WriteLine("Book 1 is not Available");
        }
        else
        {
            Console.WriteLine($"Book 1 is Available. title={book1.Title}");
        }

        //Test Borrow a book that available
        library.BorrowBook(new Book(title: "Book 2"));

        //Test Borrow a book that NotAvailable after getReturn in previous step
        library.BorrowBook(new Book(title: "Book 1"));
    }
}