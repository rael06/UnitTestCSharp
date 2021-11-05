namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators
{
    public abstract class AbstractComparableRomanDigit : AbstractRomanDigitDecorator
    {
        protected IRomanDigit RomanDigit { get; init; }
        public abstract bool Compare(IRomanDigit romanDigit);
    }
}
