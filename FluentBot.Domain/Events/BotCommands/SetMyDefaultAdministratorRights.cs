namespace FluentBot.Domain.UseCases.Events.BotCommands;

/// <summary>
/// Модель позволяющая задать для бота права администратора по умолчанию.
/// </summary>
/// <param name="Rights">Новые права администратора по умолчанию.</param>
/// <param name="ForChannels">True - если требуется изменить права администратора в каналах. Иначе права будут установлены для групп и супергрупп.</param>
public record SetMyDefaultAdministratorRights(
    ChatAdministratorRights? Rights,
    bool? ForChannels)
    : IEventEntity;