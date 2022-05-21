using System;
using System.Text.Json.Serialization;
using Bot.Contracts.Services;

namespace Bot.Contracts.DTOs.Enums;

/// <summary>
/// Dto перечисление ролей.
/// </summary>
[JsonConverter(typeof(FlagConverter))]
[Flags]
public enum RolesDto
{
    /// <summary>
    /// Не определено.
    /// </summary>
    None = 0 << 0,

    /// <summary>
    /// Пользователь.
    /// </summary>
    User = 1 << 0,

    /// <summary>
    /// Модератор.
    /// </summary>
    Moderator = 1 << 1,

    /// <summary>
    /// Админ.
    /// </summary>
    Admin = 1 << 2
}