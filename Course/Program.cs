using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 255;

            n1++; //extrapola o limite e vai pra 0

            Console.WriteLine(n1);
            Console.ReadLine();
        }
    }
}
