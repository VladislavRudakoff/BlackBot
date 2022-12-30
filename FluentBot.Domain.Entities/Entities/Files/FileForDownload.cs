namespace FluentBot.Domain.Entities.Entities.Files;

/// <summary>
/// Файл готовый к загрузке.
/// </summary>
/// <param name="FileId">Идентификатор файла для загрузки или повторного использования.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
/// <param name="FileSize">Размер файла в байтах.</param>
/// <param name="FilePath">Путь к файлу.</param>
public record FileForDownload(
    string FileId,
    string FileUniqueId,
    long? FileSize,
    string? FilePath)
    : File(FileId, FileUniqueId);