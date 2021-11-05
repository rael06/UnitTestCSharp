using System;
using UnitTest.RomanToArabic.Services;

namespace UnitTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string romanNumber = "MMMMDCCCLXXXVIII";
            var arabicNumber = new RomanToArabicConverter(romanNumber).Convert();
            Console.WriteLine($"The roman number: {romanNumber} is the arabic number: {arabicNumber}");
        }
    }
}