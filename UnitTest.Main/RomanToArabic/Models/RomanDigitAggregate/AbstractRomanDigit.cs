using System;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public abstract class AbstractRomanDigit
    {
        protected AbstractRomanDigit()
        {
            if (PreviousRomanDigitToConsiderForArabicValueCalculation is not null)
                FactorToTriggerPreviousRomanDigit =
                    (double) (ArabicValue - PreviousRomanDigitToConsiderForArabicValueCalculation.ArabicValue) /
                    ArabicValue;
        }

        public abstract char Character { get; }
        public abstract AbstractRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        public abstract int ArabicValue { get; }
        public abstract int SectionSizeLimit { get; }
        public double? FactorToTriggerPreviousRomanDigit { get; }
    }
}
