using System.Threading;
using System.Threading.Tasks;

namespace Bot.Logic.Dispatchers.Interfaces;

public interface IWebhookDispatcher
{
    /// <summary>
    /// Обрабатывает входящее обновление.
    /// </summary>
    /// <param name="update">Входящее обновление.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="Task"/>.</returns>
    public Task HandleAsync(IncomingUpdate update, CancellationToken cancellationToken = default);
}