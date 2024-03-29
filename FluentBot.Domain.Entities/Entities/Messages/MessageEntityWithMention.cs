﻿namespace FluentBot.Domain.Entities.Entities.Messages;

/// <summary>
/// Сущность - упоминание.
/// </summary>
/// <param name="Type">Тип сущности.</param>
/// <param name="Offset">Смещение в единицах UTF-16 до начала объекта.</param>
/// <param name="Length">Длина объекта в UTF-16.</param>
/// <param name="User">Указанный пользователь.</param>
public record MessageEntityWithMention(
    string Type,
    int Offset,
    int Length,
    User? User)
    : MessageEntity(Type, Offset, Length);