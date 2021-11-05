using System.Collections.Generic;
using UnitTest.RomanToArabic.Services.Converters;
using UnitTest.RomanToArabic.Services.Factories;
using Xunit;

namespace UnitTest.Tests.RomanToArabicTests
{
    public class ArabicToRomanConverterTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(21, "XXI")]
        [InlineData(23, "XXIII")]
        [InlineData(24, "XXIV")]
        [InlineData(25, "XXV")]
        [InlineData(26, "XXVI")]
        [InlineData(28, "XXVIII")]
        public void Should_Return_Arabic_To_Roman_Number_Conversion(int arabicNumber, string expected)
        {
            // Arrange
            var arabicToRomanConverter = ServiceFactory.Instance.Create<ArabicToRomanConverter, int>(arabicNumber);

            // Act
            var actual = arabicToRomanConverter.Convert();

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(4, "IIII")]
        public void Should_Not(int arabicNumber, string expected)
        {
            // Arrange
            var arabicToRomanConverter = ServiceFactory.Instance.Create<ArabicToRomanConverter, int>(arabicNumber);

            // Act
            var actual = arabicToRomanConverter.Convert();

            // Assert
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void Should_Return_IV()
        {
            // Arrange
            const int arabicNumber = 4;
            var arabicToRomanConverter = ServiceFactory.Instance.Create<ArabicToRomanConverter, int>(arabicNumber);

            // Act
            var actual = arabicToRomanConverter.Convert();

            // Assert
            const string expected = "IV";
            Assert.Equal(expected, actual);
        }
    }
}
