//Beecrowd Poblem 1003 - Simple Sum


using System;
using System.Globalization;

namespace BoxOfCode.Beecrowd
{
    public class Problem1003
    {
        public static void Run()
        {
            int valueA = int.Parse(Console.ReadLine() ?? "0");
            int valueB = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("SOMA = " + (valueA + valueB));
        }
    }
}