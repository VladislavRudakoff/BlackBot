namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для удаления фотографии чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record DeleteChatPhoto(
    ChatId ChatId)
    : IEventEntity;