using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Ngrok.NgrokApi.Interfaces;
using Bot.Logic.Ngrok.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Contracts.ApiClients.Interfaces;

namespace Bot.WebApi.HostedServices;

public class HostedService : IHostedService
{
    private readonly string command;
    private string NgrokFileName => "ngrok.exe";
    private string BaseTunnelName => "command_line";

    private Process Process { get; set; } = null!;

    private readonly IServiceProvider serviceProvider;

    public HostedService(NgrokSettings ngrokSettings, IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
        command = ngrokSettings.CmdText + ngrokSettings.WebhookUrl;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        ProcessStartInfo startInfo = new()
        {
            Arguments = command,
            FileName = NgrokFileName,
            WindowStyle = ProcessWindowStyle.Hidden,
            CreateNoWindow = true
        };

        Process = Process.Start(startInfo)
            ?? throw new InvalidOperationException("Failed to start process");

        await using AsyncServiceScope scope = serviceProvider.CreateAsyncScope();
        IBotTelegramClient botTelegramClient =
            scope.ServiceProvider.GetRequiredService<IBotTelegramClient>();
        INgrokAgentApi ngrokAgent =
            scope.ServiceProvider.GetRequiredService<INgrokAgentApi>();

        string publicUrl = await ngrokAgent.GetPublicUrl(BaseTunnelName, cancellationToken);

        await botTelegramClient.SetWebhookAsync(new(publicUrl + "/webhook"), cancellationToken);
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Process.CloseMainWindow();

        await using AsyncServiceScope scope = serviceProvider.CreateAsyncScope();

        INgrokAgentApi ngrokAgent =
            scope.ServiceProvider.GetRequiredService<INgrokAgentApi>();

        await ngrokAgent.StopTunnel(BaseTunnelName, cancellationToken);
    }
}