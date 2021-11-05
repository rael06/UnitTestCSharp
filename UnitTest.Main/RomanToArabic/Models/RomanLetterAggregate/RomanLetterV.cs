namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public class RomanLetterV : IRomanLetter
    {
        public char Character { get; } = 'V';
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; } = new RomanLetterI();
        public int ArabicValue { get; } = 5;
    }
}