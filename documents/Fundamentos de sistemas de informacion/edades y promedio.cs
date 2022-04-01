using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edad_y_promedido
{
    class Program
    {
        static void Main(string[] args)
        {
            int ED1, ED2, ED3, ED4, ED5, PROM;
            Console.WriteLine("escriba la edad de la primera persona");
            ED1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la edad de la segunda persona");
            ED2 = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la edad de la tercera persona");
            ED3 = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la edad de la cuarta persona");
            ED4 = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la edad de la quinta persona");
            ED5 = int.Parse(Console.ReadLine());
            PROM = (ED1 + ED2 + ED3 + ED4 + ED5) / 5;
            Console.WriteLine("LA edad promedio es: "+ PROM);
            if (PROM=>18)
            {
                Console.WriteLine("Mayoria de edad");
            }
            else
            {
                Console.WriteLine("Minoria de edad");
            }
        }
    }
}
