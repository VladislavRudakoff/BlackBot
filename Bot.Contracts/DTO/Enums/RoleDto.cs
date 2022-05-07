using System;

namespace Bot.Contracts.DTO.Enums;

/// <summary>
/// Dto перечисление ролей.
/// </summary>
[Flags]
public enum RoleDto
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