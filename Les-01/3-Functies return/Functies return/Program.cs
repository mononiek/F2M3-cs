using System;

namespace Functies_return
{
    class Program
    {
        
        public static string strfunction()
        {
            string strmessage = "Monique Wienholds";
            return strmessage;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mijn naam is " + strfunction());
            Console.Read();
        }
    }
}
