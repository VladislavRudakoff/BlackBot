namespace Bot.Logic.Ngrok.DTOs;

/// <summary>
/// Конфигурация туннеля.
/// </summary>
/// <param name="Addr">Локальный адрес.</param>
/// <param name="Inspect">Маркер проверки трафика.</param>
public record TunnelConfig(
    string Addr,
    bool Inspect);