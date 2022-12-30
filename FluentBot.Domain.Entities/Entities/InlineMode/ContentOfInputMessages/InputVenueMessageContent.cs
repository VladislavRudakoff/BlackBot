namespace FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

/// <summary>
/// Представляет содержимое сообщения о месте проведения, которое должно быть отправлено в результате inline-запроса.
/// </summary>
/// <param name="Latitude">Широта.</param>
/// <param name="Longitude">Долгота.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Address">Адрес места проведения.</param>
/// <param name="FoursquareId">Идентификатор места проведения Foursquare(если он известен).</param>
/// <param name="FoursquareType">Тип заведения Foursquare(если известен).</param>
/// <param name="GooglePlaceId">Идентификатор места проведения в Google Places.</param>
/// <param name="GooglePlaceType">Тип заведения в Google Places.</param>
public record InputVenueMessageContent(
    double Latitude,
    double Longitude,
    string Title,
    string Address,
    string? FoursquareId,
    string? FoursquareType,
    string? GooglePlaceId,
    string? GooglePlaceType)
    : InputMessageContent;