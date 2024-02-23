using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet02_Q5
{
    internal class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }


        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine("You borrowed" + Title);
            }
            else
            {
                Console.WriteLine("Book already borrowed");
            }
            
        }
        public void ReturnBook()
        {
            if (!Available)
            {
                Available = true;
                Console.WriteLine("you returned " + Title);
            }
            else
            { Console.WriteLine("Book already returned"); }
        }

    }
}
