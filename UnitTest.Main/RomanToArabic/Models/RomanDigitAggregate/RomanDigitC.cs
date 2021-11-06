namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitC : AbstractRomanDigitUnit
    {
        public override char Character { get; } = 'C';
        public override IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitX();
        public override int ArabicValue { get; } = 100;
    }
}
