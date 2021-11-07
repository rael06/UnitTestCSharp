using System;
using System.Collections.Generic;
using System.Linq;
using UnitTest.RomanToArabic.Models.RomanDigitAggregate;
using UnitTest.Utils;

namespace UnitTest.RomanToArabic.Services.Converters
{
    public class ArabicToRomanConverter : IArabicToRomanConverter
    {
        private readonly int _arabicNumber;

        private const int ArabicNumberLowerLimit = 1;
        private const int ArabicNumberUpperLimit = 4999;

        private readonly List<AbstractRomanDigit> _romanDigits = new()
        {
            new RomanDigitM(),
            new RomanDigitD(),
            new RomanDigitC(),
            new RomanDigitL(),
            new RomanDigitX(),
            new RomanDigitV(),
            new RomanDigitI()
        };

        private ArabicToRomanConverter(int arabicNumber)
        {
            _arabicNumber = arabicNumber;
        }

        public ArabicToRomanConverter()
        {
        }

        public IConverter<int, string> Init(int arabicNumber) =>
            new ArabicToRomanConverter(arabicNumber);

        public string Convert()
        {
            if (_arabicNumber < ArabicNumberLowerLimit || _arabicNumber > ArabicNumberUpperLimit)
                throw new ArgumentException("the number exceeds limits: 1 to 4999");

            double restOfArabicNumber = _arabicNumber;

            return _romanDigits.Aggregate(string.Empty, (conversionResult, romanDigit) =>
            {
                var numberOfRomanDigitsToAdd = restOfArabicNumber / romanDigit.ArabicValue;

                var noRomanDigitToAdd = numberOfRomanDigitsToAdd < romanDigit.FactorToTriggerPreviousRomanDigit;
                if (noRomanDigitToAdd)
                    return conversionResult;

                var sectionSizeOfRomanDigitsToAdd =
                    Math.Min((int) numberOfRomanDigitsToAdd, romanDigit.SectionSizeLimit);

                if (sectionSizeOfRomanDigitsToAdd > 0)
                {
                    AddRomanDigits(ref conversionResult, ref restOfArabicNumber, sectionSizeOfRomanDigitsToAdd,
                        romanDigit);
                    numberOfRomanDigitsToAdd -= sectionSizeOfRomanDigitsToAdd;
                }

                var hasPartialRomanDigitToAdd =
                    romanDigit.FactorToTriggerPreviousRomanDigit is not null &&
                    numberOfRomanDigitsToAdd.IsGreaterOrEqualWithToleranceThan(
                        (double) romanDigit.FactorToTriggerPreviousRomanDigit);

                if (hasPartialRomanDigitToAdd)
                {
                    AddPartialRomanDigit(ref conversionResult, ref restOfArabicNumber, romanDigit);
                }

                return conversionResult;
            });
        }

        private static void AddRomanDigits(
            ref string conversionResult,
            ref double restOfArabicNumber,
            int sectionSizeOfRomanDigitToAdd,
            AbstractRomanDigit romanDigit)
        {
            for (var i = 0; i < sectionSizeOfRomanDigitToAdd; i++)
            {
                conversionResult += romanDigit.Character;
                restOfArabicNumber -= romanDigit.ArabicValue;
            }
        }

        private static void AddPartialRomanDigit(
            ref string conversionResult,
            ref double restOfArabicNumber,
            AbstractRomanDigit romanDigit)
        {
            conversionResult += romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation.Character;
            conversionResult += romanDigit.Character;
            restOfArabicNumber -= romanDigit.ArabicValue -
                                  romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation.ArabicValue;
        }
    }
}
