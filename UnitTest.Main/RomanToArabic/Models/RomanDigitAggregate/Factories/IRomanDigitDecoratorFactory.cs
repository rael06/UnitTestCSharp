using UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Factories
{
    public interface IRomanDigitDecoratorFactory
    {
        T Create<T>(IRomanDigit romanDigit)
            where T : AbstractRomanDigitDecorator;
    }
}
