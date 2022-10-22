using System.Collections.Generic;

namespace Bot.Logic.Ngrok.DTOs.Responses;

/// <summary>
/// Ответ от Ngrok агента.
/// </summary>
/// <param name="Tunnels">Запущенные туннели.</param>
/// <param name="Uri">Uri запроса.</param>
public record NgrokResponse(
    IEnumerable<TunnelDetail>? Tunnels,
    string Uri);