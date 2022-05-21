namespace Bot.Data.Models.Locations;

/// <summary>
/// Местонахождение.
/// </summary>
/// <param name="Longitude">Долгота.</param>
/// <param name="Latitude">Широта.</param>
/// <param name="HorizontalAccuracy">Радиус <i>разброса</i> местоположения, в метрах(от 0 до 1500).</param>
/// <param name="LivePeriod">Время относительно даты отправки сообщения, в течение которого местоположение может быть обновлено, в секундах.</param>
/// <param name="Heading">Направление, в котором движется пользователь, в градусах(от 1 до 360).</param>
/// <param name="ProximityAlertRadius">Максимальное расстояние для предупреждений о приближении к другому участнику чата, в метрах.</param>
public record Location(
    double Longitude,
    double Latitude,
    float? HorizontalAccuracy,
    int? LivePeriod,
    int? Heading,
    int? ProximityAlertRadius);