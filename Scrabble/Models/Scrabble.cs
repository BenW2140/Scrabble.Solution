using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Score
  {
    public string Word {get; set;}

    public Score(string word)
    {
      Word = word;
    }
    public bool GetScore(string word)
    {
      return true;
    }

    public int WordLength()
    {
      int wordLength = Word.Length;
      return wordLength;
    }
    public Dictionary<char, int> AssignValues()
    {
      Dictionary<char, int> scrabble = new Dictionary<char, int> 
      {{'A', 1}, 
      {'E', 1}, 
      {'I', 1}, 
      {'O', 1}, 
      {'U', 1}, 
      {'L', 1}, 
      {'N', 1}, 
      {'R', 1}, 
      {'S', 1}, 
      {'T', 1}, 
      {'D', 2}, 
      {'G', 2}, 
      {'B', 3}, 
      {'C', 3}, 
      {'M', 3}, 
      {'P', 3}, 
      {'F', 4},
      {'H', 4},
      {'V', 4},
      {'W', 4},
      {'Y', 4},
      {'K', 5},
      {'J', 8},
      {'X', 8},
      {'Q', 10},
      {'Z', 10}};
      return scrabble;
    }

    public int ScoreWord(Dictionary<char, int> scrabble)
    {
      int score = 0;
      Word = Word.ToUpper();
      Word.Split();
      // foreach (char letter in Word.Chars)
      for (int i = 0; i < Word.Length; i++)
      {
        score += scrabble[Word[i]];
      }
      return score;
    }
  }
}