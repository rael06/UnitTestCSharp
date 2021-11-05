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

        public IRomanDigit Create(char character)
        {
            var romanDigitDecoratorType = Assembly.GetExecutingAssembly()
                .GetType($"{typeof(IRomanDigit).Namespace}.RomanDigit{character}");
            return (IRomanDigit) Activator.CreateInstance(romanDigitDecoratorType);
        }
    }
}
