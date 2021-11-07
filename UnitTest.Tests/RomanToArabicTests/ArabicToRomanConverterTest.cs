using System;
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
        [InlineData(40, "XL")]
        [InlineData(43, "XLIII")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(46, "XLVI")]
        [InlineData(48, "XLVIII")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(53, "LIII")]
        [InlineData(54, "LIV")]
        [InlineData(55, "LV")]
        [InlineData(58, "LVIII")]
        [InlineData(59, "LIX")]
        [InlineData(80, "LXXX")]
        [InlineData(83, "LXXXIII")]
        [InlineData(84, "LXXXIV")]
        [InlineData(85, "LXXXV")]
        [InlineData(88, "LXXXVIII")]
        [InlineData(89, "LXXXIX")]
        [InlineData(90, "XC")]
        [InlineData(93, "XCIII")]
        [InlineData(94, "XCIV")]
        [InlineData(95, "XCV")]
        [InlineData(98, "XCVIII")]
        [InlineData(99, "XCIX")]
        [InlineData(100, "C")]
        [InlineData(301, "CCCI")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(600, "DC")]
        [InlineData(800, "DCCC")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(3348, "MMMCCCXLVIII")]
        [InlineData(3889, "MMMDCCCLXXXIX")]
        [InlineData(4444, "MMMMCDXLIV")]
        [InlineData(4999, "MMMMCMXCIX")]
        public void Should_Return_Correct_Conversion_Of_Arabic_To_Roman_Number(int arabicNumber,
            string expectedRomanNumber)
        {
            // Arrange
            var arabicToRomanConverter = ServiceFactory.Instance.Create<ArabicToRomanConverter>(arabicNumber);

            // Act
            var actual = arabicToRomanConverter.Convert();

            // Assert
            Assert.Equal(expectedRomanNumber, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5000)]
        public void Should_Throw_ArgumentException_When_Arabic_Number_Is_Invalid(int arabicNumber)
        {
            // Arrange
            var arabicToRomanConverter = ServiceFactory.Instance.Create<ArabicToRomanConverter>(arabicNumber);

            // Act
            void Act() => arabicToRomanConverter.Convert();

            // Assert
            Assert.Throws<ArgumentException>(Act);
        }

        [Theory]
        [InlineData(64, "IIII")]
        [InlineData(30, "VV")]
        [InlineData(43, "XXXX")]
        public void Should_Not_Return_Invalid_Roman_Number(int arabicNumber, string expectedRomanNumberSection)
        {
            // Arrange
            var arabicToRomanConverter = ServiceFactory.Instance.Create<ArabicToRomanConverter>(arabicNumber);

            // Act
            var conversionResult = arabicToRomanConverter.Convert();

            // Assert
            Assert.DoesNotContain(expectedRomanNumberSection, conversionResult);
        }
    }
}
