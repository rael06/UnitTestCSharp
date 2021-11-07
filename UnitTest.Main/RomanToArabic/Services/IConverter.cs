namespace UnitTest.RomanToArabic.Services
{
    public interface IConverter<in P, out R> : IService
    {
        public R Convert();
        public IConverter<P, R> Init(P parameter);
    }
}
