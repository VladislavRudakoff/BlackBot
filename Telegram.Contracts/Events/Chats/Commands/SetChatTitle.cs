using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands;

/// <summary>
/// Модель для изменения названия чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Title">Новое название чата(1-255 символов).</param>
public record SetChatTitle(
    ChatId ChatId,
    string Title)
    : IEventEntity;