using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Dispatchers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Contracts.DTOs.Webhook;

namespace Bot.WebApi.Controllers;

/// <summary>
/// Контроллер для прослушивания обновлений от Telegram с использованием webhook.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class WebhookController : Controller
{
    private readonly ILogger<WebhookController> logger;
    private readonly IWebhookDispatcher webhookDispatcher;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="logger"><see cref="ILogger{TelegramListener}"/>.</param>
    /// <param name="webhookDispatcher"><see cref="IWebhookDispatcher"/>.</param>
    public WebhookController(
        ILogger<WebhookController> logger, 
        IWebhookDispatcher webhookDispatcher)
    {
        this.logger = logger;
        this.webhookDispatcher = webhookDispatcher;
    }

    /// <summary>
    /// Получает 
    /// </summary>
    /// <param name="update"></param>
    /// <param name="cancellationToken"></param>
    /// 
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Webhook([FromBody]IncomingUpdate update, CancellationToken cancellationToken = default)
    {
        logger.LogWarning("New update received");

        await webhookDispatcher.HandleAsync(update, cancellationToken);

        return JsonResultCamelCase(update);
    }

    private JsonResult JsonResultCamelCase(object? value) =>
        new(value, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        });
}