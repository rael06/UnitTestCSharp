using System;
using System.Linq;
using System.Text.RegularExpressions;
using UnitTest.RomanToArabic.Models.RomanDigitAggregate;
using UnitTest.RomanToArabic.Models.RomanDigitAggregate.Decorators;
using UnitTest.RomanToArabic.Models.RomanDigitAggregate.Factories;
using UnitTest.RomanToArabic.Services.Converters;

namespace UnitTest.RomanToArabic.Services
{
    public class RomanToArabicConverter : IRomanToArabicConverter
    {
        private readonly string _romanNumber;

        // Source: https://www.it-swarm-fr.com/fr/regex/comment-ne-faire-correspondre-que-des-chiffres-romains-valides-avec-une-expression-reguliere/958543079/
        private readonly Regex _validInputRegex = new("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");

        private RomanToArabicConverter(string romanNumber)
        {
            _romanNumber = romanNumber;
        }

        public RomanToArabicConverter()
        {
        }

        public IConverter<string, int> Init(string romanNumber)
            => new RomanToArabicConverter(romanNumber);

        public int Convert()
        {
            if (!_validInputRegex.IsMatch(_romanNumber))
                throw new ArgumentException("Invalid input");

            var romanDigits = GetRomanDigits();
            var conversion = 0;

            for (var i = 0; i < romanDigits.Length; i++)
            {
                // assign previousRomanDigit only from the second iteration
                var previousRomanDigit =
                    i >= 1
                        ? RomanDigitDecoratorFactory.Instance.Create<ComparableRomanDigit>(romanDigits[i - 1])
                        : null;

                var romanDigit = romanDigits[i];
                var HasNotPreviousRomanDigitToConsiderForArabicValueCalculation =
                    previousRomanDigit is null ||
                    !previousRomanDigit.Compare(romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation);

                conversion += romanDigit.ArabicValue;
                if (HasNotPreviousRomanDigitToConsiderForArabicValueCalculation)
                    continue;
                // * 2 because we must also subtract the arabic value of the previous roman Digit
                // added during previous iteration
                var valueToSubtract =
                    romanDigit.PreviousRomanDigitToConsiderForArabicValueCalculation.ArabicValue * 2;
                conversion -= valueToSubtract;
            }

            return conversion;
        }

        private AbstractRomanDigit[] GetRomanDigits() =>
            _romanNumber.ToCharArray().Select(RomanDigitFactory.Instance.Create).ToArray();
    }
}
