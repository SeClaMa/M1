using System;

namespace M1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dou= 43.1235;
            int ine = Convert.ToInt32(dou);
            float flot = Convert.ToInt64(dou);
            string sting = Convert.ToString(dou);

            Console.WriteLine("Double: {0} Int: {1} Float: {2} String: {3}",dou,ine,flot,sting);
        }
    }
}
