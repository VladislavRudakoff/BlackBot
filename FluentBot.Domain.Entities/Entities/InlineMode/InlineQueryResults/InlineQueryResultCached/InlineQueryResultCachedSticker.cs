using FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults.InlineQueryResultCached;

/// <summary>
/// Представляет собой ссылку на стикер, хранящийся на серверах Telegram.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="StickerFileId">Идентификатор файла стикера</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо стикера.</param>
public record InlineQueryResultCachedSticker(
    string Id,
    string StickerFileId,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Sticker;
}