using System.Collections.Generic;

namespace Telegram.Contracts.DTOs.Keyboard;

/// <summary>
/// Настраиваемая клавиатура с вариантами ответа.
/// </summary>
/// <param name="Keyboard">Коллекция коллекций кнопок(каждый массив - ряд кнопок).</param>
/// <param name="ResizeKeyboard">True - если требуется оптимизировать размер клавиатуры по вертикали.<br />
/// False - настраиваемая клавиатура будет иметь ту же высоту, что и стандартная.</param>
/// <param name="OneTimeKeyboard">True - скрывает настраиваемую клавиатуру и выводит стандартную пользовательскую. <br />
/// Пользователь может вернуться к настраиваемой при нажатии на специальную кнопку. <b>False - по умолчанию.</b></param>
/// <param name="InputFieldPlaceholder">Заполнитель, который будет отображаться в поле ввода, когда клавиатура активна(от 1 до 64 символов).</param>
/// <param name="Selective">Используется, чтобы показывать клавиатуру только @упомянутым пользователям, либо если сообщение бота является ответом на сообщение пользователя.</param>
public record ReplyKeyboardMarkup(
    IEnumerable<IEnumerable<KeyboardButton>> Keyboard,
    bool? ResizeKeyboard,
    bool? OneTimeKeyboard,
    string? InputFieldPlaceholder,
    bool? Selective);