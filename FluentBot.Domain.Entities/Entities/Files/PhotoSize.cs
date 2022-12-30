namespace FluentBot.Domain.Entities.Entities.Files;

/// <summary>
/// Фотография или файл/стикер одного размера.
/// </summary>
/// <param name="FileId">Идентификатор файла, который может быть использован для загрузки или повторного использования файла.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
/// <param name="Width">Ширина фото.</param>
/// <param name="Height">Высота фото.</param>
/// <param name="FileSize">Размер файла в байтах.</param>
public record PhotoSize(
    string FileId,
    string FileUniqueId,
    int Width,
    int Height,
    int? FileSize)
    : File(FileId, FileUniqueId);