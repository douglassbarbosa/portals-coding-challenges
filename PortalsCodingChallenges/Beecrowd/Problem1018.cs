using Microsoft.VisualBasic;
using PortalsCodingChallenges.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalsCodingChallenges.Beecrowd
{
  public static class Problem1018
  {
    public static void Run()
    {
      Console.WriteLine("Enter a value (int): ");
      string? inputConsole = Console.ReadLine();
      
      if (string.IsNullOrEmpty(inputConsole))
      {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        return;
      }

      int value = int.Parse(inputConsole);
      int[] notes = [100, 50, 20, 10, 5, 2, 1];
      Console.WriteLine(value);
      Console.WriteLine("");
      foreach (int note in notes)
      {
        int count = value / note;
        Console.WriteLine($"{count} nota (s) de R$ {note},00");
        value %= note;
      }
    }
  }
}
