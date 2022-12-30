namespace FluentBot.Domain.Entities.Entities;

/// <summary>
/// Telegram user.
/// </summary>
public record User
{
    /// <summary>
    /// User ID.
    /// </summary>
    public long Id { get; init; }

    /// <summary>
    /// True, if this user is a bot.
    /// </summary>
    public bool IsBot { get; init; }

    /// <summary>
    /// True, if this user is a Telegram Premium user.
    /// </summary>
    public bool? IsPremium { get; init; }

    /// <summary>
    /// User's or bot's first name.
    /// </summary>
    public string FirstName { get; init; } = null!;

    /// <summary>
    /// User's or bot's last name.
    /// </summary>
    public string? LastName { get; init; }

    /// <summary>
    /// User's or bot's username.
    /// </summary>
    public string? Username { get; init; }

    /// <summary>
    /// IETF language tag of the user's language.
    /// </summary>
    public string? LanguageCode { get; init; }

    /// <summary>
    /// True, if this user added the bot to the attachment menu.
    /// </summary>
    public bool AddedToAttachmentMenu { get; init; }
}

/// <summary>
/// Telegram bot.
/// </summary>
public sealed record Bot : User
{
    /// <summary>
    /// True, if the bot can be invited to groups.
    /// </summary>
    public bool? CanJoinGroups { get; init; }

    /// <summary>
    /// True, if privacy mode is disabled for the bot.
    /// </summary>
    public bool? CanReadAllGroupMessages { get; init; }

    /// <summary>
    /// True, if the bot supports inline queries.
    /// </summary>
    public bool? SupportsInlineQueries { get; init; }
}