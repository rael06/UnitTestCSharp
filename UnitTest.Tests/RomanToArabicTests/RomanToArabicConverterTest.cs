using System;
using UnitTest.RomanToArabic.Services;
using UnitTest.RomanToArabic.Services.Factories;
using Xunit;

namespace UnitTest.Tests.RomanToArabicTests
{
    public class RomanToArabicConverterTest
    {
        [Theory]
        [InlineData("a")]
        [InlineData("5")]
        [InlineData("i")]
        [InlineData("IIII")]
        [InlineData("VV")]
        [InlineData("XXXX")]
        [InlineData("LL")]
        [InlineData("CCCC")]
        [InlineData("DD")]
        [InlineData("MMMMM")]
        public void Should_Throw_ArgumentException_When_Input_Is_Invalid(string input)
        {
            // Arrange
            var romanToArabic = new RomanToArabicConverter(input);

            // Act
            void Act() => romanToArabic.Convert();

            // Assert
            Assert.Throws<ArgumentException>(Act);
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("XLIX", 49)]
        [InlineData("MMMMCDXLIV", 4444)]
        [InlineData("MMMMCMXCIX", 4999)]
        [InlineData("MMMDCCXLIX", 3749)]
        [InlineData("MMMMDCCCLXXXVIII", 4888)]
        public void Should_Return_Correct_Conversion_Of_Input(string input, int expected)
        {
            // Arrange
            var romanToArabic = ServiceFactory.Instance.Create<RomanToArabicConverter, string>(input);

            // Act
            var actual = romanToArabic.Convert();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
