using Telegram.Contracts.DTOs;

namespace Telegram.Contracts.ApiClients.Interfaces;

/// <summary>
/// Клиент Telegram API.
/// </summary>
public interface ITelegramClient
{
    /// <summary>
    /// Возвращает информацию о боте.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="Task{TResult}"/>.</returns>
    Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default);
}