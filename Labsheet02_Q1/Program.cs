using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet02_Q1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            book MyBook = new book("Think like a monk ", "Jay Shetty");
            Console.WriteLine(MyBook.title);
            Console.WriteLine(MyBook.author);
          

        }
    }
}
