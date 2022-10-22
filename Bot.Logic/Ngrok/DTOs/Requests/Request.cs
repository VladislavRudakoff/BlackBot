namespace Bot.Logic.Ngrok.DTOs.Requests;

/// <summary>
/// Запрос.
/// </summary>
/// <param name="Method">Метод запроса(GET, POST и т.д.).</param>
/// <param name="Proto">Протокол.</param>
/// <param name="Uri">Uri запроса.</param>
/// <param name="Raw">?????</param>
public record Request(
    string Method,
    string Proto,
    string Uri,
    string Raw);