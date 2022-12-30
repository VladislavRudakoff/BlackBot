namespace FluentBot.Domain.UseCases.Events.Chats.Stickers;

/// <summary>
/// Модель для получения набора стикеров.
/// </summary>
/// <param name="Name">Название набора стикеров.</param>
public record GetStickerSet(
    string Name)
    : IEventEntity;