using Bot.Common.Extensions;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

public class TelegramClient: ITelegramClient
{
    private readonly HttpClient httpClient;
    private readonly TelegramClientSettings telegramClientSettings;

    private readonly string BaseBotUrl;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    public TelegramClient(HttpClient httpClient, TelegramClientSettings telegramClientSettings)
    {
        this.httpClient = httpClient;
        this.telegramClientSettings = telegramClientSettings;

        BaseBotUrl = telegramClientSettings.BaseUrl + telegramClientSettings.Token;
    }

    public async Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default) => 
        await httpClient.GetAsJsonAsync<TelegramResponse<User>>(BaseBotUrl + "/getMe", cancellationToken);
}