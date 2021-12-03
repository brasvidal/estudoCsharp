using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Start();
        }

        static void Start()
        {
            var time = 10;
            int currentTime = 0;
            while (currentTime != time)
            {
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

        }
    }
}
