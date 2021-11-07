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
            const string inputRomanNumber = "MMMMDCCCLXXXVIII";
            var arabicNumber = ServiceFactory.Instance.Create<RomanToArabicConverter>().Init(inputRomanNumber).Convert();
            Console.WriteLine($"The roman number: {inputRomanNumber} is the arabic number: {arabicNumber}");

            var romanNumber = ServiceFactory.Instance.Create<ArabicToRomanConverter>().Init(arabicNumber).Convert();
            Console.WriteLine($"The arabic number: {arabicNumber} is the roman number: {romanNumber}");
        }
    }
}
