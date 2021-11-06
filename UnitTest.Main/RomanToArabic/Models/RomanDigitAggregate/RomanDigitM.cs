namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public class RomanDigitM : AbstractRomanDigitMaxUnit
    {
        public override char Character { get; } = 'M';
        public override AbstractRomanDigitUnit PreviousRomanDigitToConsiderForArabicValueCalculation { get; } = new RomanDigitC();
        public override int ArabicValue { get; } = 1000;
    }
}
