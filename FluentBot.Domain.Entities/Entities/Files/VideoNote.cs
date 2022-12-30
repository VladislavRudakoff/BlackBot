namespace FluentBot.Domain.Entities.Entities.Files;

/// <summary>
/// Видео-сообщение.
/// </summary>
/// <param name="FileId">Идентификатор файла, который может быть использован для загрузки или повторного использования файла.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
/// <param name="Length">Диаметр видеосообщения.</param>
/// <param name="Duration">Длительность, в секундах.</param>
/// <param name="Thumb">Миниатюра видео.</param>
/// <param name="FileSize">Размер файла в байтах.</param>
public record VideoNote(
    string FileId,
    string FileUniqueId,
    int Length,
    int Duration,
    PhotoSize? Thumb,
    int? FileSize)
    : File(FileId, FileUniqueId);