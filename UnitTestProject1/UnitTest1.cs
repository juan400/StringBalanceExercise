using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringBalanceExercise;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [SetUp]
        public void Init_LoadDependencies(){
            // Hear you can do all the mocks dependencies you need and simulate expected results of them if you needed
            // also set context of containers that might you need
        }
        
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
        public void CheckBalance_IsTureWhenCurvedBrackets()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("(a + 1)");
            //Assert
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsTureWhenSquareBrackets()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("[]");
            //Assert
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsTureWhenCurlyBrackets()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("{}");
            //Assert
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsTureWhenCurvedAndCurlyBrackets()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("(a + 1{0})");
            //Assert
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsTureWhenCurvedSquareAndCurlyBrackets()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("([{[{()}]()[]{}}])"));
            //Assert
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsFalseWhenAppearFirstAnEndingCurveBracket()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance(")({}[]"));
            //Assert
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsFalseWhenAppearFirstAnEndingCurlyBracket()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("}[()]"));
            //Assert
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsFalseWhenMissAnEndingBracket()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("([{()}]"));
            //Assert
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void CheckBalance_IsFalseWhenOverlayingBracketTypes()
        {
            //Arrange
            var checkers = new Checkers();

            //Act
            var result = checkers.CheckBalance("()({)}[]"));
            //Assert
            Assert.IsFalse(result);
        }
    }
}
