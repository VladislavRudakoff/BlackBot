namespace FluentBot.Domain.Entities.Entities;

/// <summary>
/// Информация о том, почему запрос был неудачным.
/// </summary>
/// <param name="MigrateToChatId">Группа перенесена в супергруппу с указанным идентификатором.</param>
/// <param name="RetryAfter">Количество секунд, оставшееся до повторного запроса(контроль флуда).</param>
public record ResponseParameters(
    long? MigrateToChatId,
    int? RetryAfter);