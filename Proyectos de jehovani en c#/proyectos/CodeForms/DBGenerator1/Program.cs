using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataModel;

namespace DBGenerator1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new dbmodel())
            {
                Console.WriteLine("PRESIONE ENTER PARA CREAR LA BD....");
                Console.ReadKey();


                try
                {
                    db.Database.CreateIfNotExists();
                }




                catch (Exception e)
                {

                    Console.WriteLine(e.ToString());
                    Console.WriteLine("esta mierda no sirve");
                }
                finally
                {
                    Console.WriteLine("proceso finalizado....");
                    Console.WriteLine("Sos un puto crack");
                }
                Console.ReadKey();
            }
        }
    }
}
