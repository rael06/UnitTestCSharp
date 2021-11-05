namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ComparableRomanDigit : AbstractComparableRomanDigit
    {
        public ComparableRomanDigit(IRomanDigit romanDigit)
        {
            RomanDigit = romanDigit;
        }

        public override bool Compare(IRomanDigit romanDigit) =>
            RomanDigit.Character == romanDigit?.Character;
    }
}
