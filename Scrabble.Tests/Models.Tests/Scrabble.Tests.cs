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
      Score newWord = new Score();
      Assert.AreEqual(typeof(Score), newWord.GetType());
    }

    [TestMethod]
    public void GetScore_CheckIfWord_Bool()
    {
      Score newWord = new Score();
      Assert.AreEqual(true, newWord.GetScore("word"));
    }
    
    [TestMethod]
    public void AssignValues_AssignValueToLetter_Dictionary()
    {
      Score newWord = new Score();
      Dictionary<char, int> alphabet = new Dictionary<char, int> { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}};
      CollectionAssert.AreEqual(alphabet, newWord.AssignValues());
    }
  }
}

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()