namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public class RomanLetterI : IRomanLetter
    {
        public char Character { get; } = 'I';
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; } = null;
        public int ArabicValue { get; } = 1;
    }
}
