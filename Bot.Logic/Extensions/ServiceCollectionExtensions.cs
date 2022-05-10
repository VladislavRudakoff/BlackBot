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
    /// <param name="service"><see cref="IServiceCollection"/>.</param>
    /// <returns></returns>
    public static IServiceCollection AddServices(this IServiceCollection service) =>
        service
            .AddScoped<IUserProvider, UserProvider>()
            .AddScoped<ITextDecorator, TextDecorator>();

    /// <summary>
    /// Регистрирует кэш.
    /// </summary>
    /// <param name="service"><see cref="IServiceCollection"/>.</param>
    /// <param name="config"><see cref="IConfiguration"/>.</param>
    /// <returns></returns>
    public static IServiceCollection AddCache(this IServiceCollection service, IConfiguration config) =>
        service
            .AddStackExchangeRedisCache(options =>
            {
                options.Configuration = config.GetConnectionString("Redis");
                options.InstanceName = "BotApp.";
            });

    /// <summary>
    /// Регистрирует все фабрики.
    /// </summary>
    /// <param name="service"><see cref="IServiceCollection"/>.</param>
    /// <returns></returns>
    public static IServiceCollection AddFactories(this IServiceCollection service) =>
        service
            .AddScoped<ICachingPolicyFactory, CachingPolicyFactory>();

    /// <summary>
    /// Регистрирует все настройки.
    /// </summary>
    /// <param name="service"><see cref="IServiceCollection"/>.</param>
    /// <param name="config"><see cref="IConfiguration"/>.</param>
    /// <returns></returns>
    public static IServiceCollection AddSettings(this IServiceCollection service, IConfiguration config) => 
        service.AddConfigAsSingleton<CachingSettings>(config);
}