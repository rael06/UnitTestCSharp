using System;
using UnitTest.RomanToArabic.Services;

namespace UnitTest
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new RomanToArabicConverter("VI").Convert());
        }
    }
}
