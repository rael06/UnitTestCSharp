namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitX : IRomanDigit
    {
        public char Character { get; } = 'X';
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitI();
        public int ArabicValue { get; } = 10;
    }
}
