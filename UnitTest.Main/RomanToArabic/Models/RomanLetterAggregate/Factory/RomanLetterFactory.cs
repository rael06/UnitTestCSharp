using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factory
{
    public static class RomanLetterFactory
    {
        public static IRomanLetter Create(char character)
        {
            return (IRomanLetter) typeof(IRomanLetter).Assembly.CreateInstance(
                $"{typeof(IRomanLetter).Namespace}.RomanLetter{character}");
        }
    }
}