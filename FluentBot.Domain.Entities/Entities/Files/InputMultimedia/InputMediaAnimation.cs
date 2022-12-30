namespace FluentBot.Domain.Entities.Entities.Files.InputMultimedia;

/// <summary>
/// Фото для отправки.
/// </summary>
/// <param name="Media">Файл для отправки.</param>
/// <param name="Caption">Заголовок отправляемой анимации(от 0 до 1024 символов).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Список специальных сущностей в заголовке, которые можно указать вместо ParseMode.</param>
/// <param name="Width">Ширина анимации.</param>
/// <param name="Height">Высота анимации.</param>
/// <param name="Duration">Длительность анимации в секундах.</param>
public record InputMediaAnimation(string Media,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    int? Width,
    int? Height,
    int? Duration)
    : InputMedia(Media, Caption, ParseMode, CaptionEntities)
{
    public override string Type => "animation";
}