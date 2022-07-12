using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Stickers;

/// <summary>
/// Модель для удаления стикера из набора.
/// </summary>
/// <param name="Sticker">Идентификатор стикера.</param>
public record DeleteStickerFromSet(
    string Sticker)
    : IEventEntity;