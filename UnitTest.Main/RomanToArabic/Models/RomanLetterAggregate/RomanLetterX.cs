namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public class RomanLetterX : IRomanLetter
    {
        public char Character { get; } = 'X';
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; } = new RomanLetterI();
        public int ArabicValue { get; } = 10;
    }
}