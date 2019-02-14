using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class LettersTests
  {
    [TestMethod]
    public void checkIfAlphabet_False(){
      Letters test = new Letters();
      Assert.AreEqual(true,test.isAlphabet("apple4"));
    }
    [TestMethod]
    public void checkIfAlphabet_True(){
      Letters test = new Letters();
      Assert.AreEqual(true,test.isAlphabet("apple"));
    }
    [TestMethod]
    public void appleScore(){
      Letters test = new Letters();
      Assert.AreEqual(9,test.calculateScore("apple"));
    }
    [TestMethod]
    public void singlePoints(){
      Letters test = new Letters();
      Assert.AreEqual(10,test.calculateScore("aeioulnrst"));
    }
    [TestMethod]
    public void twoPoints(){
      Letters test = new Letters();
      Assert.AreEqual(4,test.calculateScore("dg"));
    }
    [TestMethod]
    public void threePoints(){
      Letters test = new Letters();
      Assert.AreEqual(12,test.calculateScore("bcmp"));
    }
    [TestMethod]
    public void fourPoints(){
      Letters test = new Letters();
      Assert.AreEqual(20,test.calculateScore("hfvwy"));
    }
    [TestMethod]
    public void fivePoints(){
      Letters test = new Letters();
      Assert.AreEqual(5,test.calculateScore("k"));
    }
    [TestMethod]
    public void eightPoints(){
      Letters test = new Letters();
      Assert.AreEqual(16,test.calculateScore("jx"));
    }
    [TestMethod]
    public void tenPoints(){
      Letters test = new Letters();
      Assert.AreEqual(20,test.calculateScore("qz"));
    }
    [TestMethod]
    public void allPoints(){
      Letters test = new Letters();
      Assert.AreEqual(87,test.calculateScore("abcdefghijklmnopqrstuvwxyz"));
    }
  }
}
