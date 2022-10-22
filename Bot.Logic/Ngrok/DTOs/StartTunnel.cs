namespace Bot.Logic.Ngrok.DTOs;

/// <summary>
/// Модель для запуска туннеля.
/// </summary>
/// <param name="Addr">Адрес туннеля(достаточно указать порт). Например: при значении 88 запустится туннель к адресу - localhost:88.</param>
/// <param name="Proto">Протокол туннеля.</param>
/// <param name="Name">Имя туннеля.</param>
public record StartTunnel(
    string Addr,
    string Proto,
    string Name);