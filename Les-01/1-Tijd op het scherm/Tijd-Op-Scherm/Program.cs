using System;

namespace Tijd_Op_Scherm
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("The current time is {0}", time);
        }
    }
}
