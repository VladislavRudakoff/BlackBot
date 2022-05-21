namespace Bot.Data.Models.Files;

/// <summary>
/// Анимация(GIF или H.264/MPEG-4 AVC видео без звука).
/// </summary>
/// <param name="FileId">Идентификатор файла, который может быть использован для загрузки или повторного использования файла.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
/// <param name="Width">Ширина.</param>
/// <param name="Height">Высота.</param>
/// <param name="Duration">Продолжительность, в секундах.</param>
/// <param name="Thumb">Миниатюра анимации.</param>
/// <param name="FileName">Оригинальное имя анимации.</param>
/// <param name="MimeType">Медиа тип.</param>
/// <param name="FileSize">Размер файла в байтах.</param>
public record Animation(
    string FileId,
    string FileUniqueId,
    int Width,
    int Height,
    int Duration,
    PhotoSize? Thumb,
    string? FileName,
    string? MimeType,
    int? FileSize)
    : File(FileId, FileUniqueId);