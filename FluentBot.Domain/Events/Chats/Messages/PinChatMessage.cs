namespace FluentBot.Domain.UseCases.Events.Chats.Messages;

/// <summary>
/// Модель для добавления сообщения в список закрепленных.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="MessageId">Идентификатор закрепляемого сообщения.</param>
/// <param name="DisableNotification">True - если не требуется оповещать участников чата о новом закрепленном сообщении(в каналах и приватных чатах всегда False).</param>
public record PinChatMessage(
    ChatId ChatId,
    int MessageId,
    bool? DisableNotification)
    : IEventEntity;