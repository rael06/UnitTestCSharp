using System;
using UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Factories
{
    public class RomanDigitDecoratorFactory : IRomanDigitDecoratorFactory
    {
        private static RomanDigitDecoratorFactory _instance;

        private RomanDigitDecoratorFactory()
        {
        }

        public static RomanDigitDecoratorFactory Instance =>
            _instance ??= new RomanDigitDecoratorFactory();


        public T Create<T>(IRomanDigit romanDigit)
            where T : AbstractRomanDigitDecorator
        {
            return (T) Activator.CreateInstance(typeof(T), romanDigit);
        }
    }
}
