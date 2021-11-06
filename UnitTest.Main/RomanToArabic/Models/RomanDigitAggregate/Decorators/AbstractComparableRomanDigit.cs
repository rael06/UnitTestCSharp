namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators
{
    public abstract class AbstractComparableRomanDigit : AbstractRomanDigit
    {
        protected AbstractRomanDigit RomanDigit { get; init; }
        public abstract bool Compare(AbstractRomanDigit romanDigit);
    }
}
