using Telegram.Contracts.DTOs.Files;
using File = Telegram.Contracts.DTOs.Files.File;

namespace Telegram.Contracts.DTOs.Stickers;

/// <summary>
/// Стикер.
/// </summary>
/// <param name="FileId">Идентификатор файла. Для загрузки или повторного использования.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла. Невозможно использовать для загрузки или повторного использования файла.</param>
/// <param name="Width">Ширина стикера.</param>
/// <param name="Height">Высота стикера.</param>
/// <param name="IsAnimated">True - если стикер анимированный.</param>
/// <param name="IsVideo">True - если стикер является видеостикером.</param>
/// <param name="Thumb">Миниатюра стикера(в формате .WEBP или .JPG).</param>
/// <param name="Emoji">Смайлик связанный со стикером.</param>
/// <param name="SetName">Название набора стикеров, к которому относится данный стикер.</param>
/// <param name="PremiumAnimation">Премиум анимация стикера(только если стикер является премиумным).</param>
/// <param name="MaskPosition">Позиция маски(для стикеров масок).</param>
/// <param name="FileSize">Размер файла в байтах.</param>
public record Sticker(
    string FileId,
    string FileUniqueId,
    int Width,
    int Height,
    bool IsAnimated,
    bool IsVideo,
    PhotoSize? Thumb,
    string? Emoji,
    string? SetName,
    File? PremiumAnimation,
    MaskPosition? MaskPosition,
    int FileSize);