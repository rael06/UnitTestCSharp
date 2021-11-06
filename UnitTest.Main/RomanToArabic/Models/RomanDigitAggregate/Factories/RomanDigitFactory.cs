using System;
using System.Reflection;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Factories
{
    public class RomanDigitFactory : IRomanDigitFactory
    {
        private static RomanDigitFactory _instance;

        private RomanDigitFactory()
        {
        }

        public static RomanDigitFactory Instance =>
            _instance ??= new RomanDigitFactory();

        public AbstractRomanDigit Create(char character)
        {
            var romanDigitDecoratorType = Assembly.GetExecutingAssembly()
                .GetType($"{typeof(AbstractRomanDigit).Namespace}.RomanDigit{character}");
            return (AbstractRomanDigit) Activator.CreateInstance(romanDigitDecoratorType);
        }
    }
}
