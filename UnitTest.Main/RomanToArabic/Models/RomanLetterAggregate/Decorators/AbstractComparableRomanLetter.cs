namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators
{
    public abstract class AbstractComparableRomanLetter : AbstractRomanLetterDecorator
    {
        protected IRomanLetter RomanLetter { get; init; }
        public abstract bool Compare(IRomanLetter romanLetter);
    }
}
