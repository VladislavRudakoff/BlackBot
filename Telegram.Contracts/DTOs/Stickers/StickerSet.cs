using Telegram.Contracts.DTOs.Files;

namespace Telegram.Contracts.DTOs.Stickers;

/// <summary>
/// Набор стикеров.
/// </summary>
/// <param name="Name">Название набора.</param>
/// <param name="Title">Заголовок набора.</param>
/// <param name="IsAnimated">True - если набор содержит анимированные стикеры.</param>
/// <param name="IsVideo">True - если набор содержит видеостикеры.</param>
/// <param name="ContainsMasks">True - если набор содержит маски.</param>
/// <param name="Stickers">Список всех стикеров в наборе.</param>
/// <param name="Thumb">Миниатюра набора(в форматах: .WEBP, .TGS или .WEBM).</param>
public record StickerSet(
    string Name,
    string Title,
    bool IsAnimated,
    bool IsVideo,
    bool ContainsMasks,
    IEnumerable<Sticker> Stickers,
    PhotoSize? Thumb);