using System;

namespace Stopwatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);

            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);

        }
    }
}