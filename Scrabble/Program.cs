using System;
using Scrabble.Models;

namespace something
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please Enter a word: ");
      string userInput = Console.ReadLine();
      Score word = new Score(userInput);
      int result = word.ScoreWord(word.AssignValues());
      Console.WriteLine("Your word, " + userInput + ", is worth " + result + " points!");
    }
  }
}