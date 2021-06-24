using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float PI ;
            Console.WriteLine("El precio del producto");
            PI = float.Parse(Console.ReadLine());
            if (PI=>500) 
            {
                Console.WriteLine("El precio a pagar es : "+ PI+(PI*0.20));
            }
            else
            {
                Console.WriteLine("El pecio a pagares: ");
            }
            Console.ReadKey();
        }
    }
}
