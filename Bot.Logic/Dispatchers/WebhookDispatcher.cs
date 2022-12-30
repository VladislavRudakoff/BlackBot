using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Dispatchers.Interfaces;

namespace Bot.Logic.Dispatchers;

public class WebhookDispatcher : IWebhookDispatcher
{
    //TODO: Дописать. Пока заглушка.
    /// <inheritdoc />
    public Task HandleAsync(IncomingUpdate update, CancellationToken cancellationToken = default)
    {
        var handler = update.Type switch
        {
            IncomingUpdateType.CallbackQuery => "Handler1",
            _ => "default"
        };

        return Task.CompletedTask;
    }
}