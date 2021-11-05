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

        private readonly List<IRomanDigit> _romanDigits = new()
        {
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
            var conversionResult = "";
            double restOfArabicNumber = _arabicNumber;
            foreach (var romanDigit in _romanDigits)
            {
                var numberOfRomanDigit = Math.Round(restOfArabicNumber / romanDigit.ArabicValue, 1);
                for (var i = 0; i < Math.Floor(numberOfRomanDigit); i++)
                {
                    conversionResult += romanDigit.Character;
                    restOfArabicNumber -= romanDigit.ArabicValue;
                }


                numberOfRomanDigit = Math.Round(restOfArabicNumber / romanDigit.ArabicValue, 1);
                if (numberOfRomanDigit > 0 && numberOfRomanDigit < 1 && numberOfRomanDigit == romanDigit.FactorToTriggerPreviousRomanDigit)
                {
                    conversionResult += romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation?.Character;
                    conversionResult += romanDigit.Character;
                    restOfArabicNumber -= romanDigit.ArabicValue;
                }

                if (restOfArabicNumber <= 0)
                    break;
            }

            return conversionResult;
        }
    }
}
