using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.InviteLinks;

/// <summary>
/// Модель для создания основной ссылки-приглашения для чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record ExportChatInviteLink(
    ChatId ChatId)
    : IEventEntity;