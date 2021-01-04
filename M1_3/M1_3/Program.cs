using System;

namespace M1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arra = {1,2,3,4,5,6,7,8,9,10 };

            

            Console.WriteLine("Antes de Invertirla: ");
            for (int i = 0; i < arra.Length; i++)
            {
                Console.WriteLine(arra[i]);
            }

            Array.Reverse(arra);

            Console.WriteLine("Despues de Invertirla: ");
            for (int i = 0; i < arra.Length; i++)
            {
                Console.WriteLine(arra[i]);
            }

        }
    }
}
