using System;
using Bot.Logic.Ngrok.DTOs.Responses;

namespace Bot.Logic.Ngrok.DTOs.Requests;

/// <summary>
/// Перехваченный запрос.
/// </summary>
/// <param name="Uri">Uri запроса.</param>
/// <param name="Id">Идентификатор запроса.</param>
/// <param name="TunnelName">Имя туннеля.</param>
/// <param name="RemoteAddr">Адрес.</param>
/// <param name="Start">Время начала запроса.</param>
/// <param name="Duration">Продолжительность запроса.</param>
/// <param name="Request">Запрос.</param>
/// <param name="Response">Ответ на запрос.</param>
public record NgrokHttpRequest(
    string Uri,
    string Id,
    string TunnelName,
    string RemoteAddr,
    DateTime Start,
    int Duration,
    Request Request,
    Response Response);