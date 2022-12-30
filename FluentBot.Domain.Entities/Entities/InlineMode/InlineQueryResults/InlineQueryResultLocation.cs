using FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults;

/// <summary>
/// Представляет местоположение на карте.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="Latitude">Широта местоположения в градусах.</param>
/// <param name="Longitude">Долгота местоположения в градусах.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="HorizontalAccuracy">Радиус неопределённости местоположения(0-1500м).</param>
/// <param name="LivePeriod">Время, в течении которого местоположение обновляется(должно быть между <b>60</b> и <b>86400c</b>).</param>
/// <param name="Heading">Направление, в котором движется пользователь(1-360°).</param>
/// <param name="ProximityAlertRadius">Расстояние для предупреждения о приближении к другому участнику чата(1-100000м).</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо местоположения.</param>
/// <param name="ThumbUrl">URL миниатюры.</param>
/// <param name="ThumbWidth">Ширина миниатюры.</param>
/// <param name="ThumbHeight">Высота миниатюры.</param>
public record InlineQueryResultLocation(
    string Id,
    double Latitude,
    double Longitude,
    string Title,
    double? HorizontalAccuracy,
    int? LivePeriod,
    int? Heading,
    int? ProximityAlertRadius,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent,
    string? ThumbUrl,
    string? ThumbWidth,
    string? ThumbHeight)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Location;
}