using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Providers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Telegram.Contracts.DTOs;

namespace Bot.WebApi.Controllers;

/// <summary>
/// Контроллер для работы с Telegram.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TelegramController : Controller
{
    private readonly ITelegramInfoProvider telegramInfoProvider;

    public TelegramController(ITelegramInfoProvider telegramInfoProvider)
    {
        this.telegramInfoProvider = telegramInfoProvider;
    }

    [HttpGet("botInfo")]
    public async Task<TelegramResponse<User>?> GetInfo(CancellationToken cancellationToken = default) => 
        await telegramInfoProvider.GetInfoAsync(cancellationToken);
}