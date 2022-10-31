using Bot.WebApi.HostedServices;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.WebApi.Extensions;

/// <summary>
/// Класс с методами расширений для <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует все сервисы WebAPI слоя.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/>.</param>
    /// <returns><see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddWebApiServices(this IServiceCollection services) =>
        services.AddHostedService<HostedService>();
}