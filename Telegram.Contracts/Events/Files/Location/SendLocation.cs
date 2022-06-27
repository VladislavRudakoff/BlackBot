using Telegram.Contracts.DTOs.Chats;

namespace Telegram.Contracts.Events.Files.Location;

public record SendLocation(
    ChatId ChatId,
    float Latitude,
    float Longitude,
    float? HorizontalAccuracy,
    int? LivePeriod,
    int? Heading,
    int? ProximityAlertRadius,
    );