using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Common.Queries.Files;

/// <summary>
/// Модель для получения файла.
/// </summary>
/// <param name="FileId">Идентификатор файла.</param>
public record GetFile(
    string FileId)
    : IEventEntity;