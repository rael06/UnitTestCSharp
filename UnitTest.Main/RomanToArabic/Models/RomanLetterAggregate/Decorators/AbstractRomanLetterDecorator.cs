namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators
{
    public class AbstractRomanLetterDecorator : IRomanLetter
    {
        public char Character { get; }
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; }
        public int ArabicValue { get; }
    }
}
