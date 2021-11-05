namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ComparableRomanLetter : AbstractComparableRomanLetter
    {
        public ComparableRomanLetter(IRomanLetter romanLetter)
        {
            RomanLetter = romanLetter;
        }

        public override bool Compare(IRomanLetter romanLetter) =>
            RomanLetter.Character == romanLetter?.Character;
    }
}
