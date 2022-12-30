namespace FluentBot.Domain.UseCases.Events.Common.Messages;

/// <summary>
/// Модель для пересылки сообщения.
/// </summary>
/// <param name="ChatId">Идентификатор чата, в который нужно переслать сообщение.</param>
/// <param name="FromChatId">Идентификатор чата, в который было отправлено исходное сообщение.</param>
/// <param name="MessageId">Идентификатор сообщения.</param>
/// <param name="DisableNotification">Сообщение без уведомления.</param>
/// <param name="ProtectedContent">Запрет на пересылку и сохранение сообщения.</param>
public record ForwardMessage(
    ChatId ChatId,
    ChatId FromChatId,
    int MessageId,
    bool? DisableNotification,
    bool? ProtectedContent)
    : IEventEntity;