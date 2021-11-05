using System;

namespace UnitTest.RomanToArabic.Services.Factories
{
    public class ServiceFactory : IServiceFactory
    {
        private static ServiceFactory _instance;

        private ServiceFactory()
        {
        }

        public static ServiceFactory Instance => _instance ??= new ServiceFactory();

        public T Create<T, P>(P constructorParameter) where T : AbstractService<P>
        {
            return (T) Activator.CreateInstance(typeof(T), constructorParameter);
        }

        public T Create<T>() where T : AbstractService
        {
            return (T) Activator.CreateInstance(typeof(T));
        }
    }
}
