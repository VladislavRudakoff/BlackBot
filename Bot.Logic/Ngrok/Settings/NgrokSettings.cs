namespace Bot.Logic.Ngrok.Settings;

public class NgrokSettings
{
    /// <summary>
    /// Базовый Url-адрес для привязки webhook.
    /// </summary>
    public string WebhookUrl { get; set; } = null!;

    /// <summary>
    /// Url-адрес ngrok агента.
    /// </summary>
    public string NgrokAgentUrl { get; set; } = null!;

    /// <summary>
    /// Ngrok токен.
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// Текст команды.
    /// </summary>
    public string CmdText { get; set; } = null!;
}