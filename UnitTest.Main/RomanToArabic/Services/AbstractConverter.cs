namespace UnitTest.RomanToArabic.Services
{
    public abstract class AbstractConverter<T, R> : AbstractService
    {
        public abstract R Convert();

        protected AbstractConverter(T parameters) : base(parameters)
        {
        }
    }
}
