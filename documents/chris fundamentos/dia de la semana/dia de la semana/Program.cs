using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("escribe un numero que corresponda a un dia");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {

                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Error, no es un dia");break;
            }
            Console.ReadKey();

        }
    }
}
