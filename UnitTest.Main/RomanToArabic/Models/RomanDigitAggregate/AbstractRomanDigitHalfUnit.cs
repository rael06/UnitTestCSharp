namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public abstract class AbstractRomanDigitHalfUnit : AbstractRomanDigit
    {
        public override int SectionSizeLimit { get; } = 1;
    }
}
