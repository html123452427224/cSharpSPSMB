using Microsoft.Extensions.DependencyInjection;

namespace Enemy;

public static class Registrations
{
    public static IServiceCollection AddDbDriver(this IServiceCollection services)
    {
        services.AddSingleton<DBDriver>( _ => new DBDriver(Helpers.ReadSecret("enter db password: ")) );
        return services;
    }
}