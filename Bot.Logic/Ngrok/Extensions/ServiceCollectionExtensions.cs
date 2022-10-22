using Bot.Common.Extensions;
using Bot.Logic.Ngrok.NgrokApi;
using Bot.Logic.Ngrok.NgrokApi.Interfaces;
using Bot.Logic.Ngrok.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.Logic.Ngrok.Extensions;

/// <summary>
/// Класс с методами расширений для <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNgrok(this IServiceCollection services, IConfiguration config, NgrokSettings settings) =>
        services
            .RegisterNgrokAgent(settings)
            .RegisterNgrokSettings(config);

    private static IServiceCollection RegisterNgrokSettings(this IServiceCollection services, IConfiguration config) =>
        services.AddConfigAsSingleton<NgrokSettings>(config);

    private static IServiceCollection RegisterNgrokAgent(this IServiceCollection services, NgrokSettings settings)
    {
        services.AddHttpClient<INgrokAgentApi, NgrokAgentApi>(
            "NgrokAgent",
            b =>
            {
                b.BaseAddress = new(settings.NgrokAgentUrl);
            });

        return services;
    }
}