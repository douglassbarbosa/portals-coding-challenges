//Beecrowd Problem 1002 - Área do Círculo
//https://www.beecrowd.com.br/judge/pt/problems/view/1002
//The formula to calculate the area of a circumference is defined as A = π x R^2. 
//Considering to this problem that π = 3.14159:

using System;
namespace BoxOfCode.Beecrowd
{    public class Problem1002
    {
        public static void Run() 
        {
            double pi = 3.14159;
            double radius = double.Parse(Console.ReadLine() ?? "0");
            double area = pi * Math.Pow(radius, 2);
            Console.WriteLine($"A={area:F4}");
        }
    }
} 