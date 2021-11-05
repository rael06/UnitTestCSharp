using System;
using UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators;

namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factories
{
    public static class RomanLetterDecoratorFactory
    {
        public static T Create<T>(IRomanLetter romanLetter)
            where T : AbstractRomanLetterDecorator
        {
            return (T) Activator.CreateInstance(typeof(T), romanLetter);
        }
    }
}
