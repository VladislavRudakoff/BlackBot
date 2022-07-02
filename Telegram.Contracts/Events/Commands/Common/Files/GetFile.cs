using Telegram.Contracts.Events.Commands.Common.Interfaces;

namespace Telegram.Contracts.Events.Commands.Common.Files;

/// <summary>
/// Модель для получения файла.
/// </summary>
/// <param name="FileId">Идентификатор файла.</param>
public record GetFile(
    string FileId)
    : IEventEntity;