using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Common.Commands.Files.Location;

/// <summary>
/// Модель для редактирования сообщения о текущем местоположении.
/// </summary>
/// <param name="ChatId">Идентификатор чата(требуется, если не указан InlineMessageId).</param>
/// <param name="MessageId">Идентификатор сообщения для редактирования(требуется, если не указан InlineMessageId).</param>
/// <param name="InlineMessageId">Идентификатор встроенного сообщения(требуется, если не указаны ChatId и MessageId).</param>
/// <param name="Latitude">Широта.</param>
/// <param name="Longitude">Долгота.</param>
/// <param name="HorizontalAccuracy">Радиус неопределенности местоположения(0-1500м)</param>
/// <param name="Heading">Направление в котором движется пользователь(1-360°).</param>
/// <param name="ProximityAlertRadius">Указывает на каком расстоянии будет приходить оповещение о приближении к пользователю(1-100000м).</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record EditMessageLiveLocation(
    ChatId? ChatId,
    MessageIdentifier? MessageId,
    string? InlineMessageId,
    double Latitude,
    double Longitude,
    double? HorizontalAccuracy,
    int? Heading,
    int? ProximityAlertRadius,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;