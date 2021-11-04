namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public interface IRomanLetter
    {
        public char Character { get; }
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; }
        public int ArabicValue { get; }
    }
}
