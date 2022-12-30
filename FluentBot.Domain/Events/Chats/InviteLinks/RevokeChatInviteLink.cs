namespace FluentBot.Domain.UseCases.Events.Chats.InviteLinks;

/// <summary>
/// Модель для отзыва ссылки-приглашения.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="InviteLink">Ссылка-приглашение для редактирования.</param>
public record RevokeChatInviteLink(
    ChatId ChatId,
    string InviteLink)
    : IEventEntity;