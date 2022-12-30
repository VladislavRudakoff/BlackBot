using FluentBot.Domain.Entities.Entities.Chats.ChatMembers;

namespace FluentBot.Domain.Entities.Entities.Chats;

/// <summary>
/// Объект представляет изменения в статусе участника чата.
/// </summary>
/// <param name="Chat">Чат, к которому принадлежит пользователь.</param>
/// <param name="From">Инициатор изменения статуса участника.</param>
/// <param name="Date">Дата внесения изменений(Unix).</param>
/// <param name="OldChatMember">Предыдущая информация об участнике чата.</param>
/// <param name="NewChatMember">Новая информация об участнике чата.</param>
/// <param name="InviteLink">Ссылка-приглашение, по которой пользователь присоединился к чату. <b>Только для присоединения к мероприятиям по ссылке-приглашению.</b></param>
public record ChatMemberUpdated(
    Chat Chat,
    User From,
    int Date,
    ChatMember OldChatMember,
    ChatMember NewChatMember,
    ChatInviteLink? InviteLink);