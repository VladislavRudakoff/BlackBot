namespace FluentBot.Domain.UseCases.Events.Chats.Stickers;

/// <summary>
/// Модель для создания коллекции стикеров.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="StickerSetName">Названия набора стикеров.</param>
public record SetChatStickerSet(
    ChatId ChatId,
    string StickerSetName)
    : IEventEntity;