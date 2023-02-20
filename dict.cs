using System.Collections.Generic;
using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var streets = new Dictionary<string, string>();

            streets.Add("Tihase", "");
            streets.Add("Tedre", "Tedre");
            streets.Add("Linnu Tee", "Linnu Tee");
            streets.Add("Siili", "");

            foreach (var street in streets)
            {
                Console.WriteLine($"{street.Key}");
            }
            Console.WriteLine("--------------");
            Console.WriteLine(streets["Tedre"]);
            Console.WriteLine(streets["Linnu Tee"]);
            Console.WriteLine("--------------");
            

            

            
            
            
            
        }
    }
}