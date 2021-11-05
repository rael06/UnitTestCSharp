namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitC : IRomanDigit
    {
        public char Character { get; } = 'C';
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitX();
        public int ArabicValue { get; } = 100;
    }
}
