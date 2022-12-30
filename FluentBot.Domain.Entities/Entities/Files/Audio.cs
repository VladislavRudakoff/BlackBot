namespace FluentBot.Domain.Entities.Entities.Files;

/// <summary>
/// Аудио(музыка).
/// </summary>
/// <param name="FileId">Идентификатор файла, который может быть использован для загрузки или повторного использования файла.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
/// <param name="Duration">Продолжительность, в секундах.</param>
/// <param name="Performer">Исполнитель. Определённый отправителем или аудиотегами.</param>
/// <param name="Title">Название аудио.</param>
/// <param name="FileName">Оригинальное имя аудио.</param>
/// <param name="MimeType">Медиа тип.</param>
/// <param name="FileSize">Размер файла в байтах.</param>
/// <param name="Thumb">Миниатюра обложки альбома.</param>
public record Audio(
    string FileId,
    string FileUniqueId,
    int Duration,
    string? Performer,
    string? Title,
    string? FileName,
    string? MimeType,
    int? FileSize,
    PhotoSize? Thumb)
    : File(FileId, FileUniqueId);