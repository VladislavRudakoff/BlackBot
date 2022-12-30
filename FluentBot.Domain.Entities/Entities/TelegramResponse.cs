namespace FluentBot.Domain.Entities.Entities;

/// <summary>
/// Ответ от telegram api.
/// </summary>
/// <typeparam name="TResult">Тип результата запроса к telegram api.</typeparam>
/// <param name="Ok">True, если запрос успешен.</param>
/// <param name="Result">Результат запроса.</param>
public record TelegramResponse<TResult>(
    bool Ok,
    TResult Result);