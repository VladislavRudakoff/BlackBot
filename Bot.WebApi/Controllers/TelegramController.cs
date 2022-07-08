using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Providers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Chats.ChatMembers;
using Telegram.Contracts.DTOs.Files;
using Telegram.Contracts.Events.Chats.Commands;
using Telegram.Contracts.Events.Chats.Commands.Users;
using Telegram.Contracts.Events.Chats.Queries;
using Telegram.Contracts.Events.Common.Queries.Files;


namespace Bot.WebApi.Controllers;

/// <summary>
/// Контроллер для работы с Telegram.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TelegramController : Controller
{
    private readonly ITelegramInfoProvider telegramInfoProvider;
    private readonly ILogger<TelegramController> logger;
    private readonly IBotTelegramClient botTelegramClient;
    private readonly IChatTelegramClient chatTelegramClient;
    private readonly IMessageTelegramClient messageTelegramClient;

    public TelegramController(
        ITelegramInfoProvider telegramInfoProvider, 
        IBotTelegramClient botTelegramClient, 
        IChatTelegramClient chatTelegramClient, 
        IMessageTelegramClient messageTelegramClient, 
        ILogger<TelegramController> logger)
    {
        this.telegramInfoProvider = telegramInfoProvider;
        this.botTelegramClient = botTelegramClient;
        this.chatTelegramClient = chatTelegramClient;
        this.messageTelegramClient = messageTelegramClient;
        this.logger = logger;
    }

    [HttpGet("botInfo")]
    public async Task<TelegramResponse<User>?> GetInfo(CancellationToken cancellationToken = default) => 
        await telegramInfoProvider.GetBotInfoAsync(cancellationToken);

    [HttpPost("TestActionMethod")]
    public async Task<IActionResult> SendMessage(CancellationToken cancellationToken = default)
    {
        SetDefaultChatPermissions model = new SetDefaultChatPermissions(
            new ChatId(-1001772116557),
            new ChatPermissions(
                true, 
                true, 
                true, 
                true, 
                true, 
                true, 
                true, 
                true));

        TelegramResponse<bool>? result = 
            await chatTelegramClient.SetDefaultChatPermissionsAsync(model, cancellationToken);

        logger.LogWarning(
            "Команда {command} клиента {client} успешно выполнена.",
            nameof(chatTelegramClient.SetDefaultChatPermissionsAsync),
            chatTelegramClient.GetType());

        return Ok(result);
    }
}