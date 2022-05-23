namespace Telegram.Contracts.DTOs.Alerts;

/// <summary>
/// Служебное сообщение о запланированном видеочате.
/// </summary>
/// <param name="StartDate">Момент времени (временная метка Unix), когда видеочат должен быть запущен администратором чата.</param>
public record VideoChatScheduled(
    int StartDate);