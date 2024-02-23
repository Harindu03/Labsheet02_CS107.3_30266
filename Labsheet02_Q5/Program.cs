using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet02_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook[] books = new LibraryBook[5];
            books[0] = new LibraryBook("Book 1", "Author 1", true);
            books[1] = new LibraryBook("Book 2", "Author 2", false);
            books[2] = new LibraryBook("Book 3", "Author 3", true);
            books[3] = new LibraryBook("Book 4", "Author 4", false);
            books[4] = new LibraryBook("Book 5", "Author 5", true);

            DisplayLibraryStatus(books);
            Console.WriteLine("\n");

            books[0].BorrowBook();
            Console.WriteLine("\n");

            books[2].ReturnBook();
            Console.WriteLine("\n");

            DisplayLibraryStatus(books);

            Console.ReadLine(); 
        }

        static void DisplayLibraryStatus(LibraryBook[] books)
        {
            foreach (LibraryBook book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {book.Available}");
            }
        }

    }
}
