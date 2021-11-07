using UnitTest.RomanToArabic.Services;
using UnitTest.RomanToArabic.Services.Converters;
using UnitTest.RomanToArabic.Services.Factories;
using Xunit;

namespace UnitTest.Tests.RomanToArabicTests
{
    public class ConverterTest
    {
        [Theory]
        [InlineData(3348, "MMMCCCXLVIII")]
        [InlineData(3889, "MMMDCCCLXXXIX")]
        [InlineData(4444, "MMMMCDXLIV")]
        [InlineData(4999, "MMMMCMXCIX")]
        public void Should_Convert_Arabic_To_Roman_Number_Properly(int arabicNumber, string romanNumber)
        {
            var arabicToRomanConverter = ServiceFactory.Instance.Create<ArabicToRomanConverter>(arabicNumber);
            var actualRomanNumber = arabicToRomanConverter.Convert();

            Assert.Equal(romanNumber, actualRomanNumber);

            var romanToArabicConverter =
                ServiceFactory.Instance.Create<RomanToArabicConverter>(actualRomanNumber);
            var actualArabicNumber = romanToArabicConverter.Convert();

            Assert.Equal(arabicNumber, actualArabicNumber);
        }
    }
}
