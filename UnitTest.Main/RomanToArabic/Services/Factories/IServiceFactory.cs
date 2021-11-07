using System.ComponentModel.DataAnnotations;

namespace UnitTest.RomanToArabic.Services.Factories
{
    public interface IServiceFactory
    {
        T Create<T>(object constructorParameter) where T : AbstractService;
    }
}
