namespace Telegram.Contracts.DTOs.Commands;

/// <summary>
/// Область, к которой применяются команды бота.
/// </summary>
public abstract record BotCommandScope()
{
    /// <summary>
    /// Тип области.
    /// </summary>
    public abstract string Type { get; init; }
}