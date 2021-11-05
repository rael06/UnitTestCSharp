using System;
using System.Linq;
using System.Text.RegularExpressions;
using UnitTest.RomanToArabic.Models.RomanLetterAggregate;
using UnitTest.RomanToArabic.Models.RomanLetterAggregate.Decorators;
using UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factory;

namespace UnitTest.RomanToArabic.Services
{
    public class RomanToArabicConverter : IRomanToArabicConverter
    {
        // Source: https://www.it-swarm-fr.com/fr/regex/comment-ne-faire-correspondre-que-des-chiffres-romains-valides-avec-une-expression-reguliere/958543079/
        private readonly Regex validInputRegex = new("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");

        private readonly string _input;

        public RomanToArabicConverter(string input)
        {
            _input = input;
        }

        public int Convert()
        {
            if (!validInputRegex.IsMatch(_input))
                throw new ArgumentException("Invalid input");

            var romanLetters = GetRomanLetters();
            var conversion = 0;

            for (var i = 0; i < romanLetters.Length; i++)
            {
                // assign previousRomanLetter only from the second iteration
                var previousRomanLetter = i >= 1 ?
                    RomanLetterDecoratorFactory.Create<ComparableRomanLetter>(romanLetters[i - 1]) : null;

                var romanLetter = romanLetters[i];
                var HasNotPreviousRomanLetterToConsiderForArabicValueCalculation =
                    previousRomanLetter is null ||
                    !previousRomanLetter.Compare(romanLetter.PreviousRomanLetterToConsiderForArabicValueCalculation);

                conversion += romanLetter.ArabicValue;
                if (HasNotPreviousRomanLetterToConsiderForArabicValueCalculation)
                    continue;
                // * 2 because we must also subtract the arabic value of the previous roman letter
                // added during previous iteration
                var valueToSubtract =
                    romanLetter.PreviousRomanLetterToConsiderForArabicValueCalculation.ArabicValue * 2;
                conversion -= valueToSubtract;
            }

            return conversion;
        }

        private IRomanLetter[] GetRomanLetters() =>
            _input.ToCharArray().Select(RomanLetterFactory.Create).ToArray();
    }
}
