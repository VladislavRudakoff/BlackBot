namespace FluentBot.Domain.UseCases.Events.Chats.Stickers;

/// <summary>
/// Модель для перемещения стикера в наборе.
/// </summary>
/// <param name="Sticker">Идентификатор стикера.</param>
/// <param name="Position">Новая позиция стикера в наборе(отсчитываемая от 0).</param>
public record SetStickerPositionInSet(
    string Sticker,
    int Position)
    : IEventEntity;