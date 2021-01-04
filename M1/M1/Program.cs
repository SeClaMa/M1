using System;
using System.Linq;

namespace M1
{
    class Program
    {
        static void Main(string[] args)
        {

            string nom = " Sergio ", cognom1= " Clavero ", cognom2=" Martinez ";
            string completoNom = nom+cognom1+cognom2;
            int dia=1, mes=4, any=1995;
            int completoAny = Convert.ToInt32(string.Concat(dia,mes,any));
            const int trespas = 1948;
           
            bool esbis = false;
            var bis =  Enumerable.Range(trespas, any - trespas + 1)
                      .Aggregate(0, (a, b) => DateTime.IsLeapYear(b) ? a + 1 : a); ;

            Console.WriteLine("Mi nombre es: {0}",completoNom);

            Console.WriteLine("Naci el: {0}",completoAny);

            Console.WriteLine("Hay {0} años bisiestos",bis);





        }
    }
}
