using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Stickers;

/// <summary>
/// Модель для установки миниатюры набора наклеек. 
/// </summary>
/// <param name="Name">Название набора стикеров.</param>
/// <param name="UserId">Идентификатор владельца набора стикеров.</param>
/// <param name="Thumb">Статический стикер(PNG), анимированный стикер(TGS), видеостикер(WEBM).</param>
public record SetStickerSetThumb(
    string Name,
    long UserId,
    string? Thumb)
    : IEventEntity;