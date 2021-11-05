using System.ComponentModel.DataAnnotations;

namespace UnitTest.RomanToArabic.Services.Factories
{
    public interface IServiceFactory
    {
        T Create<T, P>(P constructorParameter) where T : AbstractService<P>;
    }
}
