namespace FluentBot.Domain.UseCases.Events.BotCommands;

/// <summary>
/// Модель для получения команд.
/// </summary>
/// <param name="Scope">Круг пользователей, для которых релевантны команды(по умолчанию <see cref="FluentBot.Domain.Entities.Commands.BotCommandScopeDefault"/>).</param>
/// <param name="LanguageCode">Двухбуквенный код языка ISO 639-1(если null - будет показывать команды всем из заданного круга пользователей).</param>
public record GetMyCommands(
    BotCommandScope? Scope,
    string? LanguageCode)
    : IEventEntity;