namespace Bot.Data.Models.Messages;

/// <summary>
/// Сущность - код.
/// </summary>
/// <param name="Type">Тип сущности.</param>
/// <param name="Offset">Смещение в единицах UTF-16 до начала объекта.</param>
/// <param name="Length">Длина объекта в UTF-16.</param>
/// <param name="Language">Язык программирования.</param>
public record MessageEntityWithCode(
    string Type,
    int Offset,
    int Length,
    string? Language)
    : MessageEntity(Type, Offset, Length);