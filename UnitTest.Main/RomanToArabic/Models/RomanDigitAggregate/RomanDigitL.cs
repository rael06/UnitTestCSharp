namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitL : IRomanDigit
    {
        public char Character { get; } = 'L';
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitX();
        public int ArabicValue { get; } = 50;
    }
}
