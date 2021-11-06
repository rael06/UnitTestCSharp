namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitL : AbstractRomanDigitHalfUnit
    {
        public override char Character { get; } = 'L';
        public override IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitX();
        public override int ArabicValue { get; } = 50;
    }
}
