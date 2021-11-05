namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Factories
{
    public interface IRomanDigitFactory
    {
        IRomanDigit Create(char character);
    }
}