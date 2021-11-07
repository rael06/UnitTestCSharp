namespace UnitTest.RomanToArabic.Services.Converters
{
    public abstract class AbstractArabicToRomanConverter: AbstractConverter<int, string>
    {
        protected AbstractArabicToRomanConverter(int parameters) : base(parameters)
        {
        }
    }
}
