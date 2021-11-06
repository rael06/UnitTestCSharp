namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitD : AbstractRomanDigitHalfUnit
    {
        public override char Character { get; } = 'D';
        public override AbstractRomanDigitUnit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitC();
        public override int ArabicValue { get; } = 500;
    }
}
