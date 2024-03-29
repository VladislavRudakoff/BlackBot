﻿namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults;

/// <summary>
/// Базовый объект для результатов встроенных запросов.
/// </summary>
/// <param name="Id">Уникальный идентификатор результата.</param>
public abstract record InlineQueryResult(string Id)
{
    /// <summary>
    /// Тип результата.
    /// </summary>
    protected abstract InlineQueryResultType Type { get; }
}