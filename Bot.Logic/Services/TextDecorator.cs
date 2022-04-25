using System.Threading;
using Bot.Data.Enums;
using Bot.Logic.Exceptions;
using Bot.Logic.Services.Interfaces;

namespace Bot.Logic.Services;

/// <inheritdoc cref="ITextDecorator"/>
public class TextDecorator: ITextDecorator
{
    public string ConvertsTextStyle(string oldText, TextSelection textStyle, CancellationToken cancellationToken = default) =>
        textStyle switch
        {
            TextSelection.Bold => $"<strong>{oldText}</strong>",
            TextSelection.Italic => $"<em>{oldText}</em>",
            TextSelection.CodeMonospace => $"<code>{oldText}</code>",
            TextSelection.PreMonospace => $"<pre>{oldText}</pre>",
            TextSelection.Spoiler => $"<tg-spoiler>{oldText}</tg-spoiler>",
            TextSelection.Strikeout => $"<strike>{oldText}</strike>",
            TextSelection.Underlined => $"<u>{oldText}</u>",
            _ => throw new TextConversionException()
        };

    public string AddingLink(string oldText, string link, CancellationToken cancellationToken = default) => 
        $"<a href=\"{link}\">{oldText}</a>";

    public string AddingMentionUser(string oldText, long userId, CancellationToken cancellationToken = default) => 
        $"<a href=\"tg://user?id={userId}\">{oldText}</a>";
}
