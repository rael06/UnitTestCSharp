using System;
using UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators;

namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factories
{
    public class RomanLetterDecoratorFactory : IRomanLetterDecoratorFactory
    {
        private static RomanLetterDecoratorFactory _instance;
        public static RomanLetterDecoratorFactory Instance =>
            _instance ??= new RomanLetterDecoratorFactory();

        private RomanLetterDecoratorFactory()
        {
        }


        public T Create<T>(IRomanLetter romanLetter)
            where T : AbstractRomanLetterDecorator
        {
            return (T) Activator.CreateInstance(typeof(T), romanLetter);
        }
    }
}
