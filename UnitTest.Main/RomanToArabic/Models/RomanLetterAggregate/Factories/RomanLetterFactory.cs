namespace UnitTest.RomanToArabic.Models.RomanLetterAggregate.Factories
{
    public static class RomanLetterFactory
    {
        public static IRomanLetter Create(char character)
        {
            return (IRomanLetter) typeof(IRomanLetter).Assembly.CreateInstance(
                $"{typeof(IRomanLetter).Namespace}.RomanLetter{character}");
        }
    }
}
