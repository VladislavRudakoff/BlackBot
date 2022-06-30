using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.Events.Common.Interfaces;

namespace Telegram.Contracts.Events.Common.Files.Location;

/// <summary>
/// Модель для отправки местоположения.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Latitude">Широта.</param>
/// <param name="Longitude">Долгота.</param>
/// <param name="HorizontalAccuracy">Радиус неопределенности местоположения(0-1500м)</param>
/// <param name="LivePeriod">Время, в течении которого происходит трансляция местоположения(60-86400мин).</param>
/// <param name="Heading">Для "живых" местоположений - направление в котором движется пользователь(1-360°).</param>
/// <param name="ProximityAlertRadius">Для "живых" местоположений - указывает на каком расстоянии будет приходить оповещение о приближении к пользователю(1-100000м).</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendLocation(
    ChatId ChatId,
    double Latitude,
    double Longitude,
    double? HorizontalAccuracy,
    int? LivePeriod,
    int? Heading,
    int? ProximityAlertRadius,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;