namespace FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

/// <summary>
/// Представляет содержимое сообщения о местоположении, которое должно быть отправлено в результате inline-запроса. 
/// </summary>
/// <param name="Latitude">Широта.</param>
/// <param name="Longitude">Долгота.</param>
/// <param name="HorizontalAccuracy">Радиус неопределенности местоположения(0-1500м).</param>
/// <param name="LivePeriod">Период в течении которого обновляется местоположение(от 60 до 86400).</param>
/// <param name="Heading">Направление, в котором движется пользователь(1-360°).</param>
/// <param name="ProximityAlertRadius">Максимальное расстояние для предупреждений о приближении к другому участнику(1-100000м).</param>
public record InputLocationMessageContent(
    double Latitude,
    double Longitude,
    double? HorizontalAccuracy,
    int? LivePeriod,
    int? Heading,
    int? ProximityAlertRadius)
    : InputMessageContent;