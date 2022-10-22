using Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Enums;

namespace Telegram.Contracts.DTOs.InlineMode.InlineQueryResults.InlineQueryResultCached;

/// <summary>
/// Представляет собой ссылку на фотографию, хранящуюся на серверах Telegram.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="PhotoFileId">Идентификатор фотографии.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Description">Краткое описание.</param>
/// <param name="Caption">Подпись к отправляемой фотографии(0-1024 символа).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Специальные сущности в заголовке.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо фотографии.</param>
public record InlineQueryResultCachedPhoto(
    string Id,
    string PhotoFileId,
    string? Title,
    string? Description,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Photo;
}