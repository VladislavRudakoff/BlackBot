using Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.Enums;

namespace Telegram.Contracts.DTOs.InlineMode.InlineQueryResults;

/// <summary>
/// Ссылка на статью или веб-страницу.
/// </summary>
/// <param name="Id"></param>
/// <param name="Title"></param>
/// <param name="InputMessageContent"></param>
/// <param name="ReplyMarkup"></param>
/// <param name="Url"></param>
/// <param name="HideUrl"></param>
/// <param name="Description"></param>
/// <param name="ThumbUrl"></param>
/// <param name="ThumbWidth"></param>
/// <param name="ThumbHeight"></param>
public record InlineQueryResultArticle(
    string Id,
    string Title,
    InputMessageContent InputMessageContent,
    InlineKeyboardMarkup? ReplyMarkup,
    string? Url,
    bool? HideUrl,
    string? Description,
    string? ThumbUrl,
    int? ThumbWidth,
    int? ThumbHeight)
    : InlineQueryResult(Id)
{
    /// <summary>
    /// Тип результата.
    /// </summary>
    protected override InlineQueryResultType Type => InlineQueryResultType.Article;
}