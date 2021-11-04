using Xunit;

namespace UnitTest.Tests.CalculatorTests
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculator_Should_Return_Minus1_When_Adds_1_And_Minus2()
        {
            const int number1 = 1;
            const int number2 = -2;
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Add();

            // Assert
            const int expected = -1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Return_0_When_Adds_1_And_Minus1()
        {
            // Arrange
            const int number1 = 1;
            const int number2 = -1;
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Add();

            // Assert
            const int expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Should_Return_1_When_Adds_1_And_0()
        {
            const int number1 = 1;
            const int number2 = 0;
            // Arrange
            var calculator = new Calculator(number1, number2);

            // Act
            var actual = calculator.Add();

            // Assert
            const int expected = 1;
            Assert.Equal(expected, actual);
        }
    }
}
