namespace Bot.Data.Enums;

/// <summary>
/// Тип кнопки.
/// </summary>
public enum ButtonType
{
    /// <summary>
    /// Кнопка с ссылкой.
    /// </summary>
    Link = 1,

    /// <summary>
    /// Кнопка-уведомление.
    /// </summary>
    CallbackNotification = 2,

    /// <summary>
    /// Кнопка-оповещение.
    /// </summary>
    CallbackAlert = 3,

    /// TODO: Пока не знаю нужна ли она.
    /// <summary>
    /// Кнопка для переключения в инлайн режим.
    /// </summary>
    SwitchToInline = 4,

    /// <summary>
    /// Кнопка-изменение.
    /// </summary>
    CallbackChange = 5,

    /// <summary>
    /// Кнопка на клавиатуре.
    /// </summary>
    KeyboardsButton = 6
}