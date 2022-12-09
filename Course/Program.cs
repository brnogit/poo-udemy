using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //L é pra indicar explicitamente que é um numero long

            n1++; //extrapola o limite e vai pra 0

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.ReadLine();
        }
    }
}
