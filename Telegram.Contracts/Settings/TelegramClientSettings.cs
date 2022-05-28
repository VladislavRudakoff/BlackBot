namespace Telegram.Contracts.Settings;

/// <summary>
/// Настройки http-клиента телеграма.
/// </summary>
public class TelegramClientSettings
{
    /// <summary>
    /// Базовый Url-адрес для запросов.
    /// </summary>
    public string BaseUrl { get; set; } = null!;

    /// <summary>
    /// Url-адрес бота.
    /// </summary>
    public string BotUrl { get; set; } = null!;

    /// <summary>
    /// Url-адрес для настройки Webhook.
    /// </summary>
    public string WebHookUrl { get; set; } = null!;

    /// <summary>
    /// Токен бота.
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// Имя бота.
    /// </summary>
    public string BotName { get; set; } = null!;

    /// <summary>
    /// Юзернейм бота.
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// Таймаут запросов.
    /// </summary>
    public TimeSpan TimeOut { get; set; }

    /// <summary>
    /// Передаваемые аргументы.
    /// </summary>
    public string? BaseArgs { get; set; } = null!;
}