namespace FluentBot.Domain.Entities.Entities.InlineMode;

/// <summary>
/// Входящий inline-запрос.
/// </summary>
/// <param name="Id">Идентификатор входящего запроса.</param>
/// <param name="From">Отправитель.</param>
/// <param name="Query">Текст запроса(до 256 символов).</param>
/// <param name="Offset">Смещение возвращаемых результатов.</param>
/// <param name="ChatType">Тип чата.</param>
/// <param name="Location">Местоположение отправителя(только для ботов, запрашивающих местоположение).</param>
public record InlineQuery(
    string Id,
    User From,
    string Query,
    string Offset,
    string? ChatType,
    Location? Location);