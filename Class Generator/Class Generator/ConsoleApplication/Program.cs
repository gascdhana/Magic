using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert 1 million records");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();




            stopwatch.Stop();
            Console.WriteLine($"Elapsed time {stopwatch.Elapsed.Milliseconds} ");
            Console.ReadKey();
        }

    }
}
