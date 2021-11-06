using System;

namespace UnitTest.RomanToArabic.Models.RomanDigitAggregate
{
    public interface IRomanDigit
    {
        char Character { get; }
        IRomanDigit PreviousRomanDigitToConsiderForArabicValueCalculation { get; }
        int ArabicValue { get; }
        int LimitInRomanNumber { get; }

        public double FactorToTriggerPreviousRomanDigit =>
            PreviousRomanDigitToConsiderForArabicValueCalculation is not null
                ? (double) (ArabicValue - PreviousRomanDigitToConsiderForArabicValueCalculation.ArabicValue) /
                  ArabicValue
                : 0;
    }
}
