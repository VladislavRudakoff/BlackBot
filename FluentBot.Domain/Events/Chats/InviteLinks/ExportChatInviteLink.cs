namespace FluentBot.Domain.UseCases.Events.Chats.InviteLinks;

/// <summary>
/// Модель для создания основной ссылки-приглашения для чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record ExportChatInviteLink(
    ChatId ChatId)
    : IEventEntity;