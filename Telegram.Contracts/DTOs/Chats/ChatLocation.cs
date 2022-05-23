using Telegram.Contracts.DTOs.Locations;

namespace Telegram.Contracts.DTOs.Chats;

/// <summary>
/// Расположение, к которому подключен чат.
/// </summary>
/// <param name="Location">Местоположение, к которому подключена супергруппа.</param>
/// <param name="Address">Адрес местонахождения.</param>
public record ChatLocation(
    Location Location,
    string Address);