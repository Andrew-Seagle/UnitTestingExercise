using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 4, 15, 22)]
        [InlineData(-4, 3, -10, -11)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var unitTestMethods = new UnitTestMethods();
            //Act
            var actual = unitTestMethods.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25, 14, 11)]
        [InlineData(-134, 78, -212)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var unitTestMethods = new UnitTestMethods();
            //Act
            var actual = unitTestMethods.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 13, 156)]
        [InlineData(67, -2, -134)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var unitTestMethods = new UnitTestMethods();
            //Act
            var actual = unitTestMethods.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(95, 5, 19)]
        [InlineData(-234, 12, -19)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var unitTestMethods = new UnitTestMethods();
            //Act
            var actual = unitTestMethods.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UpperCaseTest()
        {
            //Arrange
            var unitTestMethods = new UnitTestMethods();
            //Act
            var actual = unitTestMethods.UpperCase("hello");
            //Assert
            Assert.Equal("HELLO", actual);
        }

        [Fact]
        public void GetPiTest()
        {
            //Arrange
            var unitTestMethods = new UnitTestMethods();
            //Act
            var actual = unitTestMethods.GetPi();
            //Assert
            Assert.Equal(Math.PI, actual);
        }
    }
}
