using Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Enums;

namespace Telegram.Contracts.DTOs.InlineMode.InlineQueryResults;

/// <summary>
/// Представляет ссылку на анимацию(Gif).
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="GifUrl">URL-адрес анимации. <i>Размер файла не должен превышать 1 МБ.</i></param>
/// <param name="ThumbUrl">URL статической (JPEG или GIF) или анимированной (MPEG4) миниатюры.</param>
/// <param name="GifWidth">Ширина анимации.</param>
/// <param name="GifHeight">Высота анимации.</param>
/// <param name="GifDuration">Продолжительность анимации в секундах.</param>
/// <param name="ThumbMimeType">MIME-тип миниатюры.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Caption">Подпись отправляемого файла(0-1024 символа).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Специальные сущности в заголовке.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо анимации.</param>
public record InlineQueryResultGif(
    string Id,
    string GifUrl,
    string ThumbUrl,
    int? GifWidth,
    int? GifHeight,
    int? GifDuration,
    string? ThumbMimeType,
    string? Title,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Gif;
}