using System;
using Xunit;

namespace UnitTest.Tests.CalculatorTddTests
{
    public class CalculatorTddTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 4, 8)]
        [InlineData(2, 0, 0)]
        public void Should_Return_Correct_Result_When_Multiply_The_Given_2_Numbers(int number1, int number2,
            int expected)
        {
            // Arrange
            var calculatorTdd = new CalculatorTdd(number1, number2);

            // Act
            var actual = calculatorTdd.Multiply();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(8, 4, 2)]
        [InlineData(6, 4, 1.5)]
        [InlineData(0, 4, 0)]
        public void Should_Return_Correct_Result_When_Divide_The_Given_2_Numbers(int number1, int number2,
            double expected)
        {
            // Arrange
            var calculatorTdd = new CalculatorTdd(number1, number2);

            // Act
            var actual = calculatorTdd.Divide();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2)]
        public void Should_Throw_DivideByZeroException_When_Number2_Is_0(int number1)
        {
            const int number2 = 0;
            // Arrange
            var calculatorTdd = new CalculatorTdd(number1, number2);

            // Act
            void Act() => calculatorTdd.Divide();

            // Assert
            Assert.Throws<DivideByZeroException>(Act);
        }
    }
}
