using Bot.Data.Settings;
using Bot.Logic.Providers;
using Bot.Logic.Providers.Interfaces;
using Bot.Logic.Services;
using Bot.Logic.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.Logic.Extensions;

/// <summary>
/// Класс с методами расширений для <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует все сервисы бота.
    /// </summary>
    /// <param name="service"></param>
    /// <returns></returns>
    public static IServiceCollection AddServices(this IServiceCollection service) =>
        service
            .AddScoped<IRoleProvider, RoleProvider>()
            .AddScoped<IUserProvider, UserProvider>()
            .AddScoped<ITextDecorator, TextDecorator>();

    public static IServiceCollection AddFactories(this IServiceCollection service) =>
        service
            .AddScoped<ICachingPolicyFactory, CachingPolicyFactory>();

    public static IServiceCollection AddSettings(this IServiceCollection service, IConfiguration config) =>
        service
            .AddConfigAsSingleton<CachingSettings>(config);
}