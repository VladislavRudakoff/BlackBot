using FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults;

/// <summary>
/// Ссылка на статью или веб-страницу.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="Title">Название результата.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое необходимо отправить.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура, прикрепленная к сообщению.</param>
/// <param name="Url">URL-адрес.</param>
/// <param name="HideUrl">True - если требуется скрыть URL-адрес.</param>
/// <param name="Description">Краткое описание.</param>
/// <param name="ThumbUrl">Миниатюра URL.</param>
/// <param name="ThumbWidth">Ширина миниатюры.</param>
/// <param name="ThumbHeight">Высота миниатюры.</param>
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
    protected override InlineQueryResultType Type => InlineQueryResultType.Article;
}