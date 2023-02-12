using CS_ForBeginners_DAL.Helpers;
using CS_ForBeginners_DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CS_ForBeginners_Bl
{
    public static class DependencyInjectionBl
    {
        private static readonly IServiceCollection ServiceCollection = new ServiceCollection();

        public static IServiceCollection AddBlDependencies()
        {
            ServiceCollection.AddAutoMapper(typeof(DependencyInjectionBl));
            ServiceCollection.AddHttpClient<PersonService>(DalConstants.PersonApi,
                s => s.BaseAddress = new Uri("http://localhost:5000"));
            //ServiceCollection.AddSingleton<IPersonRepository, PersonRepository>();
            ServiceCollection.AddSingleton<IPersonRepository, PersonService>();
            return ServiceCollection;
        }
    }
}
