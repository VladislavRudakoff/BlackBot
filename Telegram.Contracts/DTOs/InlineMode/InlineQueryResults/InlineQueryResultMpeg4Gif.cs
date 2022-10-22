using Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Enums;

namespace Telegram.Contracts.DTOs.InlineMode.InlineQueryResults;

/// <summary>
/// Представляет ссылку на видео-анимацию (видео H.264/MPEG-4 AVC без звука).
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="Mpeg4Url">Действительный URL-адрес для файла MPEG4. Размер файла не должен превышать 1 МБ.</param>
/// <param name="ThumbUrl">URL статической (JPEG или GIF) или анимированной (MPEG4) миниатюры.</param>
/// <param name="Mpeg4Width">Ширина видео.</param>
/// <param name="Mpeg4Height">Высота видео.</param>
/// <param name="Mpeg4Duration">Длительность видео в секундах.</param>
/// <param name="ThumbMimeType">MIME-тип миниатюры.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Caption">Подпись отправляемого файла(0-1024 символа).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Специальные сущности в заголовке.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо видео-анимации.</param>
public record InlineQueryResultMpeg4Gif(
    string Id,
    string Mpeg4Url,
    string ThumbUrl,
    int? Mpeg4Width,
    int? Mpeg4Height,
    int? Mpeg4Duration,
    string? ThumbMimeType,
    string? Title,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.VideoAnimation;
}