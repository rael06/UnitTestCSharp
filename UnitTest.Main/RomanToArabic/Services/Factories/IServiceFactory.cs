using System.ComponentModel.DataAnnotations;

namespace UnitTest.RomanToArabic.Services.Factories
{
    public interface IServiceFactory
    {
        T Create<T>() where T : IService, new();
    }
}
