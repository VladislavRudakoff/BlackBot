namespace Bot.Data.Enums;

/// <summary>
/// Выделение текста.
/// </summary>
public enum TextSelection
{
    /// <summary>
    /// Жирный.
    /// </summary>
    Bold = 1,

    /// <summary>
    /// Подчёркнутый.
    /// </summary>
    Underlined = 2,

    /// <summary>
    /// Курсив.
    /// </summary>
    Italic = 3,

    /// <summary>
    /// Зачёркнутый.
    /// </summary>
    Strikeout = 4,

    /// <summary>
    /// Моноширинный. Используется для выделения части фрагмента кода.
    /// </summary>
    CodeMonospace = 5,

    /// <summary>
    /// Спойлер(текст отображается только после нажатия)
    /// </summary>
    Spoiler = 6,

    /// <summary>
    /// Моноширинный. Используется для выделения большого фрагмента кода с сохранением переносов и пробелов.
    /// </summary>
    PreMonospace = 7
}