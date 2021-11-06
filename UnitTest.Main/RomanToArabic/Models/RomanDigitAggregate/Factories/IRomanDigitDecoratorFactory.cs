using UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Factories
{
    public interface IRomanDigitDecoratorFactory
    {
        T Create<T>(AbstractRomanDigit romanDigit)
            where T : AbstractRomanDigit;
    }
}
