//Beecrowd Problem 1001 - Extremamente Básico
//https://www.beecrowd.com.br/judge/pt/problems/view/1001
using System;
namespace BoxOfCode.Beecrowd
{
    public class Problem1001
    {
        public static void Run()
        {
            int valueA = int.Parse(Console.ReadLine() ?? "0");
            int valueB = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"X = {valueA + valueB}");
        }
    }
}