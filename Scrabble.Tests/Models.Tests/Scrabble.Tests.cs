using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class TestScrabble
  {
    [TestMethod]
    public void TestConstructor_CreateInstanceOfWord_Word()
    {
      Score newWord = new Score("word");
      Assert.AreEqual(typeof(Score), newWord.GetType());
    }

    [TestMethod]
    public void GetScore_CheckIfWord_Bool()
    {
      Score newWord = new Score("word");
      Assert.AreEqual(true, newWord.GetScore("word"));
    }
    
    [TestMethod]
    public void AssignValues_AssignValueToLetter_Dictionary()
    {
      Score newWord = new Score("word");
      Dictionary<char, int> alphabet = new Dictionary<char, int> { 
      {'A', 1}, 
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
      CollectionAssert.AreEqual(alphabet, newWord.AssignValues());
    }

    [TestMethod]
    public void WordLength_LengthOfWord_Int()
    {
      Score newWord = new Score("word");
      Assert.AreEqual(4, newWord.WordLength());
    }

    [TestMethod]
    public void ScoreWord_ReturnScoreOfWord_Int()
    {
      Score newWord = new Score("word");
      Dictionary<char, int> scrabble = newWord.AssignValues();
      Assert.AreEqual(8, newWord.ScoreWord(scrabble));
    }
  }
}

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()