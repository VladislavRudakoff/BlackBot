using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Webhook.Commands;

/// <summary>
/// Модель для удаления интеграции с webhook.
/// </summary>
/// <param name="DropPendingUpdates">True - чтобы удалить все ожидающие обновления.</param>
public record DeleteWebhook(
    bool? DropPendingUpdates)
    : IEventEntity;