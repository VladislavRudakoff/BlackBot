using Bot.Common.Extensions;
using Bot.Data.Settings;
using Bot.Logic.Providers;
using Bot.Logic.Providers.Interfaces;
using Bot.Logic.Services;
using Bot.Logic.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Contracts.Settings;

namespace Bot.Logic.Extensions;

/// <summary>
/// Класс с методами расширений для <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует все сервисы слоя логики.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    /// <param name="config"><see cref="IConfiguration"/>.</param>
    /// <returns></returns>
    public static IServiceCollection AddLogicServices(this IServiceCollection services, IConfiguration config) =>
        services
            .AddProviders()
            .AddCache(config)
            .AddFactories()
            .AddSettings(config);

    /// <summary>
    /// Регистрирует сервисы слоя логики.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    /// <returns></returns>
    private static IServiceCollection AddProviders(this IServiceCollection services) =>
        services
            .AddScoped<IUserProvider, UserProvider>()
            .AddScoped<ITelegramInfoProvider, TelegramInfoProvider>();

    /// <summary>
    /// Регистрирует кэш.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    /// <param name="config"><see cref="IConfiguration"/>.</param>
    /// <returns></returns>
    private static IServiceCollection AddCache(this IServiceCollection services, IConfiguration config) =>
        services
            .AddStackExchangeRedisCache(options =>
            {
                options.Configuration = config.GetConnectionString("Redis");
                options.InstanceName = "BotApp.";
            });

    /// <summary>
    /// Регистрирует фабрики слоя логики.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    /// <returns></returns>
    private static IServiceCollection AddFactories(this IServiceCollection services) =>
        services
            .AddScoped<ICachingPolicyFactory, CachingPolicyFactory>();

    /// <summary>
    /// Регистрирует настройки слоя логики.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    /// <param name="config"><see cref="IConfiguration"/>.</param>
    /// <returns></returns>
    private static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration config) =>
        services
            .AddConfigAsSingleton<CachingSettings>(config)
            .AddConfigAsSingleton<TelegramClientSettings>(config);
}