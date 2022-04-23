namespace Bot.Data.Enums
{
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
        /// Моноширинный.
        /// </summary>
        Monospace = 5,

        /// <summary>
        /// Ссылка.
        /// </summary>
        Link = 6,

        /// <summary>
        /// Спойлер(только после нажатия)
        /// </summary>
        Spoiler = 7,

        /// <summary>
        /// Упоминание пользователя.
        /// </summary>
        UserMention = 8
    }
}
