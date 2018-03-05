using UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class MathToolTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            int num1 = 10;
            int num2 = 23;
            int expected = 33;
            int sum;

            // Act
            sum = MathTool.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, sum);
        }

        #region IsOddTest

        [TestMethod()]
        public void IsOddTestOddNumbers()
        {
            // Arrange
            int num1 = 1;
            int num2 = 11;
            int num3 = 1111;
            bool result1, result2, result3;

            // Act
            result1 = MathTool.IsOdd(num1);
            result2 = MathTool.IsOdd(num2);
            result3 = MathTool.IsOdd(num3);

            // Assert
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
        }

        [TestMethod()]
        public void IsOddTestEvenNumbers()
        {
            // Arrange
            int num1 = 2;
            int num2 = 22;
            int num3 = 222;
            bool result1, result2, result3;

            // Act
            result1 = MathTool.IsOdd(num1);
            result2 = MathTool.IsOdd(num2);
            result3 = MathTool.IsOdd(num3);

            // Assert
            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(false, result3);
        }

        [TestMethod()]
        public void IsOddTestOddNegativeNumbers()
        {
            // Arrange
            int num1 = -99;

            bool result1;

            // Act
            result1 = MathTool.IsOdd(num1);

            // Assert
            Assert.AreEqual(true, result1);
        }

        [TestMethod()]
        public void IsOddTestEvenNegativeNumbers()
        {
            // Arrange
            int num1 = -82;
            bool result1;

            // Act
            result1 = MathTool.IsOdd(num1);

            // Assert
            Assert.AreEqual(false, result1);
        }

        [TestMethod()]
        public void IsOddTestZero()
        {
            // Arrange
            int num1 = 0;
            bool result1;

            // Act
            result1 = MathTool.IsOdd(num1);

            // Assert
            Assert.AreEqual(false, result1);
        }


        #endregion

        [TestMethod()]
        public void IsLargeThanAMillionTestLarger()
        {
            // Arrange
            int num1 = 999999999;
            bool result1;

            // Act
            result1 = MathTool.IsLargeThanAMillion(num1);

            // Assert
            Assert.AreEqual(true, result1);
        }

    }
}