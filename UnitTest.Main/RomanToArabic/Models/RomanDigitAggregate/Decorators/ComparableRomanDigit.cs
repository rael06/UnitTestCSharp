namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ComparableRomanDigit : AbstractComparableRomanDigit
    {
        public ComparableRomanDigit(AbstractRomanDigit romanDigit)
        {
            RomanDigit = romanDigit;
        }

        public override bool Compare(AbstractRomanDigit romanDigit) =>
            RomanDigit.Character == romanDigit?.Character;

        public override char Character { get; }
        public override AbstractRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        public override int ArabicValue { get; }
        public override int SectionSizeLimit { get; }
    }
}
