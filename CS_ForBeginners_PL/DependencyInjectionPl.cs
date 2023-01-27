using CS_ForBeginners_Bl;
using CS_ForBeginners_BL.Managers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CS_ForBeginners_Pl
{
    public static class DependencyInjectionPl
    {
        public static readonly IServiceCollection ServiceCollection = new ServiceCollection();

        public static IServiceCollection AddDependencies()
        {
            ServiceCollection.AddSingleton<IPersonManager, PersonManager>();
            ServiceCollection.TryAdd(DependencyInjectionBl.AddBlDependencies());
            return ServiceCollection;
        }
    }
}
