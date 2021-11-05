namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators
{
    public abstract class AbstractComparableRomanLetter : IRomanLetter
    {
        public char Character { get; }
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; }
        public int ArabicValue { get; }
        protected IRomanLetter RomanLetter { get; init; }
        public abstract bool Compare(IRomanLetter romanLetter);
    }
}
