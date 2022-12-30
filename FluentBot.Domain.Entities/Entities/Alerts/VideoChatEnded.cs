namespace FluentBot.Domain.Entities.Entities.Alerts;

/// <summary>
/// Служебное сообщение о завершении видеочата.
/// </summary>
/// <param name="Duration">Продолжительность, в секундах.</param>
public record VideoChatEnded(
    int Duration);