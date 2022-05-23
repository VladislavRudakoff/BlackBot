namespace Telegram.Contracts.DTOs.Alerts;

/// <summary>
/// Этот объект представляет содержимое служебного сообщения, отправляемого всякий раз, когда в чате срабатывает предупреждение о приближении,
/// установленное другим пользователем.
/// </summary>
/// <param name="Traveler">Пользователь, вызвавший оповещение.</param>
/// <param name="Watcher">Пользователь, установивший оповещение.</param>
/// <param name="Distance">Расстояние между пользователями.</param>
public record ProximityAlertTriggered(
    UserDbo Traveler,
    UserDbo Watcher,
    int Distance);