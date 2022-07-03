using Bot.Common.Extensions;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Chats.ChatMembers;
using Telegram.Contracts.DTOs.Commands;
using Telegram.Contracts.DTOs.Files;
using Telegram.Contracts.DTOs.Menu;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events;
using Telegram.Contracts.Events.BotCommands.Commands;
using Telegram.Contracts.Events.BotCommands.Queries;
using Telegram.Contracts.Events.Chats.Commands;
using Telegram.Contracts.Events.Chats.Commands.Buttons;
using Telegram.Contracts.Events.Chats.Commands.InviteLinks;
using Telegram.Contracts.Events.Chats.Commands.Messages;
using Telegram.Contracts.Events.Chats.Commands.Requests;
using Telegram.Contracts.Events.Chats.Commands.Stickers;
using Telegram.Contracts.Events.Chats.Commands.Users;
using Telegram.Contracts.Events.Chats.Queries;
using Telegram.Contracts.Events.Chats.Queries.Buttons;
using Telegram.Contracts.Events.Common.Commands.Contacts;
using Telegram.Contracts.Events.Common.Commands.Files;
using Telegram.Contracts.Events.Common.Commands.Files.Animations;
using Telegram.Contracts.Events.Common.Commands.Files.Audio;
using Telegram.Contracts.Events.Common.Commands.Files.Location;
using Telegram.Contracts.Events.Common.Commands.Files.Photos;
using Telegram.Contracts.Events.Common.Commands.Files.Video;
using Telegram.Contracts.Events.Common.Commands.Messages;
using Telegram.Contracts.Events.Common.Commands.Polls;
using Telegram.Contracts.Events.Common.Commands.Random;
using Telegram.Contracts.Events.Common.Queries.Files;
using Telegram.Contracts.Events.Interfaces;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

/// <inheritdoc />
public class TelegramClient : ITelegramClient
{
    private readonly HttpClient httpClient;
    private readonly TelegramClientSettings telegramClientSettings;

    private readonly string baseBotUrl;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    public TelegramClient(
        HttpClient httpClient,
        TelegramClientSettings telegramClientSettings)
    {
        this.httpClient = httpClient;
        this.telegramClientSettings = telegramClientSettings;

        baseBotUrl = telegramClientSettings.BaseUrl + telegramClientSettings.Token;
    }

