namespace Bot.Data.Models.Alerts;

/// <summary>
/// Служебное сообщение о завершении видеочата.
/// </summary>
/// <param name="Duration">Продолжительность, в секундах.</param>
public record VideoChatEnded(
    int Duration);