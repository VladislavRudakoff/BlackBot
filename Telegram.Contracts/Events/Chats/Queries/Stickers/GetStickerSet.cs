using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Queries.Stickers;

/// <summary>
/// Модель для получения набора стикеров.
/// </summary>
/// <param name="Name">Название набора стикеров.</param>
public record GetStickerSet(
    string Name)
    : IEventEntity;