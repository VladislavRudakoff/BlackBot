using System.Threading;
using System.Threading.Tasks;
using Telegram.Contracts.DTOs;

namespace Bot.Logic.Providers.Interfaces;

/// <summary>
/// Сервис для получения информации о боте.
/// </summary>
public interface ITelegramInfoProvider
{
    /// <summary>
    /// Возвращает информацию о боте.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="Task{TResult}"/>.</returns>
    Task<TelegramResponse<User>?> GetInfoAsync(CancellationToken cancellationToken = default);
}