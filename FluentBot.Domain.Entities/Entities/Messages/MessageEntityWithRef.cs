namespace FluentBot.Domain.Entities.Entities.Messages;

/// <summary>
/// Сущность - ссылка.
/// </summary>
/// <param name="Type">Тип сущности.</param>
/// <param name="Offset">Смещение в единицах UTF-16 до начала объекта.</param>
/// <param name="Length">Длина объекта в UTF-16.</param>
/// <param name="Url">URL-адрес.</param>
public record MessageEntityWithRef(
    string Type,
    int Offset,
    int Length,
    string? Url)
    : MessageEntity(Type, Offset, Length);