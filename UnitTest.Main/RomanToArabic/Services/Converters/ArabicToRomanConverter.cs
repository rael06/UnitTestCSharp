using System;
using System.Collections.Generic;
using UnitTest.RomanToArabic.Models.RomanLetterAggregate;

namespace UnitTest.RomanToArabic.Services.Converters
{
    public class ArabicToRomanConverter : AbstractService<int>, IArabicToRomanConverter
    {
        private readonly int _arabicNumber;

        private const int ArabicNumberLowerLimit = 1;
        private const int ArabicNumberUpperLimit = 4999;

        private readonly List<IRomanLetter> _romanLetters = new()
        {
            new RomanLetterX(),
            new RomanLetterV(),
            new RomanLetterI()
        };

        public ArabicToRomanConverter(int arabicNumber) : base(arabicNumber)
        {
            _arabicNumber = arabicNumber;
        }

        public string Convert()
        {
            var conversionResult = "";
            double restOfArabicNumber = _arabicNumber;
            foreach (var romanLetter in _romanLetters)
            {
                var numberOfRomanLetter = Math.Round(restOfArabicNumber / romanLetter.ArabicValue, 1);
                for (var i = 0; i < Math.Floor(numberOfRomanLetter); i++)
                {
                    conversionResult += romanLetter.Character;
                    restOfArabicNumber -= romanLetter.ArabicValue;
                }


                numberOfRomanLetter = Math.Round(restOfArabicNumber / romanLetter.ArabicValue, 1);
                if (numberOfRomanLetter > 0 && numberOfRomanLetter < 1 && numberOfRomanLetter == romanLetter.FactorToTriggerPreviousRomanLetter)
                {
                    conversionResult += romanLetter.PreviousRomanLetterToConsiderForArabicValueCalculation?.Character;
                    conversionResult += romanLetter.Character;
                    restOfArabicNumber -= romanLetter.ArabicValue;
                }

                if (restOfArabicNumber <= 0)
                    break;
            }

            return conversionResult;
        }
    }
}
