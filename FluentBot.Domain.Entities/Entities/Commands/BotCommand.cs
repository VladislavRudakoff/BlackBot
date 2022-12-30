namespace FluentBot.Domain.Entities.Entities.Commands;

/// <summary>
/// Bot command.
/// </summary>
/// <param name="Command">Text of the command(1-32 characters). <b>Can contain only lowercase English letters, digits and underscores.</b></param>
/// <param name="Description">Description of the command(1-256 characters).</param>
public sealed record BotCommand(
    string Command,
    string Description);