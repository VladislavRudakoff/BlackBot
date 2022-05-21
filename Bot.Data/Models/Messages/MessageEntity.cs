namespace Bot.Data.Models.Messages;

/// <summary>
/// Особая сущность в сообщении.
/// </summary>
/// <param name="Type">Тип сущности.</param>
/// <param name="Offset">Смещение в единицах UTF-16 до начала объекта.</param>
/// <param name="Length">Длина объекта в UTF-16.</param>
public record MessageEntity(
    string Type,
    int Offset,
    int Length);