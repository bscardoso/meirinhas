using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Wait...");
            WaitAndClear();

            Console.WriteLine("Let me know you a bit better...");
            WaitAndClear();

            Console.WriteLine("What is your name? (write your name and press <enter>)");
            string name = Console.ReadLine();
            WaitAndClear(0);

            Console.WriteLine($"Hello {name}. Nice to meet you!");
            WaitAndClear();

            Console.WriteLine("Bye...");
            WaitAndClear();
        }

        /// <summary>
        /// The console waits during the provided number of milliseconds or 2000 by default and clears it.
        /// </summary>
        /// <param name="milliseconds">Number of milliseconds the console will wait before it clears</param>
        private static void WaitAndClear(int milliseconds = 2000)
        {
            Thread.Sleep(milliseconds);
            Console.Clear();
        }
    }
}
