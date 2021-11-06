namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Factories
{
    public interface IRomanDigitFactory
    {
        AbstractRomanDigit Create(char character);
    }
}