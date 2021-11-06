using System;
using System.Collections.Generic;
using UnitTest.RomanToArabic.Models.RomanDigitAggregate;

namespace UnitTest.RomanToArabic.Services.Converters
{
    public class ArabicToRomanConverter : AbstractService<int>, IArabicToRomanConverter
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

        public ArabicToRomanConverter(int arabicNumber) : base(arabicNumber)
        {
            _arabicNumber = arabicNumber;
        }

        public string Convert()
        {
            if (_arabicNumber < ArabicNumberLowerLimit || _arabicNumber > ArabicNumberUpperLimit)
                throw new ArgumentException("the number exceeds limits: 1 to 4999");

            var conversionResult = "";
            double restOfArabicNumber = _arabicNumber;
            foreach (var romanDigit in _romanDigits)
            {
                var fractionOfRomanDigitsToAdd = restOfArabicNumber / romanDigit.ArabicValue;
                var sectionSizeOfRomanDigitsToAdd =
                    Math.Min(Math.Floor(fractionOfRomanDigitsToAdd), romanDigit.SectionSizeLimit);

                conversionResult = AddRomanDigits(sectionSizeOfRomanDigitsToAdd, conversionResult, romanDigit,
                    ref restOfArabicNumber);

                var fractionOfRomanDigitToAdd = restOfArabicNumber / romanDigit.ArabicValue;
                var hasPartialRomanDigitToAdd = romanDigit.FactorToTriggerPreviousRomanDigit is not null
                    ? fractionOfRomanDigitToAdd >=
                      romanDigit.FactorToTriggerPreviousRomanDigit
                    : false;

                if (hasPartialRomanDigitToAdd)
                {
                    conversionResult = AddPartialRomanDigit(conversionResult, romanDigit, ref restOfArabicNumber);
                }

                if (restOfArabicNumber <= 0)
                    break;
            }

            return conversionResult;
        }

        private static string AddRomanDigits(double sectionSizeOfRomanDigitToAdd, string conversionResult,
            AbstractRomanDigit romanDigit, ref double restOfArabicNumber)
        {
            for (var i = 0; i < sectionSizeOfRomanDigitToAdd; i++)
            {
                conversionResult += romanDigit.Character;
                restOfArabicNumber -= romanDigit.ArabicValue;
            }

            return conversionResult;
        }

        private static string AddPartialRomanDigit(string conversionResult, AbstractRomanDigit romanDigit,
            ref double restOfArabicNumber)
        {
            conversionResult += romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation.Character;
            conversionResult += romanDigit.Character;
            restOfArabicNumber -= romanDigit.ArabicValue -
                                  romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation.ArabicValue;
            return conversionResult;
        }
    }
}
