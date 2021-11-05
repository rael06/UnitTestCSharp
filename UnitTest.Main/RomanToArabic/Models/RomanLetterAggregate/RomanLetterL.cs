namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public class RomanLetterL : IRomanLetter
    {
        public char Character { get; } = 'L';
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; } = new RomanLetterX();
        public int ArabicValue { get; } = 50;
    }
}
