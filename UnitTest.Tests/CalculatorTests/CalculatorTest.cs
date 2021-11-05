using System;
using Xunit;

namespace UnitTest.Tests.CalculatorTests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(3, -5, -2)]
        [InlineData(3, 5, 8)]
        public void Calculator_Should_Return_Correct_Result_When_Add_2_Numbers(int number1, int number2, int expected)
        {
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Add();

            // Assert
            Assert.Equal(expected, actual);
        }

        // Subtract

        [Theory]
        [InlineData(3, -5, 8)]
        [InlineData(3, 5, -2)]
        public void Calculator_Should_Return_Correct_Result_When_Subtract_2_Numbers(int number1, int number2,
            int expected)
        {
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Subtract();

            // Assert
            Assert.Equal(expected, actual);
        }

        // Multiply

        [Fact]
        public void Calculator_Should_Return_2_When_Multiply_Minus1_And_Minus2()
        {
            const int number1 = -1;
            const int number2 = -2;
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Multiply();

            // Assert
            const int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Return_Minus8_When_Multiply_4_And_Minus2()
        {
            // Arrange
            const int number1 = 4;
            const int number2 = -2;
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Multiply();

            // Assert
            const int expected = -8;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Return_6_When_Multiply_3_And_2()
        {
            const int number1 = 3;
            const int number2 = 2;
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Multiply();

            // Assert
            const int expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Return_0_When_Multiply_5_And_0()
        {
            const int number1 = 5;
            const int number2 = 0;
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Multiply();

            // Assert
            const int expected = 0;
            Assert.Equal(expected, actual);
        }


        // Divide

        [Fact]
        public void Calculator_Should_Return_15_When_Divide_Minus31_And_Minus2()
        {
            const int number1 = -31;
            const int number2 = -2;
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Divide();

            // Assert
            const int expected = 15;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Return_0_When_Divide_6_And_Minus2()
        {
            // Arrange
            const int number1 = 6;
            const int number2 = -2;
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Divide();

            // Assert
            const int expected = -3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Return_0_When_Divide_0_And_3()
        {
            const int number1 = 0;
            const int number2 = 3;
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Divide();

            // Assert
            const int expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Throw_Exception_When_Divide_3_And_0()
        {
            // Arrange
            const int number1 = 3;
            const int number2 = 0;
            var calculator = new Calculator(number1, number2);

            // Act
            void Act() => calculator.Divide();

            // Assert
            Assert.Throws<DivideByZeroException>(Act);
        }
    }
}