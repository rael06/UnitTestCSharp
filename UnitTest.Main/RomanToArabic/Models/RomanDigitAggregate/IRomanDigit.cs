using System;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public interface IRomanDigit
    {
        public char Character { get; }
        public IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        public int ArabicValue { get; }

        public double FactorToTriggerPreviousRomanDigit =>
            PreviousRomanDigitToConsiderForArabicValueCalculation is not null
                ? Math.Round(
                    (double) (ArabicValue - PreviousRomanDigitToConsiderForArabicValueCalculation.ArabicValue) /
                    ArabicValue, 1)
                : 0;
    }
}
