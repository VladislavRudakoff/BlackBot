using Telegram.Contracts.Enums;

namespace Telegram.Contracts.DTOs.InlineMode.InlineQueryResults;

/// <summary>
/// Базовый объект для результатов встроенных запросов.
/// </summary>
/// <param name="Id"></param>
public abstract record InlineQueryResult(string Id)
{
    protected abstract InlineQueryResultType Type { get; }
}