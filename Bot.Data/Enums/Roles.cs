﻿using System;

namespace Bot.Data.Enums;

/// <summary>
/// Роли.
/// </summary>
[Flags]
public enum Roles
{
    /// <summary>
    /// Без роли.
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