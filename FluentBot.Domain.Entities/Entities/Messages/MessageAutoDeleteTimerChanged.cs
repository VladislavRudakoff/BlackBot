namespace FluentBot.Domain.Entities.Entities.Messages;

/// <summary>
/// Служебное сообщение об изменении настроек таймера автоудаления.
/// </summary>
/// <param name="MessageAutoDeleteTime">Новое время автоудаления сообщений в чате, в секундах.</param>
public record MessageAutoDeleteTimerChanged(
    int MessageAutoDeleteTime);