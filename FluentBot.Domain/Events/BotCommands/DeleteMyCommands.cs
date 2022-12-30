namespace FluentBot.Domain.UseCases.Events.BotCommands;

/// <summary>
/// Модель для удаления списка команд для данной области и языка пользователя.
/// </summary>
/// <param name="Scope">Круг пользователей, для которых релевантны команды(по умолчанию <see cref="FluentBot.Domain.Entities.Commands.BotCommandScopeDefault"/>).</param>
/// <param name="LanguageCode">Двухбуквенный код языка ISO 639-1(если null - будет показывать команды всем из заданного круга пользователей).</param>
public record DeleteMyCommands(
    BotCommandScope? Scope,
    string? LanguageCode)
    : IEventEntity;