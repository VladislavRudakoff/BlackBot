using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands;

/// <summary>
/// Модель для удаления фотографии чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record DeleteChatPhoto(
    ChatId ChatId)
    : IEventEntity;