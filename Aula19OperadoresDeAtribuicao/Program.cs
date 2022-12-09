using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int valorA = 10;
            //int valorB = valorA++;
            int valorB = ++valorA;
            Console.WriteLine(valorA);
            Console.WriteLine(valorB);

            Console.ReadLine();
        }
    }
}