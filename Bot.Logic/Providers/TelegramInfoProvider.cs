using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Providers.Interfaces;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;

namespace Bot.Logic.Providers;

/// <inheritdoc cref="ITelegramInfoProvider"/>
public class TelegramInfoProvider : ITelegramInfoProvider
{
    private readonly IBotTelegramClient botTelegramClient;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="botTelegramClient"><see cref="IBotTelegramClient"/>.</param>
    public TelegramInfoProvider(IBotTelegramClient botTelegramClient)
    {
        this.botTelegramClient = botTelegramClient;
    }

    /// <inheritdoc />
    public Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default) =>
        botTelegramClient.GetBotInfoAsync(cancellationToken);
}