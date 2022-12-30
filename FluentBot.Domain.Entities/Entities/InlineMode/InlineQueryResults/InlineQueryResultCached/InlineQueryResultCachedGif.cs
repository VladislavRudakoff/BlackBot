using FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults.InlineQueryResultCached;

/// <summary>
/// Представляет ссылку на анимацию, хранящийся на серверах Telegram.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="GifFileId">Идентификатор анимации.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Caption">Подпись отправляемого файла(0-1024 символа).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Специальные сущности в заголовке.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо анимации.</param>
public record InlineQueryResultCachedGif(
    string Id,
    string GifFileId,
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