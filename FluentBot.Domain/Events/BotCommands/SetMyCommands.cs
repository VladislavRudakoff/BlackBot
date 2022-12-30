namespace FluentBot.Domain.UseCases.Events.BotCommands;

/// <summary>
/// Модель для создания набора команд.
/// </summary>
/// <param name="Commands">Новый список команд бота(не более 100 команд).</param>
/// <param name="Scope">Круг пользователей, для которых релевантны команды(по умолчанию <see cref="FluentBot.Domain.Entities.Commands.BotCommandScopeDefault"/>).</param>
/// <param name="LanguageCode">Двухбуквенный код языка ISO 639-1(если null - будет показывать команды всем из заданного круга пользователей).</param>
public record SetMyCommands(
    IEnumerable<BotCommand> Commands,
    BotCommandScope? Scope,
    string? LanguageCode)
    : IEventEntity;