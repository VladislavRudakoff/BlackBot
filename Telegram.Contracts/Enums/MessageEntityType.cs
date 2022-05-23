namespace Telegram.Contracts.Enums.

public enum MessageEntityType
{
    /// <summary>
    /// A mentioned <see cref="User"/>
    /// </summary>
    Mention = 1,

    /// <summary>
    /// A searchable Hashtag
    /// </summary>
    Hashtag = 2,

    /// <summary>
    /// A Bot command
    /// </summary>
    BotCommand = 3,

    /// <summary>
    /// An url
    /// </summary>
    Url = 4,

    /// <summary>
    /// An email
    /// </summary>
    Email = 5,

    /// <summary>
    /// Bold text
    /// </summary>
    Bold = 6,

    /// <summary>
    /// Italic text
    /// </summary>
    Italic = 7,

    /// <summary>
    /// Monowidth string
    /// </summary>
    Code = 8,

    /// <summary>
    /// Monowidth block
    /// </summary>
    Pre = 9,

    /// <summary>
    /// Clickable text urls
    /// </summary>
    TextLink = 10,

    /// <summary>
    /// Mentions for a <see cref="User"/> without <see cref="User.Username"/>
    /// </summary>
    TextMention = 11,

    /// <summary>
    /// Phone number
    /// </summary>
    PhoneNumber = 12,

    /// <summary>
    /// A cashtag (e.g. $EUR, $USD) - $ followed by the short currency code
    /// </summary>
    Cashtag = 13,

    /// <summary>
    /// Underlined text
    /// </summary>
    Underline = 14,

    /// <summary>
    /// Strikethrough text
    /// </summary>
    Strikethrough = 15,

    /// <summary>
    /// Spoiler message
    /// </summary>
    Spoiler = 16,
}