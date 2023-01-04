using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string woord = "Niels Mondelaers";

            Console.WriteLine(woord.LastIndexOf('e', 5));
        }
    }
}