namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitD : IRomanDigit
    {
        public char Character { get; } = 'D';
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitC();
        public int ArabicValue { get; } = 500;
    }
}