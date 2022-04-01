using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_rombo
{
    class Program
    {
        static void Main(string[] args)
        {
            float D1, D2, AT;
            Console.WriteLine("ingrese la diagonal vertical");
            D1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la diagonal horizontal");
            D2 = float.Parse(Console.ReadLine());
            AT = (D1*D2)/2;
            Console.WriteLine("El area del rombo es: "+AT);
            Console.ReadKey();
        }
    }
}
