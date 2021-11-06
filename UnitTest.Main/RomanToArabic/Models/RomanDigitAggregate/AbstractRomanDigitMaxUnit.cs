namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public abstract class AbstractRomanDigitMaxUnit : IRomanDigit
    {
        public abstract char Character { get; }
        public abstract IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        public abstract int ArabicValue { get; }
        public int LimitInRomanNumber { get; } = 4;
    }
}
