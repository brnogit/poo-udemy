using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //L é pra indicar explicitamente que é um numero long
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";

            n1++; //extrapola o limite e vai pra 0

            Console.WriteLine(completo);
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.ReadLine();
        }
    }
}
