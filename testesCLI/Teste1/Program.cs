using System;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calcula(2, 3);
        }

        private static void Calcula(int v1, int v2)
        {
            var total = 0;
            total = v1 + v2;
            Console.WriteLine(total);



        }
    }
}
