using Bot.Common.Extensions;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.Events.Interfaces;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

public abstract class BaseTelegramClient
{
    private protected readonly HttpClient HttpClient;
    private protected readonly TelegramClientSettings TelegramClientSettings;

    private protected readonly string BaseBotUrl;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    private protected BaseTelegramClient(
        HttpClient httpClient,
        TelegramClientSettings telegramClientSettings)
    {
        HttpClient = httpClient;
        TelegramClientSettings = telegramClientSettings;

        BaseBotUrl = telegramClientSettings.BaseUrl + telegramClientSettings.Token;
    }

    private protected async Task<TelegramResponse<TU>?> ExecuteCommand<T, TU>(
        T commandModel,
        string command,
        CancellationToken cancellationToken = default)
        where T : IEventEntity =>
        await HttpClient.PostAsJsonAsync<TelegramResponse<TU>?>(
            BaseBotUrl + command,
            commandModel,
            cancellationToken);
}