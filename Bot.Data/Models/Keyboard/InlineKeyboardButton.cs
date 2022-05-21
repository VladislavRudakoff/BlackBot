namespace Bot.Data.Models.Keyboard;

/// <summary>
/// Кнопка встроенной клавиатуры.
/// </summary>
/// <param name="Text">Текст кнопки.</param>
/// <param name="Url">URL-адрес HTTP или tg://, который будет открыт при нажатии кнопки.</param>
/// <param name="CallbackData">Данные для отправки в callback-запросе боту при нажатии кнопки.</param>
public record InlineKeyboardButton(
    string Text,
    string Url,
    string? CallbackData);