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
                var numberOfRomanDigit = restOfArabicNumber / romanDigit.ArabicValue;
                for (var i = 0; i < Math.Floor(numberOfRomanDigit) && i < romanDigit.LimitInRomanNumber; i++)
                {
                    conversionResult += romanDigit.Character;
                    restOfArabicNumber -= romanDigit.ArabicValue;
                }


                numberOfRomanDigit = restOfArabicNumber / romanDigit.ArabicValue;
                if (numberOfRomanDigit > 0 && numberOfRomanDigit < 1 &&
                    numberOfRomanDigit >= romanDigit.FactorToTriggerPreviousRomanDigit)
                {
                    conversionResult += romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation?.Character;
                    conversionResult += romanDigit.Character;
                    restOfArabicNumber -= romanDigit.ArabicValue -
                                          (romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation
                                              ?.ArabicValue ?? 0);
                }

                if (restOfArabicNumber <= 0)
                    break;
            }

            return conversionResult;
        }
    }
}
