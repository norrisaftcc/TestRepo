using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp_norrisa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Thanks, press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
