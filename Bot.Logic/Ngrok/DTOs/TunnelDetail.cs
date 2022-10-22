namespace Bot.Logic.Ngrok.DTOs;

/// <summary>
/// Информация о туннеле.
/// </summary>
/// <param name="Name">Имя туннеля.</param>
/// <param name="Id">Идентификатор туннеля.</param>
/// <param name="Uri">Uri-путь до туннеля.</param>
/// <param name="PublicUrl">Публичный Url туннеля.</param>
/// <param name="Proto">Протокол.</param>
/// <param name="Config">Конфигурация.</param>
public record TunnelDetail(
    string Name,
    string Id,
    string Uri,
    string PublicUrl,
    string Proto,
    TunnelConfig Config);