    public async Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default) =>
        await httpClient.GetAsJsonAsync<TelegramResponse<User>>(baseBotUrl + "/getMe", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendMessageAsync(SendMessage sendMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendMessage, Message>(sendMessage, "/sendMessage", cancellationToken);

    public async Task<TelegramResponse<Message>?> ForwardMessageAsync(ForwardMessage forwardMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<ForwardMessage, Message>(forwardMessage, "/forwardMessage", cancellationToken);

    public async Task<TelegramResponse<MessageIdentifier>?> CopyMessageAsync(CopyMessage copyMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<CopyMessage, MessageIdentifier>(copyMessage, "/copyMessage", cancellationToken);
    
    public async Task<TelegramResponse<Message>?> SendPhotoAsync(SendPhoto sendPhoto, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendPhoto, Message>(sendPhoto, "/sendPhoto", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendAudioAsync(SendAudio sendAudio, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAudio, Message>(sendAudio, "/sendAudio", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendFileAsync(SendFile sendFile, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendFile, Message>(sendFile, "/sendDocument", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVideoAsync(SendVideo sendVideo, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideo, Message>(sendVideo, "/sendVideo", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendAnimationAsync(SendAnimation sendAnimation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAnimation, Message>(sendAnimation, "/sendAnimation", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVoiceAsync(SendVoice sendVoice, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVoice, Message>(sendVoice, "/sendVoice", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVideoNoteAsync(SendVideoNote sendVideoNote, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideoNote, Message>(sendVideoNote, "/sendVideoNote", cancellationToken);

    public async Task<TelegramResponse<IEnumerable<Message>>?> SendMediaGroupAsync(SendMediaGroup sendMediaGroup, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendMediaGroup, IEnumerable<Message>>(sendMediaGroup, "/sendMediaGroup", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendLocationAsync(SendLocation sendLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendLocation, Message>(sendLocation, "/sendLocation", cancellationToken);

    public async Task<TelegramResponse<Message>?> EditLiveLocationAsync(EditMessageLiveLocation editLiveLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditMessageLiveLocation, Message>(editLiveLocation, "/editMessageLiveLocation", cancellationToken);

    public async Task<TelegramResponse<Message>?> StopLiveLocationAsync(StopMessageLiveLocation stopLiveLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<StopMessageLiveLocation, Message>(stopLiveLocation, "/stopMessageLiveLocation", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVenueAsync(SendVenue sendVenue, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVenue, Message>(sendVenue, "/sendVenue", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendContactAsync(SendContact sendContact, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendContact, Message>(sendContact, "/sendContact", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendPollAsync(SendPoll sendPool, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendPoll, Message>(sendPool, "/sendPoll", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendDiceAsync(SendDice sendDice, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendDice, Message>(sendDice, "/sendDice", cancellationToken);

    public async Task<TelegramResponse<FileForDownload>?> GetFileAsync(GetFile getFile, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetFile, FileForDownload>(getFile, "/getFile", cancellationToken);

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

    public async Task<TelegramResponse<bool>?> UnpinChatMessageAsync(UnpinChatMessage unpinChatMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<UnpinChatMessage, bool>(unpinChatMessage, "/unpinChatMessage", cancellationToken);

    public async Task<TelegramResponse<bool>?> PinChatMessageAsync(PinChatMessage pinChatMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<PinChatMessage, bool>(pinChatMessage, "/pinChatMessage", cancellationToken);

    public async Task<TelegramResponse<bool>?> UnpinAllChatMessagesAsync(UnpinAllChatMessages unpinAllChatMessages, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<UnpinAllChatMessages, bool>(unpinAllChatMessages, "/unpinAllChatMessages", cancellationToken);

    public async Task<TelegramResponse<bool>?> LeaveChatAsync(LeaveChat leaveChat, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<LeaveChat, bool>(leaveChat, "/leaveChat", cancellationToken);

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

    public async Task<TelegramResponse<bool>?> AnswerCallbackQueryAsync(AnswerCallbackQuery answerCallbackQuery, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<AnswerCallbackQuery, bool>(answerCallbackQuery, "/answerCallbackQuery", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetCommandsAsync(SetMyCommands setMyCommands, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetMyCommands, bool>(setMyCommands, "/setMyCommands", cancellationToken);

    public async Task<TelegramResponse<bool>?> DeleteCommandsAsync(DeleteMyCommands deleteMyCommands, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeleteMyCommands, bool>(deleteMyCommands, "/deleteMyCommands", cancellationToken);

    public async Task<TelegramResponse<IEnumerable<BotCommand>>?> GetCommandsAsync(GetMyCommands getMyCommands, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetMyCommands, IEnumerable<BotCommand>>(getMyCommands, "/getMyCommands", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetChatMenuButtonAsync(SetChatMenuButton setChatMenuButton, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetChatMenuButton, bool>(setChatMenuButton, "/setChatMenuButton", cancellationToken);

    public async Task<TelegramResponse<MenuButton>?> GetChatMenuButtonAsync(GetChatMenuButton getChatMenuButton, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetChatMenuButton, MenuButton>(getChatMenuButton, "/getChatMenuButton", cancellationToken);

    private async Task<TelegramResponse<TU>?> ExecuteCommand<T, TU>(
        T commandModel, 
        string command, 
        CancellationToken cancellationToken = default) 
        where T: IEventEntity =>
        await httpClient.PostAsJsonAsync<TelegramResponse<TU>?>(
            baseBotUrl + command,
            commandModel,
            cancellationToken);
}