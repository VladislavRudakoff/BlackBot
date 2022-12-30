namespace FluentBot.Domain.UseCases.Events.Common.Files.Location;

/// <summary>
/// Модель для отправки информации о месте проведения.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Latitude">Широта.</param>
/// <param name="Longitude">Долгота.</param>
/// <param name="Title">Название места проведения.</param>
/// <param name="Address">Адрес места проведения.</param>
/// <param name="FoursquareId">Идентификатор Foursquare места проведения.</param>
/// <param name="FoursquareType">Тип заведения Foursquare(если известен).</param>
/// <param name="GooglePlaceId">Идентификатор места проведения в Google Places.</param>
/// <param name="GooglePlaceType">Тип заведения в Google Places.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendVenue(
    ChatId ChatId,
    double Latitude,
    double Longitude,
    string Title,
    string Address,
    string? FoursquareId,
    string? FoursquareType,
    string? GooglePlaceId,
    string? GooglePlaceType,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;