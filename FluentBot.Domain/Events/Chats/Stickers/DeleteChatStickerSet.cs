namespace FluentBot.Domain.UseCases.Events.Chats.Stickers;

/// <summary>
/// Модель для удаления набора стикеров.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record DeleteChatStickerSet(
    ChatId ChatId)
    : IEventEntity;