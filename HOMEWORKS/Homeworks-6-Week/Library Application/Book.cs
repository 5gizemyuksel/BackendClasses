using System;

namespace Library_Application;

public class Book
{
    public Book(string title, string author, int pages, int isbn)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBN = isbn;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int ISBN { get; set; }

    public virtual void Borrow()
    {
        System.Console.WriteLine($"{Title} kitabı ödünç alındı.");
    }

    public virtual void Return()
    {
        System.Console.WriteLine($"{Title} kitabı iade edildi.");
    }

    public virtual void BooksInformation()
    {
        System.Console.WriteLine($"{Title},{Author},{Pages},{ISBN}");
    }



}
