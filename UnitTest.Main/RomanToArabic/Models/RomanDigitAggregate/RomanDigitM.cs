namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitM : IRomanDigit
    {
        public char Character { get; } = 'M';
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitC();
        public int ArabicValue { get; } = 1000;
    }
}