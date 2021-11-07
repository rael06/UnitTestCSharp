namespace UnitTest.RomanToArabic.Services.Converters
{
    public abstract class AbstractRomanToArabicConverter : AbstractConverter<string, int>
    {
        protected AbstractRomanToArabicConverter(string parameters) : base(parameters)
        {
        }
    }
}
