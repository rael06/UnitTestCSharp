namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitV : AbstractRomanDigitHalfUnit
    {
        public override char Character { get; } = 'V';
        public override AbstractRomanDigitUnit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitI();
        public override int ArabicValue { get; } = 5;
    }
}
