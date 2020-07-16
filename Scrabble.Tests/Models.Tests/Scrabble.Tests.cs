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
  }
}