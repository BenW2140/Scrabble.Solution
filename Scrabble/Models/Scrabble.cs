using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Score
  {
    public bool GetScore(string word)
    {
      return true;
    }

    public Dictionary<char, int> AssignValues()
    {
      Dictionary<char, int> scrabble = new Dictionary<char, int> { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}};
      return scrabble;
    }
  }
}