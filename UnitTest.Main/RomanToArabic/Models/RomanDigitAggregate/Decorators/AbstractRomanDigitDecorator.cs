namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators
{
    public class AbstractRomanDigitDecorator : IRomanDigit
    {
        public char Character { get; }
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        public int ArabicValue { get; }
    }
}
