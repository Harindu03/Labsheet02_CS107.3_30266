using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet02_Q4
{
    internal class product
    {
       public string ProductName;
       public int Price;

        public product(string ProductName, int price)
        {
            this.ProductName = ProductName;
            this.Price = price;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product("iphone 14 pro",370000);
            Console.WriteLine("product name " +product1.ProductName);
            Console.WriteLine("product price " + product1.Price);
        }
    }
}
