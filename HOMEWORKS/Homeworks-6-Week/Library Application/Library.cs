using System;
using System.Reflection;

namespace Library_Application;

public class Library : Book
{
    public Library(string title, string author, int pages, int isbn, int capacity) : base(title, author, pages, isbn)
    {
        books = new Book[capacity];
        currentBookCount = 0;
    }

    Book[] books;
    int currentBookCount;

    public void AddBook(Book book)
    {
        if (currentBookCount < books.Length)
        {
            books[currentBookCount] = book;
            currentBookCount++;
            System.Console.WriteLine($"{book.Title} kitabı kütüphaneye eklendi.");
        }
        else
        {
            System.Console.WriteLine("Kütüphane dolu.");
        }
    }

    public void HaveBook()
    {
        if (currentBookCount>0)
        {
            System.Console.WriteLine("Kütüphanedeki kitaplar:");
            for (int i = 0; i < books.Length; i++)
            {
                books[i].BooksInformation();
            }
        }else
        {
            System.Console.WriteLine("kütüphanede kitap yok.");
        }
    }




}
