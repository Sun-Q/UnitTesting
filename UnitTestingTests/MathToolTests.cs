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
    }
}