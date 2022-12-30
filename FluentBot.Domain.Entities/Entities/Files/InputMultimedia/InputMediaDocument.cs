namespace FluentBot.Domain.Entities.Entities.Files.InputMultimedia;

/// <summary>
/// Общий файл для отправки.
/// </summary>
/// <param name="Media">Файл для отправки.</param>
/// <param name="Thumb">Миниатюра отправленного файла. <i>Можно игнорировать, если генерация миниатюр для файла поддерживается на стороне сервера.</i></param>
/// <param name="Caption">Заголовок отправляемого документа(от 0 до 1024 символов).</param>
/// <param name="ParseMode">?????????Режим разбора сущностей в заголовке документа?????????</param>
/// <param name="CaptionEntities">Список специальных сущностей в заголовке, которые можно указать вместо ParseMode.</param>
/// <param name="DisableContentTypeDetection">Отключает автоматическое определение типа контента на стороне сервера для файлов, загруженных с помощью multipart/form-data.<br />
/// <i>Всегда True, если документ отправляется как часть альбома.</i></param>
public record InputMediaDocument(
    string Media,
    string? Thumb,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    bool? DisableContentTypeDetection)
    : InputMedia(Media, Caption, ParseMode, CaptionEntities)
{
    public override string Type => "document";
}