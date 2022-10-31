using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.InlineMode;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.DTOs.Pools;
using Telegram.Contracts.Enums;

namespace Telegram.Contracts.DTOs.Webhook;

/// <summary>
/// Представляет входящее обновление.
/// </summary>
/// <param name="UpdateId">
/// Идентификатор обновления(начинается с определённого положительного числа).<br/>
/// Если обновлений нет хотя бы неделю, то идентификатор следующего будет выбран случайным образом, а не последовательно.
/// </param>
/// <param name="Message">Новое входящее сообщение любого типа - текст, фото, стикер и т.д.</param>
/// <param name="EditedMessage">Новая версия сообщения(отредактированная) известная боту.</param>
/// <param name="ChannelPost">Новый входящий пост канала любого типа — текст, фото, стикер и т.д.</param>
/// <param name="EditedChannelPost">Новая версия поста канала(отредактированная) известная боту.</param>
/// <param name="InlineQuery">Новый входящий inline-запрос.</param>
/// <param name="ChosenInlineResult">Результат встроенного запроса, который был выбран пользователем и отправлен собеседнику.</param>
/// <param name="CallbackQuery">Новый входящий callback запрос.</param>
/// <param name="Poll">
/// Новое состояние опроса.<br/>
/// Боты получают обновления только от своих опросов, либо об остановленных опросах.
/// </param>
/// <param name="PollAnswer">
/// Изменение ответа пользователем в не анонимном опросе.<br/>
/// Боты получают новые голоса только в опросах, отправленных самим ботом.
/// </param>
/// <param name="MyChatMember">
/// Статус участника чата бота был обновлен.<br/>
/// Для приватных чатов это обновление приходит только тогда, когда бот заблокирован или разблокирован пользователем.
/// </param>
/// <param name="ChatMember">
/// Статус участника чата бота был обновлен.<br/>
/// Бот должен быть администратором в чате и должен явно указать «chat_member» в списке AllowedUpdates, чтобы получать эти обновления.
/// </param>
/// <param name="ChatJoinRequest">
/// Запрос на вступление в чат.<br/>
/// Бот должен иметь право «CanInviteUsers», чтобы получать эти обновления.
/// </param>
public record IncomingUpdate(
    int UpdateId,
    Message? Message,
    Message? EditedMessage,
    Message? ChannelPost,
    Message? EditedChannelPost,
    InlineQuery? InlineQuery,
    ChosenInlineResult? ChosenInlineResult,
    CallbackQuery? CallbackQuery,
    Poll? Poll,
    PollAnswer? PollAnswer,
    ChatMemberUpdated? MyChatMember,
    ChatMemberUpdated? ChatMember,
    ChatJoinRequest? ChatJoinRequest)
{
    /// <summary>
    /// Тип обновления.
    /// </summary>
    public IncomingUpdateType Type => this switch
    {
        { Message: { } } => IncomingUpdateType.Message,
        { EditedMessage: { } } => IncomingUpdateType.EditedMessage,
        { InlineQuery: { } } => IncomingUpdateType.InlineQuery,
        { ChosenInlineResult: { } } => IncomingUpdateType.ChosenInlineResult,
        { CallbackQuery: { } } => IncomingUpdateType.CallbackQuery,
        { ChannelPost: { } } => IncomingUpdateType.ChannelPost,
        { EditedChannelPost: { } } => IncomingUpdateType.EditedChannelPost,
        { Poll: { } } => IncomingUpdateType.Poll,
        { PollAnswer: { } } => IncomingUpdateType.PollAnswer,
        { MyChatMember: { } } => IncomingUpdateType.MyChatMember,
        { ChatMember: { } } => IncomingUpdateType.ChatMember,
        { ChatJoinRequest: { } } => IncomingUpdateType.ChatJoinRequest,
        _ => IncomingUpdateType.Unknown
    };
}