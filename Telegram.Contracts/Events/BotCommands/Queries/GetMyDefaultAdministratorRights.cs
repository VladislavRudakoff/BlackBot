using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.BotCommands.Queries;

/// <summary>
/// Модель для получения текущие права администратора по умолчанию для бота.
/// </summary>
/// <param name="ForChannels">True - если требуется получить права администратора в каналах. Иначе будут получены права для групп и супергрупп.</param>
public record GetMyDefaultAdministratorRights(
    bool? ForChannels)
    : IEventEntity;