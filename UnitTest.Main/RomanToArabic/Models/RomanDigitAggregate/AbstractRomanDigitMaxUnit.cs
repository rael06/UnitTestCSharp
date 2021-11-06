namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public abstract class AbstractRomanDigitMaxUnit : AbstractRomanDigit
    {
        public override int SectionSizeLimit { get; } = 4;
    }
}
