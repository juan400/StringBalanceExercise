using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringBalanceExercise;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Verify that the string has correctly balanced parentheses, straight braces and braces.

        // Input: (a + 1) Return: true
        // Input: (a + 1{0}) Return: true
        // Input: (a + 1{0)} Return: false
        // Input: a + 1{0} Return: true
        // Input:([{[{()}]()[]{}}]) Return: true
        // Input:)({}[] Return: Flase
        // Input:{} Return: True
        // Input:}[()] Return: Flase
        // Input:([{()}] Return: Flase
        // Input:()({)}[] Return: Flase
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var checkers = new Checkers();

            //Act

            //Assert
            Assert.IsTrue(checkers.CheckBalance("(a + 1)"));
            Assert.IsTrue(checkers.CheckBalance("(a + 1{0})"));
            Assert.IsFalse(checkers.CheckBalance("(a + 1{0)}"));
            Assert.IsTrue(checkers.CheckBalance("([{[{()}]()[]{}}])"));
            Assert.IsFalse(checkers.CheckBalance(")({}[]"));
            Assert.IsTrue(checkers.CheckBalance("{}"));
            Assert.IsFalse(checkers.CheckBalance("}[()]"));
            Assert.IsFalse(checkers.CheckBalance("([{()}]"));
            Assert.IsFalse(checkers.CheckBalance("()({)}[]"));
        }
    }
}
