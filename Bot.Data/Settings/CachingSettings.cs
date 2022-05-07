using System;

namespace Bot.Data.Settings;

/// <summary>
/// Настройки кэширования.
/// </summary>
public class CachingSettings
{
    /// <summary>
    /// Время жизни кэша.
    /// </summary>
    public TimeSpan CacheTtl { get; set; }
}