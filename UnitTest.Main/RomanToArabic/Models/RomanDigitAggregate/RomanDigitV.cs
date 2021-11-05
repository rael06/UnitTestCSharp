namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitV : IRomanDigit
    {
        public char Character { get; } = 'V';
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitI();
        public int ArabicValue { get; } = 5;
    }
}