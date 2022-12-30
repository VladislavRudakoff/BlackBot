namespace FluentBot.Domain.Entities.Entities.Files.InputMultimedia;

/// <summary>
/// Аудиофайл для отправки(музыка).
/// </summary>
/// <param name="Media">Файл для отправки.</param>
/// <param name="Thumb">Миниатюра отправленного файла. <i>Можно игнорировать, если генерация миниатюр для файла поддерживается на стороне сервера.</i></param>
/// <param name="Caption">Заголовок отправляемого аудио(от 0 до 1024 символов).</param>
/// <param name="ParseMode">?????????Режим разбора сущностей в подписи к видео?????????</param>
/// <param name="CaptionEntities">Список специальных сущностей в заголовке, которые можно указать вместо ParseMode.</param>
/// <param name="Duration">Длительность звука в секундах.</param>
/// <param name="Performer">Исполнитель аудио.</param>
/// <param name="Title">Название аудио.</param>
public record InputMediaAudio(
    string Media,
    string? Thumb,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    int? Duration,
    string? Performer,
    string? Title)
    : InputMedia(Media, Caption, ParseMode, CaptionEntities)
{
    public override string Type => "audio";
}