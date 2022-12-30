namespace FluentBot.Domain.UseCases.Events.Chats.Stickers;

/// <summary>
/// Модель для удаления стикера из набора.
/// </summary>
/// <param name="Sticker">Идентификатор стикера.</param>
public record DeleteStickerFromSet(
    string Sticker)
    : IEventEntity;