namespace FluentBot.Domain.Entities.Entities.Keyboard;

/// <summary>
/// Объект, который отсылает Telegram для того, чтобы удалить текущую пользовательскую клавиатуру и отобразить буквенную клавиатуру по умолчанию.
/// </summary>
/// <param name="RemoveKeyboard">Запрашивает у клиентов удаление настраиваемой клавиатуры.</param>
/// <param name="Selective">Используется, чтобы удалить клавиатуру только у @упомянутых пользователей, либо если сообщение бота является ответом на сообщение пользователя.</param>
public record ReplyKeyboardRemove(
    bool RemoveKeyboard,
    bool? Selective)
    : IInterfaceOptions;