namespace FluentBot.Domain.Entities.Entities.Keyboard;

/// <summary>
/// Кнопка встроенной клавиатуры.
/// </summary>
/// <param name="Text">Текст кнопки.</param>
/// <param name="Url">URL-адрес HTTP или tg://, который будет открыт при нажатии кнопки.</param>
/// <param name="CallbackData">Данные для отправки в callback-запросе боту при нажатии кнопки.</param>
public record InlineKeyboardButton(
    string Text,
    string? Url,
    string? CallbackData)
{
    /// <summary>
    /// Создает встроенную кнопку клавиатуры, которая открывает URL-адрес при нажатии.
    /// </summary>
    /// <param name="text">Текст кнопки.</param>
    /// <param name="url">URL-адрес HTTP или tg://, который будет открыт при нажатии кнопки.</param>
    /// <returns><see cref="InlineKeyboardButton"/>.</returns>
    public static InlineKeyboardButton WithUrl(string text, string url) =>
        new(text, url, null);

    /// <summary>
    /// Создает встроенную кнопку клавиатуры, которая отправляет <see cref="CallbackQuery"/> боту при нажатии.
    /// </summary>
    /// <param name="textAndCallbackData">
    /// Текст и данные для отправки в <see cref="CallbackQuery">обратном запросе</see> боту при
    /// нажатии(1-64 байта).
    /// </param>
    /// <returns><see cref="InlineKeyboardButton"/>.</returns>
    public static InlineKeyboardButton WithCallbackData(string textAndCallbackData) =>
        new(textAndCallbackData, null, textAndCallbackData);

    /// <summary>
    /// Создает встроенную кнопку клавиатуры, которая отправляет <see cref="CallbackQuery"/> боту при нажатии.
    /// </summary>
    /// <param name="text">Текст кнопки.</param>
    /// <param name="callbackData">
    /// Данные для отправки в <see cref="CallbackQuery">обратном запросе</see> боту при
    /// нажатии(1-64 байта).
    /// </param>
    /// <returns><see cref="InlineKeyboardButton"/>.</returns>
    public static InlineKeyboardButton WithCallbackData(string text, string callbackData) =>
        new(text, null, callbackData);
}