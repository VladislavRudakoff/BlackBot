using System;
using System.Collections.Generic;

namespace Bot.Data.Settings;

/// <summary>
/// Настройки Telegram бота.
/// </summary>
public class TelegramClientSettings
{
    /// <summary>
    /// Базовый Url для запросов.
    /// </summary>
    public string BaseUrl { get; set; } = null!;

    /// <summary>
    /// Url бота.
    /// </summary>
    public string? BotUrl { get; set; } = null!;

    /// <summary>
    /// Url для Вебхука.
    /// </summary>
    public string WebHookUrl { get; set; } = null!;

    /// <summary>
    /// Имя бота.
    /// </summary>
    public string? BotName { get; set; }

    /// <summary>
    /// Токен бота.
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// Тайм-аут подключения.
    /// </summary>
    public TimeSpan TimeOut { get; set; }

    /// <summary>
    /// Коллекция аргументов.
    /// </summary>
    public IEnumerable<string?> BaseArgs { get; set; } = new List<string?>();
}