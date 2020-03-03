using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class ItemTests
  {
      [TestMethod]
      public void TakeWord_CheckStringforAnagram_String()
      {
          string testOutput = "beard";
          AnagramSwitcher anagrams = new AnagramSwitcher();
          Assert.AreEqual("yes", anagrams.IsAnagram(testOutput));
      }
  }
}