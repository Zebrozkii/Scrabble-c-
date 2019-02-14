using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      string userInput = Console.ReadLine();
      Letters userTest = new Letters();
      Console.WriteLine(userTest.calculateScore(userInput));
    }
  }
}
