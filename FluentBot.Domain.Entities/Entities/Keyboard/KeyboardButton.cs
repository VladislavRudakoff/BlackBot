namespace FluentBot.Domain.Entities.Entities.Keyboard;

/// <summary>
/// Кнопка настраиваемой клавиатуры. Свойства RequestContact, RequestLocation и RequestPool являются взаимоисключающими.
/// </summary>
public record KeyboardButton
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="text">Текст кнопки. Если ни одно из необязательных полей не используется, оно будет отправлено в виде сообщения при нажатии кнопки.</param>
    public KeyboardButton(string text)
    {
        Text = text;
    }

    /// <summary>Текст кнопки. Если ни одно из необязательных полей не используется, оно будет отправлено в виде сообщения при нажатии кнопки.</summary>
    public string Text { get; init; }

    /// <summary>Если true, то будет отправлен номер телефона пользователя. <b>Доступно только в приватных чатах.</b></summary>
    public bool? RequestContact { get; init; }

    /// <summary>Если true, то будет отправлено текущее местонахождение пользователя. <b>Доступно только в приватных чатах.</b></summary>
    public bool? RequestLocation { get; init; }

    /// <summary>Если указано, пользователю будет предложено создать опрос и отправить его боту. <b>Доступно только в приватных чатах.</b></summary>
    public string? RequestPoll { get; init; }

    /// <summary>
    /// Создаёт кнопку клавиатуры, которая отправляет номер телефона пользователя.
    /// </summary>
    /// <param name="text">Текст кнопки.</param>
    /// <returns><see cref="KeyboardButton"/>.</returns>
    public static KeyboardButton WithRequestContact(string text) =>
        new(text)
        {
            RequestContact = true,
            RequestLocation = null,
            RequestPoll = null
        };

    /// <summary>
    /// Создаёт кнопку клавиатуры, которая отправляет текущее местонахождение пользователя.
    /// </summary>
    /// <param name="text">Текст кнопки.</param>
    /// <returns><see cref="KeyboardButton"/>.</returns>
    public static KeyboardButton WithRequestLocation(string text) =>
        new(text)
        {
            RequestContact = null,
            RequestLocation = true,
            RequestPoll = null
        };

    /// <summary>
    /// Создаёт кнопку клавиатуры, при нажатии на которую пользователю будет предложено создать опрос и отправить его боту.
    /// </summary>
    /// <param name="text">Текст кнопки.</param>
    /// <param name="type">Тип опроса. По умолчанию или, если передано не валидное значение, выставлено <see cref="Telegram.Contracts.Enums.PollType.Regular"/>.</param>
    /// <returns><see cref="KeyboardButton"/>.</returns>
    public static KeyboardButton WithRequestPoll(string text, PollType type = PollType.Regular) =>
        new(text)
        {
            RequestContact = null,
            RequestLocation = null,
            RequestPoll = 
                type is not 0 
                    ? nameof(type)
                    : nameof(PollType.Regular)
        };
}