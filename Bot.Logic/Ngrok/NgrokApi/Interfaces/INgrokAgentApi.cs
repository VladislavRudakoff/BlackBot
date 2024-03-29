﻿using System.Threading;
using System.Threading.Tasks;
using Bot.Logic.Ngrok.DTOs;
using Bot.Logic.Ngrok.DTOs.Responses;

namespace Bot.Logic.Ngrok.NgrokApi.Interfaces;

/// <summary>
/// Ngrok агент.
/// </summary>
public interface INgrokAgentApi
{
    /// <summary>
    /// Получает информацию обо всех туннелях.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Коллекция <see cref="TunnelDetail"/>'s.</returns>
    public Task<NgrokResponse> GetAllTunnelDetails(CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает информацию о туннеле.
    /// </summary>
    /// <param name="tunnelName">Имя туннеля.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="TunnelDetail"/>.</returns>
    public Task<TunnelDetail> GetTunnelDetails(string tunnelName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает публичный Url туннеля.
    /// </summary>
    /// <param name="tunnelName">Имя туннеля.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Публичный Url.</returns>
    public Task<string> GetPublicUrl(string tunnelName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Запускает туннель.
    /// </summary>
    /// <param name="startTunnel"><see cref="StartTunnel"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns></returns>
    public Task<TunnelDetail> StartTunnel(StartTunnel startTunnel, CancellationToken cancellationToken = default);

    /// <summary>
    /// Останавливает туннель.
    /// </summary>
    /// <param name="tunnelName">Имя туннеля.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns></returns>
    public Task StopTunnel(string tunnelName, CancellationToken cancellationToken = default);
}