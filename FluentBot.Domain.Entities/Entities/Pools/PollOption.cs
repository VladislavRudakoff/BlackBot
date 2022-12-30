namespace FluentBot.Domain.Entities.Entities.Pools;

/// <summary>
/// Объект содержащий информацию об одном варианте ответа в опросе.
/// </summary>
/// <param name="Text">Дополнительный текст, от 1 до 100 символов.</param>
/// <param name="VoterCount">Количество голосов.</param>
public record PollOption(
    string Text,
    int VoterCount);