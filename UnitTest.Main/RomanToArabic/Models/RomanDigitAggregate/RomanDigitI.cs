namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitI : IRomanDigit
    {
        public char Character { get; } = 'I';
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = null;
        public int ArabicValue { get; } = 1;
    }
}