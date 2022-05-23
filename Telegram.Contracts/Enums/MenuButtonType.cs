﻿namespace Telegram.Contracts.Enums.

public enum MenuButtonType
{
    /// <summary>
    /// Describes that no specific value for the menu button was set.
    /// </summary>
    Default = 1,

    /// <summary>
    /// Represents a menu button, which opens the bot’s list of commands.
    /// </summary>
    Commands = 2,

    /// <summary>
    /// Represents a menu button, which launches a <a href="https://core.telegram.org/bots/webapps">Web App</a>.
    /// </summary>
    WebApp = 3
}