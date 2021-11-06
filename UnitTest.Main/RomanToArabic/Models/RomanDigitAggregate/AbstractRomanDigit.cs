using System;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public abstract class AbstractRomanDigit
    {
        protected AbstractRomanDigit()
        {
            FactorToTriggerPreviousRomanDigit = PreviousRomanDigitToConsiderForArabicValueCalculation is not null
                ? (double) (ArabicValue - PreviousRomanDigitToConsiderForArabicValueCalculation.ArabicValue) /
                  ArabicValue
                : null;
        }

        public abstract char Character { get; }
        public abstract AbstractRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        public abstract int ArabicValue { get; }
        public abstract int SectionSizeLimit { get; }
        public double? FactorToTriggerPreviousRomanDigit { get; }
    }
}
