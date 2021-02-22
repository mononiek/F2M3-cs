using System;
using System.Threading;

namespace Les_01_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string text = "Hello World";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(70);
            }
        }
    }
}
