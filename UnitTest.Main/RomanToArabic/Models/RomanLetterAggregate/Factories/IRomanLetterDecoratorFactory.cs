using UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators;

namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factories
{
    public interface IRomanLetterDecoratorFactory
    {
        T Create<T>(IRomanLetter romanLetter)
            where T : AbstractRomanLetterDecorator;
    }
}
