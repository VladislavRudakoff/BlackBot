using FluentBot.Domain.Entities.Entities.Webhook;

namespace FluentBot.Domain.Entities.Enums;

/// <summary>
/// Тип входящего обновления.
/// </summary>
public enum IncomingUpdateType
{
    /// <summary>
    /// Неизвестный тип обновления.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Сообщение.
    /// </summary>
    Message = 1,

    /// <summary>
    /// Встроенный результат.
    /// </summary>
    InlineQuery = 2,

    /// <summary>
    /// Выбранный встроенный результат.
    /// </summary>
    ChosenInlineResult = 3,

    /// <summary>
    /// Callback-запрос.
    /// </summary>
    CallbackQuery = 4,

    /// <summary>
    /// Изменение сообщения.
    /// </summary>
    EditedMessage = 5,

    /// <summary>
    /// Пост на канале.
    /// </summary>
    ChannelPost = 6,

    /// <summary>
    /// Изменение поста на канале.
    /// </summary>
    EditedChannelPost = 7,

    /// <summary>
    /// Опрос.
    /// </summary>
    Poll = 8,

    /// <summary>
    /// Ответ на опрос.
    /// </summary>
    PollAnswer = 9,

    /// <summary>
    /// Обновление статуса участника чата(<see cref="IncomingUpdate"/> содержит <see cref="IncomingUpdate.MyChatMember"/>).
    /// </summary>
    MyChatMember = 10,

    /// <summary>
    /// Обновление статуса участника чата(<see cref="IncomingUpdate"/> содержит <see cref="IncomingUpdate.ChatMember"/>).
    /// </summary>
    ChatMember = 11,

    /// <summary>
    /// Запрос на вступление в чат.
    /// </summary>
    ChatJoinRequest = 12,
}