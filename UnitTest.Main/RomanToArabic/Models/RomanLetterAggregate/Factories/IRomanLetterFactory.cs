namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factories
{
    public interface IRomanLetterFactory
    {
        IRomanLetter Create(char character);
    }
}