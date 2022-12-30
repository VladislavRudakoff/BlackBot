using ChatMembers;
using ChatMembers;
using Chats;
using Chats;
using Chats;
using Chats;
using Telegram.Contracts.Events.Chats.Commands;
using Telegram.Contracts.Events.Chats.Commands.InviteLinks;
using Telegram.Contracts.Events.Chats.Commands.Requests;
using Telegram.Contracts.Events.Chats.Commands.Stickers;
using Telegram.Contracts.Events.Chats.Commands.Users;
using Telegram.Contracts.Events.Chats.Queries;

namespace Telegram.Contracts.ApiClients.Interfaces;

/// <summary>
/// Клиент Telegram Api с методами для чата.
/// </summary>
public interface IChatTelegramClient
{
    /// <summary>
    /// Блокирует пользователя в группе, супергруппе или канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="banChatMember"><see cref="BanChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> BanChatMemberAsync(BanChatMember banChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Разблокирует пользователя. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unbanChatMember"><see cref="UnbanChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> UnbanChatMemberAsync(UnbanChatMember unbanChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Ограничивает разрешения пользователя в чате. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="restrictChatMember"><see cref="RestrictChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> RestrictChatMemberAsync(RestrictChatMember restrictChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Повышает/понижает пользователя в супергруппе или канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="promoteChatMember"><see cref="PromoteChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> PromoteChatMemberAsync(PromoteChatMember promoteChatMember, CancellationToken cancellationToken = default);

    //TODO: Надо проверить на других пользователях.
    //  |
    //  V
    /// <summary>
    /// Задаёт "титул" для администратора в супергруппе.
    /// </summary>
    /// <param name="setChatAdministratorTitle"><see cref="SetChatAdministratorTitle"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> SetChatAdministratorCustomTitleAsync(SetChatAdministratorTitle setChatAdministratorTitle, CancellationToken cancellationToken = default);

    /// <summary>
    /// Блокирует чат канала в супергруппе или на канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="banChatSenderChat"><see cref="BanChatSenderChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> BanChatSenderChatAsync(BanChatSenderChat banChatSenderChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Разблокирует чат канала в супергруппе или на канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unbanChatSenderChat"><see cref="UnbanChatSenderChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> UnbanChatSenderChatAsync(UnbanChatSenderChat unbanChatSenderChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Устанавливает разрешения чата по умолчанию. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setDefaultChatPermissions"><see cref="SetDefaultChatPermissions"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> SetDefaultChatPermissionsAsync(SetDefaultChatPermissions setDefaultChatPermissions, CancellationToken cancellationToken = default);

    /// <summary>
    /// Создаёт основную ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="exportChatInviteLink"><see cref="ExportChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Ссылка-приглашение.</b></returns>
    Task<TelegramResponse<string>?> ExportChatInviteLinkAsync(ExportChatInviteLink exportChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Создаёт дополнительную ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="createChatInviteLink"><see cref="CreateChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="FluentBot.Domain.Entities.Chats.ChatInviteLink"/>.</b></returns>
    Task<TelegramResponse<ChatInviteLink>?> CreateChatInviteLinkAsync(CreateChatInviteLink createChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Редактирует дополнительную ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="editChatInviteLink"><see cref="EditChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="FluentBot.Domain.Entities.Chats.ChatInviteLink"/>.</b></returns>
    Task<TelegramResponse<ChatInviteLink>?> EditChatInviteLinkAsync(EditChatInviteLink editChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отзывает ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="revokeChatInviteLink"><see cref="RevokeChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="FluentBot.Domain.Entities.Chats.ChatInviteLink"/>.</b></returns>
    Task<TelegramResponse<ChatInviteLink>?> RevokeChatInviteLinkAsync(RevokeChatInviteLink revokeChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Одобряет запрос на присоединение к чату.
    /// </summary>
    /// <param name="approveChatJoinRequest"><see cref="ApproveChatJoinRequest"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> ApproveChatJoinRequestAsync(ApproveChatJoinRequest approveChatJoinRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отклоняет запрос на присоединение к чату.
    /// </summary>
    /// <param name="declineChatJoinRequest"><see cref="DeclineChatJoinRequest"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeclineChatJoinRequestAsync(DeclineChatJoinRequest declineChatJoinRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет фотографию чата. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="deleteChatPhoto"><see cref="DeleteChatPhoto"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeleteChatPhotoAsync(DeleteChatPhoto deleteChatPhoto, CancellationToken cancellationToken = default);

    /// <summary>
    /// Изменяет название чата. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setChatTitle"><see cref="SetChatTitle"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatTitleAsync(SetChatTitle setChatTitle, CancellationToken cancellationToken = default);

    /// <summary>
    /// Изменяет описание чата, супергруппы или канала. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setChatDescription"><see cref="SetChatDescription"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatDescriptionAsync(SetChatDescription setChatDescription, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает всю доступную информацию о чате.
    /// </summary>
    /// <param name="getChat"><see cref="GetChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="FluentBot.Domain.Entities.Chats.Chat"/>.</b></returns>
    Task<TelegramResponse<Chat>?> GetChatAsync(GetChat getChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает список администраторов чата(кроме других ботов). Если чат является группой или супергруппой без администраторов, в коллекции будет только создатель.
    /// </summary>
    /// <param name="getChatAdministrators"><see cref="GetChatAdministrators"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Коллекция <see cref="FluentBot.Domain.Entities.Chats.ChatMembers.ChatMember"/>.</b></returns>
    Task<TelegramResponse<IEnumerable<ChatMember>>?> GetChatAdministratorsAsync(GetChatAdministrators getChatAdministrators, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает количество участников чата.
    /// </summary>
    /// <param name="getChatMemberCount"><see cref="GetChatMemberCount"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Количество участников.</b></returns>
    Task<TelegramResponse<int>?> GetChatMemberCountAsync(GetChatMemberCount getChatMemberCount, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает информацию об участнике чата.
    /// </summary>
    /// <param name="getChatMember"><see cref="GetChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="FluentBot.Domain.Entities.Chats.ChatMembers.ChatMember"/>.</b></returns>
    Task<TelegramResponse<ChatMember>?> GetChatMemberAsync(GetChatMember getChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Создаёт коллекцию стикеров. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setChatStickerSet"><see cref="SetChatStickerSet"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatStickerSetAsync(SetChatStickerSet setChatStickerSet, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет коллекцию стикеров. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="deleteChatStickerSet"><see cref="DeleteChatStickerSet"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeleteChatStickerSetAsync(DeleteChatStickerSet deleteChatStickerSet, CancellationToken cancellationToken = default);
}