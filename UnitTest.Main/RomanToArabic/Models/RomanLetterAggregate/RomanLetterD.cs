namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public class RomanLetterD : IRomanLetter
    {
        public char Character { get; } = 'D';
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; } = new RomanLetterC();
        public int ArabicValue { get; } = 500;
    }
}