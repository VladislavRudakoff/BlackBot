using FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults.InlineQueryResultCached;

/// <summary>
/// 
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="VoiceFileId">Идентификатор голосового сообщения.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Caption">Подпись отправляемого файла(0-1024 символа).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Специальные сущности в заголовке.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо голосовой записи.</param>
public record InlineQueryResultCachedVoice(
    string Id,
    string VoiceFileId,
    string Title,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Voice;
}