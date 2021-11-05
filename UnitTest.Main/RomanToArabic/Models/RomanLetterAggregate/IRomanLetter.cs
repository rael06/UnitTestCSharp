using System;

namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate
{
    public interface IRomanLetter
    {
        public char Character { get; }
        public IRomanLetter PreviousRomanLetterToConsiderForArabicValueCalculation { get; }
        public int ArabicValue { get; }

        public double FactorToTriggerPreviousRomanLetter =>
            PreviousRomanLetterToConsiderForArabicValueCalculation is not null
                ? Math.Round(
                    (double) (ArabicValue - PreviousRomanLetterToConsiderForArabicValueCalculation.ArabicValue) /
                    ArabicValue, 1)
                : 0;
    }
}
