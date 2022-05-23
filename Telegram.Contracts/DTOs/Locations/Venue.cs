namespace Telegram.Contracts.DTOs.Locations;

/// <summary>
/// Место проведения.
/// </summary>
/// <param name="Location">Локация проведения. <b>Не может быть активной локацией</b>.</param>
/// <param name="Title">Название места.</param>
/// <param name="Address">Адрес места проведения.</param>
/// <param name="FoursquareId">Идентификатор места проведения Foursquare.</param>
/// <param name="FoursquareType">Тип заведения в Foursquare.</param>
/// <param name="GooglePlaceId">Идентификатор места проведения в Google Places.</param>
/// <param name="GooglePlaceType">Тип заведения в Google Places.</param>
public record Venue(
    Location Location,
    string Title,
    string Address,
    string? FoursquareId,
    string? FoursquareType,
    string? GooglePlaceId,
    string? GooglePlaceType);