using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.Events.Chats.Commands;
using Telegram.Contracts.Events.Chats.Commands.InviteLinks;
using Telegram.Contracts.Events.Chats.Commands.Requests;
using Telegram.Contracts.Events.Chats.Commands.Stickers;
using Telegram.Contracts.Events.Chats.Commands.Users;
using Telegram.Contracts.Events.Chats.Queries;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

public class ChatTelegramClient : BaseTelegramClient, IChatTelegramClient
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    public ChatTelegramClient(
        HttpClient httpClient,
        TelegramClientSettings telegramClientSettings)
        : base(httpClient, telegramClientSettings)
    {
    }

    public async Task<TelegramResponse<bool>?> BanChatMemberAsync(BanChatMember banChatMember, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<BanChatMember, bool>(banChatMember, "/banChatMember", cancellationToken);

    public async Task<TelegramResponse<bool>?> UnbanChatMemberAsync(UnbanChatMember unbanChatMember, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<UnbanChatMember, bool>(unbanChatMember, "/unbanChatMember", cancellationToken);

    public async Task<TelegramResponse<bool>?> RestrictChatMemberAsync(RestrictChatMember restrictChatMember, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<RestrictChatMember, bool>(restrictChatMember, "/restrictChatMember", cancellationToken);

    public async Task<TelegramResponse<bool>?> PromoteChatMemberAsync(PromoteChatMember promoteChatMember, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<PromoteChatMember, bool>(promoteChatMember, "/promoteChatMember", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetChatAdministratorCustomTitleAsync(SetChatAdministratorTitle setChatAdministratorTitle, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetChatAdministratorTitle, bool>(setChatAdministratorTitle, "/setChatAdministratorCustomTitle", cancellationToken);

    public async Task<TelegramResponse<bool>?> BanChatSenderChatAsync(BanChatSenderChat banChatSenderChat, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<BanChatSenderChat, bool>(banChatSenderChat, "/banChatSenderChat", cancellationToken);

    public async Task<TelegramResponse<bool>?> UnbanChatSenderChatAsync(UnbanChatSenderChat unbanChatSenderChat, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<UnbanChatSenderChat, bool>(unbanChatSenderChat, "/unbanChatSenderChat", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetDefaultChatPermissionsAsync(SetDefaultChatPermissions setDefaultChatPermissions, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetDefaultChatPermissions, bool>(setDefaultChatPermissions, "/setChatPermissions", cancellationToken);

    public async Task<TelegramResponse<string>?> ExportChatInviteLinkAsync(ExportChatInviteLink exportChatInviteLink, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<ExportChatInviteLink, string>(exportChatInviteLink, "/exportChatInviteLink", cancellationToken);

    public async Task<TelegramResponse<ChatInviteLink>?> CreateChatInviteLinkAsync(CreateChatInviteLink createChatInviteLink, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<CreateChatInviteLink, ChatInviteLink>(createChatInviteLink, "/createChatInviteLink", cancellationToken);

    public async Task<TelegramResponse<ChatInviteLink>?> EditChatInviteLinkAsync(EditChatInviteLink editChatInviteLink, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditChatInviteLink, ChatInviteLink>(editChatInviteLink, "/editChatInviteLink", cancellationToken);

    public async Task<TelegramResponse<ChatInviteLink>?> RevokeChatInviteLinkAsync(RevokeChatInviteLink revokeChatInviteLink, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<RevokeChatInviteLink, ChatInviteLink>(revokeChatInviteLink, "/revokeChatInviteLink", cancellationToken);

    public async Task<TelegramResponse<bool>?> ApproveChatJoinRequestAsync(ApproveChatJoinRequest approveChatJoinRequest, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<ApproveChatJoinRequest, bool>(approveChatJoinRequest, "/approveChatJoinRequest", cancellationToken);

    public async Task<TelegramResponse<bool>?> DeclineChatJoinRequestAsync(DeclineChatJoinRequest declineChatJoinRequest, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeclineChatJoinRequest, bool>(declineChatJoinRequest, "/declineChatJoinRequest", cancellationToken);

    public async Task<TelegramResponse<bool>?> DeleteChatPhotoAsync(DeleteChatPhoto deleteChatPhoto, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeleteChatPhoto, bool>(deleteChatPhoto, "/deleteChatPhoto", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetChatTitleAsync(SetChatTitle setChatTitle, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetChatTitle, bool>(setChatTitle, "/setChatTitle", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetChatDescriptionAsync(SetChatDescription setChatDescription, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetChatDescription, bool>(setChatDescription, "/setChatDescription", cancellationToken);

    public async Task<TelegramResponse<Chat>?> GetChatAsync(GetChat getChat, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetChat, Chat>(getChat, "/getChat", cancellationToken);

    public async Task<TelegramResponse<IEnumerable<ChatMember>>?> GetChatAdministratorsAsync(GetChatAdministrators getChatAdministrators, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetChatAdministrators, IEnumerable<ChatMember>>(getChatAdministrators, "/getChatAdministrators", cancellationToken);

    public async Task<TelegramResponse<int>?> GetChatMemberCountAsync(GetChatMemberCount getChatMemberCount, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetChatMemberCount, int>(getChatMemberCount, "/getChatMemberCount", cancellationToken);

    public async Task<TelegramResponse<ChatMember>?> GetChatMemberAsync(GetChatMember getChatMember, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetChatMember, ChatMember>(getChatMember, "/getChatMember", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetChatStickerSetAsync(SetChatStickerSet setChatStickerSet, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetChatStickerSet, bool>(setChatStickerSet, "/setChatStickerSet", cancellationToken);

    public async Task<TelegramResponse<bool>?> DeleteChatStickerSetAsync(DeleteChatStickerSet deleteChatStickerSet, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeleteChatStickerSet, bool>(deleteChatStickerSet, "/deleteChatStickerSet", cancellationToken);
}