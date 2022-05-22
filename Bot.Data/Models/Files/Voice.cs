namespace Bot.Data.Models.Files;

/// <summary>
/// Голосовое-сообщение.
/// </summary>
/// <param name="FileId">Идентификатор файла, который может быть использован для загрузки или повторного использования файла.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
/// <param name="Duration">Длительность, в секундах.</param>
/// <param name="MimeType">Медиа тип.</param>
/// <param name="FileSize">Размер файла в байтах.</param>
public record Voice(
    string FileId,
    string FileUniqueId,
    int Duration,
    string? MimeType,
    int? FileSize)
    : File(FileId, FileUniqueId);