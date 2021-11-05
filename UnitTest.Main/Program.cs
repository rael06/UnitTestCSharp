using System;
using UnitTest.RomanToArabic.Services;
using UnitTest.RomanToArabic.Services.Converters;
using UnitTest.RomanToArabic.Services.Factories;

namespace UnitTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string romanNumber = "MMMMDCCCLXXXVIII";
            var arabicNumber = ServiceFactory.Instance.Create<RomanToArabicConverter, string>(romanNumber).Convert();
            var rmn = ServiceFactory.Instance.Create<ArabicToRomanConverter, int>(4).Convert();
            Console.WriteLine($"The roman number: {romanNumber} is the arabic number: {arabicNumber}");
            Console.WriteLine($"The arabic number: {4} is the roman number: {rmn}");
        }
    }
}
