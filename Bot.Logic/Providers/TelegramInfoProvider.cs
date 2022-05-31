using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Providers.Interfaces;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;

namespace Bot.Logic.Providers;

/// <inheritdoc cref="ITelegramInfoProvider"/>
public class TelegramInfoProvider : ITelegramInfoProvider
{
    private readonly ITelegramClient telegramClient;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="telegramClient"><see cref="ITelegramClient"/>.</param>
    public TelegramInfoProvider(ITelegramClient telegramClient)
    {
        this.telegramClient = telegramClient;
    }

    /// <inheritdoc />
    public Task<TelegramResponse<User>?> GetInfoAsync(CancellationToken cancellationToken = default) => 
        telegramClient.GetBotInfoAsync(cancellationToken);
}