namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitX : AbstractRomanDigitUnit
    {
        public override char Character { get; } = 'X';
        public override AbstractRomanDigitUnit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitI();
        public override int ArabicValue { get; } = 10;
    }
}
