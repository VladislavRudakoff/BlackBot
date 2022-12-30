namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для разблокировки чата канала в супергруппе или на канале. 
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="SenderChatId">Идентификатор целевого чата отправителя.</param>
public record UnbanChatSenderChat(
    ChatId ChatId,
    int SenderChatId)
    : IEventEntity;