namespace FluentBot.Domain.Entities.Entities.Files;

/// <summary>
/// Обычный файл(не фото, голосовое сообщение или аудиофайл).
/// </summary>
/// <param name="FileId">Идентификатор файла, который может быть использован для загрузки или повторного использования файла.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
/// <param name="Thumb">Миниатюра документа.</param>
/// <param name="FileName">Оригинальное имя файла.</param>
/// <param name="MimeType">Медиа тип.</param>
/// <param name="FileSize">Размер файла в байтах.</param>
public record Document(
    string FileId,
    string FileUniqueId,
    PhotoSize? Thumb,
    string? FileName,
    string? MimeType,
    int? FileSize)
    : File(FileId, FileUniqueId);