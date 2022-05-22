namespace Bot.Data.Models.Commands;

/// <summary>
/// Область, к которой применяются команды бота.
/// </summary>
public abstract record BotCommandScope()
{
    /// <summary>
    /// Тип области.
    /// </summary>
    protected abstract string Type { get; init; }
}