using System;
using System.Reflection;

namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factories
{
    public class RomanLetterFactory : IRomanLetterFactory
    {
        private static RomanLetterFactory _instance;

        private RomanLetterFactory()
        {
        }

        public static RomanLetterFactory Instance =>
            _instance ??= new RomanLetterFactory();

        public IRomanLetter Create(char character)
        {
            var romanLetterDecoratorType = Assembly.GetExecutingAssembly()
                .GetType($"{typeof(IRomanLetter).Namespace}.RomanLetter{character}");
            return (IRomanLetter) Activator.CreateInstance(romanLetterDecoratorType);
        }
    }
}
