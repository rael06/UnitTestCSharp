using System;
using System.Collections.Generic;
using System.Reflection;
using UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators;

namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factory
{
    public static class RomanLetterFactory
    {
        public static IRomanLetter Create(char character)
        {
            return (IRomanLetter) typeof(IRomanLetter).Assembly.CreateInstance(
                $"{typeof(IRomanLetter).Namespace}.RomanLetter{character}");
        }

        public static T Create<T>(IRomanLetter romanLetter)
            where T : IRomanLetter
        {
            return (T) Activator.CreateInstance(typeof(T), romanLetter);
        }
    }
}
