namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public class RomanLetterM : IRomanLetter
    {
        public char Character { get; } = 'M';
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; } = new RomanLetterC();
        public int ArabicValue { get; } = 1000;
    }
}