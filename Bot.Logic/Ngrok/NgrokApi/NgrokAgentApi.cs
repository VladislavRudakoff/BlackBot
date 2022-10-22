using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bot.Common.Extensions;
using Bot.Logic.Ngrok.DTOs;
using Bot.Logic.Ngrok.Settings;
using Bot.Logic.Ngrok.DTOs.Responses;
using Bot.Logic.Ngrok.NgrokApi.Interfaces;

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

    public async Task<NgrokResponse> GetAllTunnelDetail(CancellationToken cancellationToken = default) =>
        await ngrokHttpClient.GetAsJsonAsync<NgrokResponse>(
            settings.NgrokAgentUrl + "/api/tunnels",
            cancellationToken)
        ?? throw new NotImplementedException();

    public async Task<TunnelDetail> GetTunnelDetail(string tunnelName, CancellationToken cancellationToken = default) =>
        await ngrokHttpClient.GetAsJsonAsync<TunnelDetail>(
            settings.NgrokAgentUrl + $"/api/tunnels/{tunnelName}",
            cancellationToken)
        ?? throw new NotImplementedException();

    public async Task<string> GetPublicUrl(string tunnelName, CancellationToken cancellationToken = default)
    {
        TunnelDetail details = 
            await ngrokHttpClient.GetAsJsonAsync<TunnelDetail>(
                settings.NgrokAgentUrl + $"/api/tunnels/{tunnelName}", 
                cancellationToken)
            ?? throw new NotImplementedException();

        return details.PublicUrl;
    }

    public Task<TunnelDetail> StartTunnel(StartTunnel startTunnel, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task StopTunnel(string tunnelName, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task GetListRequests(int limit, string tunnelName, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}