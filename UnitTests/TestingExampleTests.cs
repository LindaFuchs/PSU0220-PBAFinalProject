using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingExample;

namespace UnitTests
{
    [TestClass]
    public class TestingExampleTests
    {
        public TestingExampleClass TestExample1;
        float x;
        float y;
        float expected;
        float result;

        [TestInitialize]
        public void InitializeTest()
        {
            TestExample1 = new TestingExampleClass();
            x = 6;
            y = 2;
        }

        [TestCleanup]
        public void CleanupTest()
        {
            TestExample1 = null;
            x = 0;
            y = 0;
            expected = 0;
            result = 0;
        }

        [TestMethod]
        public void AdditionTest()
        {
            // Arrange
            expected = 8;
            // Act
            result = TestExample1.Add(x, y);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DeductionTest()
        {
            // Arrange
            expected = 4;
            // Act
            result = TestExample1.Deduct(x, y);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            // Arrange
            expected = 12;
            // Act
            result = TestExample1.Multiply(x, y);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivisionTest()
        {
            // Arrange
            expected = 3;
            // Act
            result = TestExample1.Divide(x, y);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void YIsNotZero()
        {
            // Arrange
            string expectedString = "y is not 0";
            string resultString;
            if (y == 0)
            {
                resultString = "y = 0";
            }
            else resultString = "y is not 0";
            // Act
            result = TestExample1.Divide(x, y);
            // Assert
            Assert.AreEqual(expectedString, resultString);
        }
    }
}
