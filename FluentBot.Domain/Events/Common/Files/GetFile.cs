namespace FluentBot.Domain.UseCases.Events.Common.Files;

/// <summary>
/// Модель для получения файла.
/// </summary>
/// <param name="FileId">Идентификатор файла.</param>
public record GetFile(
    string FileId)
    : IEventEntity;