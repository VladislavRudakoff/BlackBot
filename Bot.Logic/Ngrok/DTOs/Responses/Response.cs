namespace Bot.Logic.Ngrok.DTOs.Responses;

/// <summary>
/// Ответ.
/// </summary>
/// <param name="Status">Статус ответа.</param>
/// <param name="StatusCode">Статус код ответа.</param>
/// <param name="Proto">Протокол.</param>
/// <param name="Raw">????</param>
public record Response(
    string Status,
    int StatusCode,
    string Proto,
    string Raw);