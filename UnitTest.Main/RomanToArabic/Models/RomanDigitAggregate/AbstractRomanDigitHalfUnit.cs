namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public abstract class AbstractRomanDigitHalfUnit : IRomanDigit
    {
        public abstract char Character { get; }
        public abstract IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        public abstract int ArabicValue { get; }
        public int LimitInRomanNumber { get; } = 1;
    }
}
