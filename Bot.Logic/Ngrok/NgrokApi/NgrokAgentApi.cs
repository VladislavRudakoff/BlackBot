using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bot.Common.Extensions;
using Bot.Logic.Ngrok.DTOs;
using Bot.Logic.Ngrok.Settings;
using Bot.Logic.Ngrok.DTOs.Responses;
using Bot.Logic.Ngrok.NgrokApi.Interfaces;
using Bot.Logic.Ngrok.Exceptions.NotFound;
using Bot.Logic.Ngrok.Exceptions.FailedLaunch;

namespace Bot.Logic.Ngrok.NgrokApi;

/// <inheritdoc cref="INgrokAgentApi"/>
public class NgrokAgentApi : INgrokAgentApi
{
    private readonly HttpClient ngrokHttpClient;
    private readonly NgrokSettings settings;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="ngrokHttpClient"><see cref="HttpClient"/>.</param>
    /// <param name="settings"><see cref="NgrokSettings"/>.</param>
    public NgrokAgentApi(HttpClient ngrokHttpClient, 
        NgrokSettings settings)
    {
        this.ngrokHttpClient = ngrokHttpClient;
        this.settings = settings;
    }

    public async Task<NgrokResponse> GetAllTunnelDetails(CancellationToken cancellationToken = default) =>
        await ngrokHttpClient.GetAsJsonAsync<NgrokResponse>(
            settings.NgrokAgentUrl + "/api/tunnels",
            cancellationToken)
        ?? throw new NotFoundTunnelsException();

    public async Task<TunnelDetail> GetTunnelDetails(string tunnelName, CancellationToken cancellationToken = default) =>
        await ngrokHttpClient.GetAsJsonAsync<TunnelDetail>(
            settings.NgrokAgentUrl + $"/api/tunnels/{tunnelName}",
            cancellationToken)
        ?? throw new NotFoundTunnelDetailException(tunnelName);

    public async Task<string> GetPublicUrl(string tunnelName, CancellationToken cancellationToken = default)
    {
        TunnelDetail details = await GetTunnelDetails(tunnelName, cancellationToken);

        return details.PublicUrl;
    }

    public async Task<TunnelDetail> StartTunnel(StartTunnel startTunnel, CancellationToken cancellationToken = default) => 
        await ngrokHttpClient.PostAsJsonAsync<TunnelDetail>(
            settings.NgrokAgentUrl + "/api/tunnels", 
            startTunnel, 
            cancellationToken) 
        ?? throw new FailedLaunchTunnelException(startTunnel);

    public async Task StopTunnel(string tunnelName, CancellationToken cancellationToken = default) => 
        await ngrokHttpClient.DeleteAsync(settings.NgrokAgentUrl + $"/api/tunnels/{tunnelName}", cancellationToken);
}