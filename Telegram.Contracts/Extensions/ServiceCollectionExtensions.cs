using Bot.Common.Extensions;
using Telegram.Contracts.ApiClients;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterTelegramApiClient(this IServiceCollection services, IConfiguration config, TelegramClientSettings settings)
    {
        TelegramClientSettings clientSettings = config.BindConfig<TelegramClientSettings>();

        services.AddHttpClient<ITelegramClient, TelegramClient>(
            "TelegramBot",
            b =>
            {
                b.BaseAddress = new(clientSettings.BaseUrl);
                b.Timeout = clientSettings.TimeOut;
            });

        return services;
    }

    public static IServiceCollection RegisterSettings(this IServiceCollection services, IConfiguration config) => 
        services.AddConfigAsSingleton<TelegramClientSettings>(config);
}