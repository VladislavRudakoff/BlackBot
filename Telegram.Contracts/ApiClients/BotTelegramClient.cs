using Bot.Common.Extensions;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Commands;
using Telegram.Contracts.DTOs.Menu;
using Telegram.Contracts.DTOs.Webhook;
using Telegram.Contracts.Events.BotCommands.Commands;
using Telegram.Contracts.Events.BotCommands.Queries;
using Telegram.Contracts.Events.Chats.Commands;
using Telegram.Contracts.Events.Chats.Commands.Buttons;
using Telegram.Contracts.Events.Chats.Queries.Buttons;
using Telegram.Contracts.Events.Webhook.Commands;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

public class BotTelegramClient : BaseTelegramClient, IBotTelegramClient
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    public BotTelegramClient(
        HttpClient httpClient,
        TelegramClientSettings telegramClientSettings)
        : base(httpClient, telegramClientSettings)
    {
    }

    public async Task<TelegramResponse<User>?> GetBotInfoAsync(
        CancellationToken cancellationToken = default) =>
        await HttpClient.GetAsJsonAsync<TelegramResponse<User>>(
            BaseBotUrl + "/getMe", 
            cancellationToken);

    public async Task<TelegramResponse<bool>?> SetCommandsAsync(
        SetMyCommands setMyCommands, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetMyCommands, bool>(
            setMyCommands, 
            "/setMyCommands",
            cancellationToken);

    public async Task<TelegramResponse<bool>?> DeleteCommandsAsync(
        DeleteMyCommands deleteMyCommands, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeleteMyCommands, bool>(
            deleteMyCommands, 
            "/deleteMyCommands", 
            cancellationToken);

    public async Task<TelegramResponse<IEnumerable<BotCommand>>?> GetCommandsAsync(
        GetMyCommands getMyCommands, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetMyCommands, IEnumerable<BotCommand>>(
            getMyCommands, 
            "/getMyCommands",
            cancellationToken);

    public async Task<TelegramResponse<bool>?> SetChatMenuButtonAsync(
        SetChatMenuButton setChatMenuButton, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetChatMenuButton, bool>(
            setChatMenuButton, 
            "/setChatMenuButton", 
            cancellationToken);

    public async Task<TelegramResponse<MenuButton>?> GetChatMenuButtonAsync(
        GetChatMenuButton getChatMenuButton, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetChatMenuButton, MenuButton>(
            getChatMenuButton, 
            "/getChatMenuButton",
            cancellationToken);

    public async Task<TelegramResponse<bool>?> LeaveChatAsync(
        LeaveChat leaveChat, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<LeaveChat, bool>(
            leaveChat, 
            "/leaveChat",
            cancellationToken);

    public async Task<TelegramResponse<bool>?> SetDefaultAdministratorRightsAsync(
        SetMyDefaultAdministratorRights setDefaultAdministratorRights, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetMyDefaultAdministratorRights, bool>(
            setDefaultAdministratorRights, 
            "/setMyDefaultAdministratorRights", 
            cancellationToken);

    public async Task<TelegramResponse<ChatAdministratorRights>?> GetDefaultAdministratorRightsAsync(
        GetMyDefaultAdministratorRights getDefaultAdministratorRights, 
        CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetMyDefaultAdministratorRights, ChatAdministratorRights>(
            getDefaultAdministratorRights, 
            "/setMyDefaultAdministratorRights", 
            cancellationToken);

    public async Task<TelegramResponse<bool>?> SetWebhookAsync(SetWebhook setWebhook, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetWebhook, bool>(
            setWebhook,
            "/setWebhook",
            cancellationToken);

    public async Task<TelegramResponse<bool>?> DeleteWebhookAsync(DeleteWebhook deleteWebhook, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeleteWebhook, bool>(
            deleteWebhook,
            "/deleteWebhook",
            cancellationToken);

    public async Task<TelegramResponse<WebhookInfo>?> GetWebhookInfoAsync(CancellationToken cancellationToken = default) =>
        await HttpClient.GetAsJsonAsync<TelegramResponse<WebhookInfo>>(
            BaseBotUrl + "/getWebhookInfo",
            cancellationToken);
}