namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public class RomanLetterC : IRomanLetter
    {
        public char Character { get; } = 'C';
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; } = new RomanLetterX();
        public int ArabicValue { get; } = 100;
    }
}
