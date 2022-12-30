using FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults;

/// <summary>
/// Представляет место проведения.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="Latitude">Широта места проведения в градусах.</param>
/// <param name="Longitude">Долгота места проведения в градусах.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Address">Адрес места проведения.</param>
/// <param name="FoursquareId">Идентификатор места проведения Foursquare(если он известен).</param>
/// <param name="FoursquareType">Тип заведения Foursquare(если известен).</param>
/// <param name="GooglePlaceId">Идентификатор места проведения в Google Places.</param>
/// <param name="GooglePlaceType">Тип заведения в Google Places.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо места проведения.</param>
/// <param name="ThumbUrl">URL миниатюры.</param>
/// <param name="ThumbWidth">Ширина миниатюры.</param>
/// <param name="ThumbHeight">Высота миниатюры.</param>
public record InlineQueryResultVenue(
    string Id,
    double Latitude,
    double Longitude,
    string Title,
    string Address,
    string? FoursquareId,
    string? FoursquareType,
    string? GooglePlaceId,
    string? GooglePlaceType,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent,
    string? ThumbUrl,
    string? ThumbWidth,
    string? ThumbHeight)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Venue; 
}