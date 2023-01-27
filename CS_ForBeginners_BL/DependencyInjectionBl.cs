using CS_ForBeginners_DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CS_ForBeginners_Bl
{
    public static class DependencyInjectionBl
    {
        private static readonly IServiceCollection ServiceCollection = new ServiceCollection();

        public static IServiceCollection AddBlDependencies()
        {
            ServiceCollection.AddAutoMapper(typeof(DependencyInjectionBl));
            ServiceCollection.AddSingleton<IPersonRepository, PersonRepository>();
            return ServiceCollection;
        }
    }
}
