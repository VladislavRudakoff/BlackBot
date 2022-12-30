namespace FluentBot.Domain.Entities.Entities.Files.InputMultimedia;

/// <summary>
/// Видео для отправки.
/// </summary>
/// <param name="Media">Файл для отправки.</param>
/// <param name="Thumb">Миниатюра отправленного файла. <i>Можно игнорировать, если генерация миниатюр для файла поддерживается на стороне сервера.</i></param>
/// <param name="Caption">Заголовок отправляемого видео(от 0 до 1024 символов).</param>
/// <param name="ParseMode">?????????Режим разбора сущностей в подписи к видео?????????</param>
/// <param name="CaptionEntities">Список специальных сущностей в заголовке, которые можно указать вместо ParseMode.</param>
/// <param name="Width">Ширина видео.</param>
/// <param name="Height">Высота видео.</param>
/// <param name="Duration">Длительность видео в секундах.</param>
/// <param name="SupportStreaming">True, если видео подходит для потоковой передачи.</param>
public record InputMediaVideo(
    string Media,
    string? Thumb,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    int? Width,
    int? Height,
    int? Duration,
    bool? SupportStreaming)
    : InputMedia(Media, Caption, ParseMode, CaptionEntities)
{
    public override string Type => "video";
}