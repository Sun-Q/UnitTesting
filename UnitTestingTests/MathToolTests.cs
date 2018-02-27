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
    }
}