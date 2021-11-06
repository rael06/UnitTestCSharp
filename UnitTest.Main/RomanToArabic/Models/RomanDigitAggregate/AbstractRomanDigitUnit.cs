namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public abstract class AbstractRomanDigitUnit : AbstractRomanDigit
    {
        public override int SectionSizeLimit { get; } = 3;
    }
}
