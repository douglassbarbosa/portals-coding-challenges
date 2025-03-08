using PortalsCodingChallenges.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalsCodingChallenges.HackerRank
{
    class SolveMeFirt : IProblem
    {
      public void Run()
      {
      //Console.WriteLine("Enter two numbers to add");
      //int val1 = Convert.ToInt32(Console.ReadLine());
      //int val2 = Convert.ToInt32(Console.ReadLine());
      //int sum = SolveMeFirst(val1, val2);
      //Console.WriteLine("The sum of the two numbers is: " + sum);
      Console.WriteLine("Enter tow numbers to add");
      int valueA = Convert.ToInt32(Console.ReadLine());
      int valueB = Convert.ToInt32(Console.ReadLine());
      int sum = SolveMeFirst(valueA, valueB);
      Console.WriteLine($"The SUM of {valueA} and {valueB} is: {sum}");
      }
      public static int SolveMeFirst(int a, int b)
      {
        return a + b;
      }
    }
}
