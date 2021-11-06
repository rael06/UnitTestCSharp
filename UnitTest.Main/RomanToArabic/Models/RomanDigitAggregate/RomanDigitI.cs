namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitI : AbstractRomanDigitUnit
    {
        public override char Character { get; } = 'I';
        public override AbstractRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = null;
        public override int ArabicValue { get; } = 1;
    }
}
